// ReSharper disable ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable ReturnTypeCanBeEnumerable.Local
// ReSharper disable StringLiteralTypo
namespace Atc.Rest.ApiGenerator.Generators;

public class ServerHostGenerator
{
    private readonly ILogger logger;
    private readonly INugetPackageReferenceProvider nugetPackageReferenceProvider;
    private readonly HostProjectOptions projectOptions;

    private readonly IServerHostGenerator serverHostGeneratorMvc;
    private readonly IServerHostGenerator serverHostGeneratorMinimalApi;

    private readonly string codeGeneratorContentHeader;
    private readonly AttributeParameters codeGeneratorAttribute;

    public ServerHostGenerator(
        ILoggerFactory loggerFactory,
        INugetPackageReferenceProvider nugetPackageReferenceProvider,
        HostProjectOptions projectOptions)
    {
        ArgumentNullException.ThrowIfNull(loggerFactory);

        logger = loggerFactory.CreateLogger<ServerDomainGenerator>();
        this.nugetPackageReferenceProvider = nugetPackageReferenceProvider ?? throw new ArgumentNullException(nameof(nugetPackageReferenceProvider));
        this.projectOptions = projectOptions ?? throw new ArgumentNullException(nameof(projectOptions));

        serverHostGeneratorMvc = new Framework.Mvc.ProjectGenerator.ServerHostGenerator(
            loggerFactory,
            projectOptions.ApiGeneratorVersion,
            projectOptions.ProjectName,
            projectOptions.PathForSrcGenerate);

        serverHostGeneratorMinimalApi = new Framework.Minimal.ProjectGenerator.ServerHostGenerator(
            loggerFactory,
            projectOptions.ApiGeneratorVersion,
            projectOptions.ProjectName,
            projectOptions.PathForSrcGenerate);

        // TODO: Optimize codeGeneratorContentHeader & codeGeneratorAttribute
        var codeHeaderGenerator = new GeneratedCodeHeaderGenerator(
            new GeneratedCodeGeneratorParameters(
                projectOptions.ApiGeneratorVersion));
        codeGeneratorContentHeader = codeHeaderGenerator.Generate();

        codeGeneratorAttribute = new AttributeParameters(
            "GeneratedCode",
            $"\"{ContentWriterConstants.ApiGeneratorName}\", \"{projectOptions.ApiGeneratorVersion}\"");
    }

