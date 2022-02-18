// ReSharper disable InvertIf
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable ReturnTypeCanBeEnumerable.Local
namespace Atc.Rest.ApiGenerator.Generators;

public class ServerDomainGenerator
{
    private readonly ILogger logger;
    private readonly DomainProjectOptions projectOptions;

    public ServerDomainGenerator(
        ILogger logger,
        DomainProjectOptions projectOptions)
    {
        this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        this.projectOptions = projectOptions ?? throw new ArgumentNullException(nameof(projectOptions));
    }

    public bool Generate()
    {
        logger.LogInformation($"{AppEmojisConstants.AreaGenerateCode} Working on server domain generation ({projectOptions.ProjectName})");

        if (!projectOptions.SetPropertiesAfterValidationsOfProjectReferencesPathAndFiles(logger))
        {
            return false;
        }

        ScaffoldSrc();
        GenerateSrcHandlers(projectOptions, out var sgHandlers);

        if (projectOptions.PathForTestGenerate is not null)
        {
            logger.LogInformation($"{AppEmojisConstants.AreaGenerateTest} Working on server domain unit-test generation ({projectOptions.ProjectName}.Tests)");
            ScaffoldTest();
            GenerateTestHandlers(projectOptions, sgHandlers);
        }

        return true;
    }

    private void GenerateSrcHandlers(
        DomainProjectOptions domainProjectOptions,
        out List<SyntaxGeneratorHandler> sgHandlers)
    {
        ArgumentNullException.ThrowIfNull(domainProjectOptions);

        sgHandlers = new List<SyntaxGeneratorHandler>();
        foreach (var basePathSegmentName in domainProjectOptions.BasePathSegmentNames)
        {
            var generatorHandlers = new SyntaxGeneratorHandlers(logger, domainProjectOptions, basePathSegmentName);
            var generatedHandlers = generatorHandlers.GenerateSyntaxTrees();
            sgHandlers.AddRange(generatedHandlers);
        }

        foreach (var sg in sgHandlers)
        {
            sg.ToFile();
        }
    }

    private void GenerateTestHandlers(
        DomainProjectOptions domainProjectOptions,
        List<SyntaxGeneratorHandler> sgHandlers)
    {
        ArgumentNullException.ThrowIfNull(domainProjectOptions);
        ArgumentNullException.ThrowIfNull(sgHandlers);

        if (domainProjectOptions.PathForTestHandlers is not null)
        {
            foreach (var sgHandler in sgHandlers)
            {
                GenerateServerDomainXunitTestHelper.GenerateGeneratedTests(logger, domainProjectOptions, sgHandler);
                GenerateServerDomainXunitTestHelper.GenerateCustomTests(logger, domainProjectOptions, sgHandler);
            }
        }
    }

    private void ScaffoldSrc()
    {
        if (!Directory.Exists(projectOptions.PathForSrcGenerate.FullName))
        {
            Directory.CreateDirectory(projectOptions.PathForSrcGenerate.FullName);
        }

        if (projectOptions.PathForSrcGenerate.Exists &&
            projectOptions.ProjectSrcCsProj.Exists)
        {
            var element = XElement.Load(projectOptions.ProjectSrcCsProj.FullName);
            var originalNullableValue = SolutionAndProjectHelper.GetBoolFromNullableString(SolutionAndProjectHelper.GetNullableValueFromProject(element));

            var hasUpdates = false;
            if (projectOptions.UseNullableReferenceTypes != originalNullableValue)
            {
                var newNullableValue = SolutionAndProjectHelper.GetNullableStringFromBool(projectOptions.UseNullableReferenceTypes);
                SolutionAndProjectHelper.SetNullableValueForProject(element, newNullableValue);
                element.Save(projectOptions.ProjectSrcCsProj.FullName);
                logger.LogDebug($"{EmojisConstants.FileUpdated}   Update domain csproj - Nullable value={newNullableValue}");
                hasUpdates = true;
            }

            if (!hasUpdates)
            {
                logger.LogDebug($"{EmojisConstants.FileNotUpdated}   No updates for domain csproj");
            }
        }
        else
        {
            var projectReferences = new List<FileInfo>();
            if (projectOptions.ApiProjectSrcCsProj is not null)
            {
                projectReferences.Add(projectOptions.ApiProjectSrcCsProj);
            }

            SolutionAndProjectHelper.ScaffoldProjFile(
                logger,
                projectOptions.ProjectSrcCsProj,
                projectOptions.ProjectSrcCsProjDisplayLocation,
                createAsWeb: false,
                createAsTestProject: false,
                projectOptions.ProjectName,
                "net6.0",
                new List<string> { "Microsoft.AspNetCore.App" },
                packageReferences: null,
                projectReferences,
                includeApiSpecification: false,
                usingCodingRules: projectOptions.UsingCodingRules);
        }

        ScaffoldBasicFileDomainRegistration();
    }

    private void ScaffoldTest()
    {
        if (projectOptions.PathForTestGenerate is null ||
            projectOptions.ProjectTestCsProj is null)
        {
            return;
        }

        if (projectOptions.PathForTestGenerate.Exists &&
            projectOptions.ProjectTestCsProj.Exists)
        {
            // Update
        }
        else
        {
            if (!Directory.Exists(projectOptions.PathForTestGenerate.FullName))
            {
                Directory.CreateDirectory(projectOptions.PathForTestGenerate.FullName);
            }

            var projectReferences = new List<FileInfo>();
            if (projectOptions.ApiProjectSrcCsProj is not null)
            {
                projectReferences.Add(projectOptions.ApiProjectSrcCsProj);
                projectReferences.Add(projectOptions.ProjectSrcCsProj);
            }

            SolutionAndProjectHelper.ScaffoldProjFile(
                logger,
                projectOptions.ProjectTestCsProj,
                projectOptions.ProjectTestCsProjDisplayLocation,
                createAsWeb: false,
                createAsTestProject: true,
                $"{projectOptions.ProjectName}.Tests",
                "net6.0",
                frameworkReferences: null,
                NugetPackageReferenceHelper.CreateForTestProject(false),
                projectReferences,
                includeApiSpecification: true,
                usingCodingRules: projectOptions.UsingCodingRules);
        }
    }

    private void ScaffoldBasicFileDomainRegistration()
    {
        // Create compilationUnit
        var compilationUnit = SyntaxFactory.CompilationUnit();

        // Create a namespace
        var @namespace = SyntaxProjectFactory.CreateNamespace(projectOptions);

        // Create class
        var classDeclaration = SyntaxClassDeclarationFactory.Create("DomainRegistration")
            .AddGeneratedCodeAttribute(projectOptions.ToolName, projectOptions.ToolVersion.ToString());

        // Add class to namespace
        @namespace = @namespace.AddMembers(classDeclaration);

        // Add using statement to compilationUnit
        compilationUnit = compilationUnit.AddUsingStatements(new[] { "System.CodeDom.Compiler" });

        // Add namespace to compilationUnit
        compilationUnit = compilationUnit.AddMembers(@namespace);

        var codeAsString = compilationUnit
            .NormalizeWhitespace()
            .ToFullString()
            .EnsureEnvironmentNewLines();

        var file = new FileInfo(Path.Combine(projectOptions.PathForSrcGenerate.FullName, "DomainRegistration.cs"));
        var fileDisplayLocation = file.FullName.Replace(projectOptions.PathForSrcGenerate.FullName, "src: ", StringComparison.Ordinal);
        TextFileHelper.Save(logger, file, fileDisplayLocation, codeAsString);
    }
}