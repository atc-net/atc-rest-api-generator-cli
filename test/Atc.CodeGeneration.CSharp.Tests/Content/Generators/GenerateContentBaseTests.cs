namespace Atc.CodeGeneration.CSharp.Tests.Content.Generators;

public abstract class GenerateContentBaseTests
{
    protected const string HeaderContent = @"//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator X.X.X.X.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------";

    protected readonly ICodeDocumentationTagsGenerator codeDocumentationTagsGenerator;

    protected GenerateContentBaseTests()
    {
        codeDocumentationTagsGenerator = new CodeDocumentationTagsGenerator();
    }
}