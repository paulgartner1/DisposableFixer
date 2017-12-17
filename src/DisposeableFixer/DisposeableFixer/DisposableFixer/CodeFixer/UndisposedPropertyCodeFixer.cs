﻿using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DisposableFixer.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.Text;

namespace DisposableFixer.CodeFixer
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(UndisposedPropertyCodeFixer)), Shared]
    public class UndisposedPropertyCodeFixer : CodeFixProvider
    {
        public override ImmutableArray<string> FixableDiagnosticIds { get; } =
            ImmutableArray.Create(
                SyntaxNodeAnalysisContextExtension.IdForAssignmendFromMethodInvocationToPropertyNotDisposed,
                SyntaxNodeAnalysisContextExtension.IdForAssignmendFromObjectCreationToPropertyNotDisposed,
                SyntaxNodeAnalysisContextExtension.IdForAssignmendFromMethodInvocationToFieldNotDisposed,
                SyntaxNodeAnalysisContextExtension.IdForAssignmendFromObjectCreationToFieldNotDisposed
                );

        public override Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            RegisterCodeActionsForUndisposedProperties(context);
            RegisterCodeActionsForUndisposedFields(context);
            
            return Task.FromResult(1);
        }

        private static void RegisterCodeActionsForUndisposedProperties(CodeFixContext context)
        {
            var id = context.Diagnostics.First().Id;
            if (id == SyntaxNodeAnalysisContextExtension.IdForAssignmendFromObjectCreationToPropertyNotDisposed
                || id  == SyntaxNodeAnalysisContextExtension.IdForAssignmendFromMethodInvocationToPropertyNotDisposed) {
                context.RegisterCodeFix(
                    CodeAction.Create("Dispose property in Dispose() method", c => CreateDisposeCallInParameterlessDisposeMethod(context, c)),
                    context.Diagnostics);
            }
        }

        private static void RegisterCodeActionsForUndisposedFields(CodeFixContext context) {
            var id = context.Diagnostics.First().Id;
            if (id == SyntaxNodeAnalysisContextExtension.IdForAssignmendFromObjectCreationToFieldNotDisposed
                || id == SyntaxNodeAnalysisContextExtension.IdForAssignmendFromMethodInvocationToFieldNotDisposed) {
                context.RegisterCodeFix(
                    CodeAction.Create("Dispose field in Dispose() method", c => CreateDisposeCallInParameterlessDisposeMethod(context, c)),
                    context.Diagnostics);
            }
        }

        private static async Task<Document> CreateDisposeCallInParameterlessDisposeMethod(CodeFixContext context, CancellationToken cancel)
        {
            var oldRoot = await context.Document.GetSyntaxRootAsync(cancel);
            var node = oldRoot.FindNode(context.Span);
            var variableName = context.Diagnostics.First().Properties[Constants.Variablename];

            ClassDeclarationSyntax oldClass;
            if (node.TryFindParentClass(out oldClass))
            {
                var model = await context.Document.GetSemanticModelAsync(cancel);
                var @classtype =
                    model.GetEnclosingSymbol(context.Span.Start, cancel).ContainingSymbol as INamedTypeSymbol;
                if (@classtype == null) return context.Document;


                var disposeMethods = oldClass
                    .DescendantNodes<MethodDeclarationSyntax>()
                    .Where(mds => mds.Identifier.Text == Constants.Dispose && mds.ParameterList.Parameters.Count == 0)
                    .ToArray();
                SyntaxNode newRoot;
                if (disposeMethods.Any())
                {
                    var oldDisposeMethod = disposeMethods.First();
                    var disposeCall = SyntaxFactory
                        .ExpressionStatement(
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    SyntaxFactory.IdentifierName(variableName),
                                    SyntaxFactory.IdentifierName(Constants.Dispose))))
                        .NormalizeWhitespace();
                    var newdisposeMethod = oldDisposeMethod.AddBodyStatements(disposeCall);

                    var implementsIDisposable =
                        @classtype.AllInterfaces.Any(i => i.GetFullNamespace() == Constants.SystemIDisposable);
                    ClassDeclarationSyntax newClass;
                    if (implementsIDisposable)
                    {
                        newClass = oldClass;
                    }
                    else if (oldClass.BaseList == null)
                    {
                        newClass = SyntaxFactory
                            .ClassDeclaration(oldClass.Identifier.Text)
                            .WithModifiers(oldClass.Modifiers)
                            .WithBaseList(
                                SyntaxFactory.BaseList(
                                    SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(ImplementIDisposable())))
                            .WithMembers(oldClass.Members)
                            .NormalizeWhitespace();
                    }
                    else
                    {
                        var newBaseList =
                            oldClass.BaseList.AddTypes(
                                SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName(Constants.IDisposable))
                                    .NormalizeWhitespace());
                        newClass = oldClass.ReplaceNode(oldClass.BaseList, newBaseList);
                    }

                    newClass = newClass.ReplaceNode(oldDisposeMethod, newdisposeMethod);
                    newRoot = oldRoot.ReplaceNode(oldClass, newClass);
                }
                else
                {
                    var disposeMethod = SyntaxFactory
                        .MethodDeclaration(
                            SyntaxFactory.PredefinedType(
                                SyntaxFactory.Token(SyntaxKind.VoidKeyword)),
                            SyntaxFactory.Identifier(Constants.Dispose))
                        .WithModifiers(
                            SyntaxFactory.TokenList(
                                SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                        .WithBody(
                            SyntaxFactory.Block(
                                SyntaxFactory.SingletonList<StatementSyntax>(
                                    SyntaxFactory.ExpressionStatement(
                                        SyntaxFactory.InvocationExpression(
                                            SyntaxFactory.MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                SyntaxFactory.IdentifierName(variableName),
                                                SyntaxFactory.IdentifierName(Constants.Dispose)))))))
                        .NormalizeWhitespace();

                    var implementsIDisposable =
                        @classtype.AllInterfaces.Any(i => i.GetFullNamespace() == Constants.SystemIDisposable);
                    ClassDeclarationSyntax newClass;
                    if (implementsIDisposable)
                    {
                        newClass = oldClass;
                    }
                    else if (oldClass.BaseList == null)
                    {
                        newClass = SyntaxFactory
                            .ClassDeclaration(oldClass.Identifier.Text)
                            .WithModifiers(oldClass.Modifiers)
                            .WithBaseList(
                                SyntaxFactory.BaseList(
                                    SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(ImplementIDisposable())))
                            .WithMembers(oldClass.Members)
                            .NormalizeWhitespace();
                    }
                    else
                    {
                        var newBaseList =
                            oldClass.BaseList.AddTypes(
                                SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName(Constants.IDisposable))
                                    .NormalizeWhitespace());
                        newClass = oldClass.ReplaceNode(oldClass.BaseList, newBaseList);
                    }

                    newRoot = oldRoot.ReplaceNode(oldClass, newClass.AddMembers(disposeMethod));
                }
                //var editor = await DocumentEditor.CreateAsync(context.Document, context.CancellationToken);
                
                return context.Document.WithSyntaxRoot(newRoot);
            }

            return context.Document;
        }

        private static SimpleBaseTypeSyntax ImplementIDisposable()
        {
            return SyntaxFactory.SimpleBaseType(
                SyntaxFactory.IdentifierName(Constants.IDisposable));
        }
    }
}