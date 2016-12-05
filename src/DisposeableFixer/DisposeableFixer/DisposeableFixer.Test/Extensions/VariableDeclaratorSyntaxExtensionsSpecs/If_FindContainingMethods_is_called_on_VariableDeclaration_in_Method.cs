﻿using System.Linq;
using DisposableFixer.Extensions;
using FluentAssertions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NUnit.Framework;

namespace DisposableFixer.Test.Extensions.VariableDeclaratorSyntaxExtensionsSpecs
{
    [TestFixture]
    internal class If_FindContainingMethods_is_called_on_VariableDeclaration_in_Method : Spec
    {
        private MethodDeclarationSyntax _methodDeclarationSyntax;
        private const string Code = @"
using System;
namespace DisFixerTest.Misc{
    public class ClassWithtoutFields    {
        private void Do()
        {
            var integer = 3;
        }
    }
}
";

        protected override void BecauseOf()
        {
            var variableDeclaratorSyntax = MyHelper.CompileAndRetrieveRootNode(Code)
                .DescendantNodes()
                .OfType<VariableDeclaratorSyntax>()
                .FirstOrDefault();

             variableDeclaratorSyntax.TryFindContainingMethod(out _methodDeclarationSyntax);
        }


        [Test]
        public void Then_result_should_be_method_named_Do()
        {
            _methodDeclarationSyntax.Identifier.Text.Should().Be("Do");
        }
    }
}