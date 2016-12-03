using System.Linq;
using DisposableFixer.Extensions;
using FluentAssertions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NUnit.Framework;

namespace DisposableFixer.Test.Extensions.SyntaxNodeExtensionsSpecs
{
    [TestFixture]
    internal class If_FindContainingClass_is_called_on_FieldDeclaration_of_a_private_Class : Spec
    {
        private ClassDeclarationSyntax _classDeclarationSyntax;
        private const string Code = @"
namespace DisFixerTest.Misc
{
    public class ClassWithFieldBla
    {
        public ClassWithFieldBla(){}
        public string Dis { get; set; }
        private void Do(){}
        private string Bla;

        private class PrivateClass
        {
            public PrivateClass(){}
            public string Dis { get; set; }
            private void Do() {}
            private string Bla;
        }
    }
}
";

        protected override void BecauseOf()
        {
            var fieldDeclarationSyntax = MyHelper.CompileAndRetrieveRootNode(Code)
                .DescendantNodes()
                .OfType<FieldDeclarationSyntax>()
                .LastOrDefault();

            _classDeclarationSyntax = fieldDeclarationSyntax.FindContainingClass();
        }

        [Test]
        public void Then_Result_should_be_class_named_PrivateClass()
        {
            _classDeclarationSyntax.Identifier.Text.Should().Be("PrivateClass");
        }


        [Test]
        public void Then_Result_should_not_be_null()
        {
            _classDeclarationSyntax.Should().NotBeNull();
        }
    }
}