    public bool Generate()
    {
        logger.LogInformation($"{ContentWriterConstants.AreaGenerateCode} Working on server host generation ({projectOptions.ProjectName})");

        if (projectOptions.AspNetOutputType == AspNetOutputType.Mvc)
        {
            if (!projectOptions.SetPropertiesAfterValidationsOfProjectReferencesPathAndFilesForMvc(logger))
            {
                return false;
            }
        }
        else
        {
            if (!projectOptions.SetPropertiesAfterValidationsOfProjectReferencesPathAndFilesForMinimalApi(logger))
            {
                return false;
            }
        }

        ScaffoldSrc();

        if (projectOptions.AspNetOutputType == AspNetOutputType.Mvc)
        {
            serverHostGeneratorMvc.MaintainGlobalUsings(
                projectOptions.ProjectName.Replace(".Api", ".Domain", StringComparison.Ordinal),
                projectOptions.ApiGroupNames,
                projectOptions.RemoveNamespaceGroupSeparatorInGlobalUsings);
        }
        else
        {
            serverHostGeneratorMinimalApi.MaintainGlobalUsings(
                projectOptions.ProjectName.Replace(".Api", ".Domain", StringComparison.Ordinal),
                projectOptions.ApiGroupNames,
                projectOptions.RemoveNamespaceGroupSeparatorInGlobalUsings);
        }

        if (projectOptions.PathForTestGenerate is not null)
        {
            logger.LogInformation($"{ContentWriterConstants.AreaGenerateTest} Working on server host unit-test generation ({projectOptions.ProjectName}.Tests)");
            ScaffoldTest();

            if (projectOptions.AspNetOutputType == AspNetOutputType.Mvc)
            {
                GenerateTestEndpoints(projectOptions.Document);
            }

            GenerateTestGlobalUsings(projectOptions.UsingCodingRules, projectOptions.RemoveNamespaceGroupSeparatorInGlobalUsings);
        }

        return true;
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
            var hasUpdates = SolutionAndProjectHelper.EnsureLatestPackageReferencesVersionInProjFile(
                logger,
                projectOptions.ProjectSrcCsProj,
                projectOptions.ProjectSrcCsProjDisplayLocation,
                ProjectType.ServerHost,
                isTestProject: false);
            if (!hasUpdates)
            {
                logger.LogDebug($"{EmojisConstants.FileNotUpdated}   No updates for csproj");
            }
        }
        else
        {
            var projectReferences = new List<FileInfo>();
            if (projectOptions.ApiProjectSrcCsProj is not null)
            {
                projectReferences.Add(projectOptions.ApiProjectSrcCsProj);
            }

            if (projectOptions.DomainProjectSrcCsProj is not null)
            {
                projectReferences.Add(projectOptions.DomainProjectSrcCsProj);
            }

            IList<(string PackageId, string PackageVersion, string? SubElements)>? packageReferencesBaseLineForHostProject = null;
            TaskHelper.RunSync(async () =>
            {
                if (projectOptions.AspNetOutputType == AspNetOutputType.Mvc)
                {
                    packageReferencesBaseLineForHostProject = await nugetPackageReferenceProvider.GetPackageReferencesBaseLineForHostProjectForMvc(projectOptions.UseRestExtended);
                }
                else
                {
                    packageReferencesBaseLineForHostProject = await nugetPackageReferenceProvider.GetPackageReferencesBaseLineForHostProjectForMinimalApi();
                }
            });

            SolutionAndProjectHelper.ScaffoldProjFile(
                logger,
                projectOptions.ProjectSrcCsProj,
                projectOptions.ProjectSrcCsProjDisplayLocation,
                ProjectType.ServerHost,
                createAsWeb: true,
                createAsTestProject: false,
                projectOptions.ProjectName,
                "net8.0",
                frameworkReferences: null,
                packageReferencesBaseLineForHostProject,
                projectReferences,
                includeApiSpecification: false,
                usingCodingRules: projectOptions.UsingCodingRules);

            ScaffoldPropertiesLaunchSettingsFile(
                projectOptions.ProjectName,
                projectOptions.PathForSrcGenerate,
                projectOptions.UseRestExtended);

            ScaffoldProgramFile();
            ScaffoldStartupFile();
            ScaffoldWebConfig();

            // TODO: Deviate on minimal API
            if (projectOptions.UseRestExtended)
            {
                ScaffoldConfigureSwaggerDocOptions();
            }
        }
    }

    private void ScaffoldPropertiesLaunchSettingsFile(
        string projectName,
        DirectoryInfo pathForSrcGenerate,
        bool useExtended)
    {
        var propertiesPath = new DirectoryInfo(Path.Combine(pathForSrcGenerate.FullName, "Properties"));
        propertiesPath.Create();

        var resourceName = "Atc.Rest.ApiGenerator.Resources.launchSettings.json";
        if (useExtended)
        {
            resourceName = "Atc.Rest.ApiGenerator.Resources.launchSettingsExtended.json";
        }

        var resourceStream = typeof(ServerHostGenerator).Assembly.GetManifestResourceStream(resourceName);
        var json = resourceStream!.ToStringData();
        json = json.Replace("\"[[PROJECTNAME]]\":", $"\"{projectName}\":", StringComparison.Ordinal);

        var file = new FileInfo(Path.Combine(propertiesPath.FullName, "launchSettings.json"));

        if (file.Exists)
        {
            logger.LogTrace($"{EmojisConstants.FileNotUpdated}   {file.FullName} nothing to update");
        }
        else
        {
            var contentWriter = new ContentWriter(logger);
            contentWriter.Write(
                projectOptions.PathForSrcGenerate,
                file,
                ContentWriterArea.Src,
                json);
        }
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
            var hasUpdates = SolutionAndProjectHelper.EnsureLatestPackageReferencesVersionInProjFile(
                logger,
                projectOptions.ProjectTestCsProj,
                projectOptions.ProjectTestCsProjDisplayLocation,
                ProjectType.ServerHost,
                isTestProject: true);
            if (!hasUpdates)
            {
                logger.LogDebug($"{EmojisConstants.FileNotUpdated}   No updates for csproj");
            }
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
                projectReferences.Add(projectOptions.ProjectSrcCsProj);
                projectReferences.Add(projectOptions.ApiProjectSrcCsProj);
            }

            if (projectOptions.DomainProjectSrcCsProj is not null)
            {
                projectReferences.Add(projectOptions.DomainProjectSrcCsProj);
            }

            IList<(string PackageId, string PackageVersion, string? SubElements)>? packageReferencesBaseLineForTestProject = null;
            TaskHelper.RunSync(async () =>
            {
                packageReferencesBaseLineForTestProject = await nugetPackageReferenceProvider.GetPackageReferencesBaseLineForTestProject(useMvc: true);
            });

            SolutionAndProjectHelper.ScaffoldProjFile(
                logger,
                projectOptions.ProjectTestCsProj,
                projectOptions.ProjectTestCsProjDisplayLocation,
                ProjectType.ServerHost,
                createAsWeb: false,
                createAsTestProject: true,
                $"{projectOptions.ProjectName}.Tests",
                "net8.0",
                frameworkReferences: null,
                packageReferencesBaseLineForTestProject,
                projectReferences,
                includeApiSpecification: true,
                usingCodingRules: projectOptions.UsingCodingRules);
        }

        GenerateTestWebApiStartupFactory();
        GenerateTestWebApiControllerBaseTest();
        ScaffoldAppSettingsIntegrationTest();
    }

    private void GenerateTestEndpoints(
        OpenApiDocument document)
    {
        foreach (var openApiPath in document.Paths)
        {
            var apiGroupName = openApiPath.GetApiGroupName();

            foreach (var openApiOperation in openApiPath.Value.Operations)
            {
                GenerateTestEndpointHandlerStub(apiGroupName, openApiPath.Value, openApiOperation.Value);
                GenerateTestEndpointTests(apiGroupName, openApiOperation.Value);
            }
        }
    }

    private void GenerateTestEndpointHandlerStub(
        string apiGroupName,
        OpenApiPathItem openApiPath,
        OpenApiOperation openApiOperation)
    {
        var fullNamespace = $"{projectOptions.ProjectName}.{ContentGeneratorConstants.Tests}.{ContentGeneratorConstants.Endpoints}.{apiGroupName}";

        // Generate
        var classParameters = ContentGeneratorServerTestEndpointHandlerStubParametersFactory.Create(
            codeGeneratorContentHeader,
            fullNamespace,
            codeGeneratorAttribute,
            openApiPath,
            openApiOperation);

        var contentGeneratorClass = new GenerateContentForClass(
            new CodeDocumentationTagsGenerator(),
            classParameters);

        var classContent = contentGeneratorClass.Generate();

        // Write
        var pathA = Path.Combine(projectOptions.PathForTestGenerate!.FullName, ContentGeneratorConstants.Endpoints);
        var pathB = Path.Combine(pathA, apiGroupName);
        var fileName = $"{classParameters.TypeName}.cs";
        var file = new FileInfo(Path.Combine(pathB, fileName));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForTestGenerate,
            file,
            ContentWriterArea.Test,
            classContent);
    }

    private void GenerateTestEndpointTests(
        string apiGroupName,
        OpenApiOperation openApiOperation)
    {
        var fullNamespace = $"{projectOptions.ProjectName}.{ContentGeneratorConstants.Tests}.{ContentGeneratorConstants.Endpoints}.{apiGroupName}";

        // Generate
        var classParameters = ContentGeneratorServerTestEndpointTestsParametersFactory.Create(
            fullNamespace,
            openApiOperation);

        var contentGeneratorClass = new GenerateContentForClass(
            new CodeDocumentationTagsGenerator(),
            classParameters);

        var classContent = contentGeneratorClass.Generate();

        // Write
        var pathA = Path.Combine(projectOptions.PathForTestGenerate!.FullName, ContentGeneratorConstants.Endpoints);
        var pathB = Path.Combine(pathA, apiGroupName);
        var fileName = $"{classParameters.TypeName}.cs";
        var file = new FileInfo(Path.Combine(pathB, fileName));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForTestGenerate,
            file,
            ContentWriterArea.Test,
            classContent,
            overrideIfExist: false);
    }

    private void ScaffoldProgramFile()
    {
        var fullNamespace = $"{projectOptions.ProjectName}";

        var contentGenerator = new Framework.Mvc.ContentGenerators.Server.ContentGeneratorServerProgram(
            new ContentGeneratorBaseParameters(fullNamespace));

        var content = contentGenerator.Generate();

        var file = new FileInfo(Path.Combine(projectOptions.PathForSrcGenerate.FullName, "Program.cs"));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForSrcGenerate,
            file,
            ContentWriterArea.Src,
            content,
            overrideIfExist: false);
    }

    private void ScaffoldStartupFile()
    {
        var fullNamespace = $"{projectOptions.ProjectName}";

        // TODO: Deviate on startup file for minimal api
        var contentGenerator = new Framework.Mvc.ContentGenerators.Server.ContentGeneratorServerStartup(
            new ContentGeneratorBaseParameters(fullNamespace));

        var content = contentGenerator.Generate();

        var file = new FileInfo(Path.Combine(projectOptions.PathForSrcGenerate.FullName, "Startup.cs"));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForSrcGenerate,
            file,
            ContentWriterArea.Src,
            content,
            overrideIfExist: false);
    }

    private void ScaffoldWebConfig()
    {
        var contentGenerator = new Framework.Mvc.ContentGenerators.Server.ContentGeneratorServerWebConfig();

        var content = contentGenerator.Generate();

        var file = new FileInfo(Path.Combine(projectOptions.PathForSrcGenerate.FullName, "web.config"));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForSrcGenerate,
            file,
            ContentWriterArea.Src,
            content,
            overrideIfExist: false);
    }

    private void ScaffoldConfigureSwaggerDocOptions()
    {
        var fullNamespace = $"{projectOptions.ProjectName}";

        var contentGeneratorServerSwaggerDocOptionsParameters = ContentGeneratorServerSwaggerDocOptionsParameterFactory
            .Create(
                fullNamespace,
                projectOptions.Document.ToSwaggerDocOptionsParameters());

        var contentGenerator = new Framework.Mvc.ContentGenerators.Server.ContentGeneratorServerSwaggerDocOptions(
            new GeneratedCodeHeaderGenerator(new GeneratedCodeGeneratorParameters(projectOptions.ApiGeneratorVersion)),
            new GeneratedCodeAttributeGenerator(new GeneratedCodeGeneratorParameters(projectOptions.ApiGeneratorVersion)),
            contentGeneratorServerSwaggerDocOptionsParameters);

        var content = contentGenerator.Generate();

        var file = new FileInfo(Path.Combine(projectOptions.PathForSrcGenerate.FullName, "ConfigureSwaggerDocOptions.cs"));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForSrcGenerate,
            file,
            ContentWriterArea.Src,
            content);
    }

    private void GenerateTestWebApiStartupFactory()
    {
        var fullNamespace = $"{projectOptions.ProjectName}.Tests";

        var contentGeneratorServerWebApiStartupFactoryParameters = ContentGeneratorServerWebApiStartupFactoryParametersFactory.Create(
            fullNamespace);

        var contentGenerator = new Framework.Mvc.ContentGenerators.Server.ContentGeneratorServerWebApiStartupFactory(
            new GeneratedCodeHeaderGenerator(new GeneratedCodeGeneratorParameters(projectOptions.ApiGeneratorVersion)),
            new GeneratedCodeAttributeGenerator(new GeneratedCodeGeneratorParameters(projectOptions.ApiGeneratorVersion)),
            new CodeDocumentationTagsGenerator(),
            contentGeneratorServerWebApiStartupFactoryParameters);

        var content = contentGenerator.Generate();

        var file = new FileInfo(Path.Combine(projectOptions.PathForTestGenerate!.FullName, "WebApiStartupFactory.cs"));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForTestGenerate,
            file,
            ContentWriterArea.Test,
            content);
    }

    private void GenerateTestWebApiControllerBaseTest()
    {
        var fullNamespace = $"{projectOptions.ProjectName}.Tests";

        var contentGenerator = new Framework.Mvc.ContentGenerators.Server.ContentGeneratorServerWebApiControllerBaseTest(
            new GeneratedCodeHeaderGenerator(new GeneratedCodeGeneratorParameters(projectOptions.ApiGeneratorVersion)),
            new GeneratedCodeAttributeGenerator(new GeneratedCodeGeneratorParameters(projectOptions.ApiGeneratorVersion)),
            new ContentGeneratorBaseParameters(fullNamespace));

        var content = contentGenerator.Generate();

        var file = new FileInfo(Path.Combine(projectOptions.PathForTestGenerate!.FullName, "WebApiControllerBaseTest.cs"));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForTestGenerate,
            file,
            ContentWriterArea.Test,
            content);
    }

    private void ScaffoldAppSettingsIntegrationTest()
    {
        var contentGenerator = new Framework.Mvc.ContentGenerators.Server.ContentGeneratorServerAppSettingsIntegrationTest();

        var content = contentGenerator.Generate();

        var file = new FileInfo(Path.Combine(projectOptions.PathForTestGenerate!.FullName, "appsettings.integrationtest.json"));

        var contentWriter = new ContentWriter(logger);
        contentWriter.Write(
            projectOptions.PathForTestGenerate,
            file,
            ContentWriterArea.Test,
            content,
            overrideIfExist: false);
    }

    private void GenerateTestGlobalUsings(
        bool usingCodingRules,
        bool removeNamespaceGroupSeparatorInGlobalUsings)
    {
        var requiredUsings = new List<string>
        {
            "System.CodeDom.Compiler",
            "System.Text",
            "System.Text.Json",
            "System.Text.Json.Serialization",
            "System.Reflection",
            "Atc.XUnit",
            "Atc.Rest.Results",
            "Atc.Rest.Options",
            "Microsoft.AspNetCore.Hosting",
            "Microsoft.AspNetCore.Http",
            "Microsoft.AspNetCore.TestHost",
            "Microsoft.AspNetCore.Mvc.Testing",
            "Microsoft.Extensions.Configuration",
            "Microsoft.Extensions.DependencyInjection",
            $"{projectOptions.ProjectName}.Generated",
            $"{projectOptions.ProjectName}.Generated.Contracts",
        };

        if (!usingCodingRules)
        {
            requiredUsings.Add("AutoFixture");
            requiredUsings.Add("Xunit");
        }

        foreach (var apiGroupName in projectOptions.ApiGroupNames)
        {
            if (apiGroupName.Equals("Tasks", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            requiredUsings.Add($"{projectOptions.ProjectName}.Generated.Contracts.{apiGroupName}");
        }

        GlobalUsingsHelper.CreateOrUpdate(
            logger,
            ContentWriterArea.Test,
            projectOptions.PathForTestGenerate!,
            requiredUsings,
            removeNamespaceGroupSeparatorInGlobalUsings);
    }
}