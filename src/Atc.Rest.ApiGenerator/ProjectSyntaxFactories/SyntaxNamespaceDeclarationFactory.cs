namespace Atc.Rest.ApiGenerator.ProjectSyntaxFactories;

internal static class SyntaxNamespaceDeclarationFactory
{
    public static NamespaceDeclarationSyntax Create(
        string fullNamespace)
    {
        ArgumentNullException.ThrowIfNull(fullNamespace);

        return SyntaxFactory.NamespaceDeclaration(
            SyntaxFactory.IdentifierName(fullNamespace));
    }

    public static NamespaceDeclarationSyntax Create(
        string generatedByToolAndVersion,
        string fullNamespace)
    {
        ArgumentNullException.ThrowIfNull(generatedByToolAndVersion);
        ArgumentNullException.ThrowIfNull(fullNamespace);

        return SyntaxFactory.NamespaceDeclaration(
                SyntaxFactory.IdentifierName(fullNamespace))
            .WithNamespaceKeyword(
                SyntaxFactory.Token(
                    SyntaxFactory.TriviaList(
                        SyntaxFactory.Comment("//------------------------------------------------------------------------------"),
                        SyntaxFactory.Comment($"// This code was auto-generated by {generatedByToolAndVersion}."),
                        SyntaxFactory.Comment("//"),
                        SyntaxFactory.Comment("// Changes to this file may cause incorrect behavior and will be lost if"),
                        SyntaxFactory.Comment("// the code is regenerated."),
                        SyntaxFactory.Comment("//------------------------------------------------------------------------------")),
                    SyntaxKind.NamespaceKeyword,
                    SyntaxFactory.TriviaList()));
    }
}