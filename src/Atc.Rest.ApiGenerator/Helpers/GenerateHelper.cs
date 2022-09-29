// ReSharper disable ReturnTypeCanBeEnumerable.Global

namespace Atc.Rest.ApiGenerator.Helpers;

public static class GenerateHelper
{
    private static readonly Version AtcApiGeneratorVersion = new(1, 1, 405, 0); // TODO: Fix version

    public static Version GetAtcVersion()
    {
        var version = AtcApiNugetClientHelper.GetLatestVersionForPackageId(
            NullLogger.Instance,
            "Atc",
            CancellationToken.None) ?? new Version(2, 0, 81, 0);
        return version;
    }

    public static string GetAtcVersionAsString3()
    {
        var atcVersion = GetAtcVersion();
        return $"{atcVersion.Major}.{atcVersion.Minor}.{atcVersion.Build}";
    }

    public static string GetAtcVersionAsString4()
    {
        var atcVersion = GetAtcVersion();
        return $"{atcVersion.Major}.{atcVersion.Minor}.{atcVersion.Build}.{atcVersion.Revision}";
    }

    public static Version GetAtcApiGeneratorVersion()
    {
        var version = AtcApiNugetClientHelper.GetLatestVersionForPackageId(
            NullLogger.Instance,
            "Atc.Rest.ApiGenerator",
            CancellationToken.None) ?? new Version(2, 0, 101, 0);

        var assemblyVersion = CliHelper.GetCurrentVersion();

        return assemblyVersion.GreaterThan(version)
            ? assemblyVersion
            : AtcApiGeneratorVersion;
    }

    public static string GetAtcApiGeneratorVersionAsString3()
    {
        var atcApiGeneratorVersion = GetAtcApiGeneratorVersion();
        return $"{atcApiGeneratorVersion.Major}.{atcApiGeneratorVersion.Minor}.{atcApiGeneratorVersion.Build}";
    }

    public static string GetAtcApiGeneratorVersionAsString4()
    {
        var atcApiGeneratorVersion = GetAtcApiGeneratorVersion();
        return $"{atcApiGeneratorVersion.Major}.{atcApiGeneratorVersion.Minor}.{atcApiGeneratorVersion.Build}.{atcApiGeneratorVersion.Revision}";
    }

    public static bool GenerateServerApi(
        ILogger logger,
        string projectPrefixName,
        DirectoryInfo outputPath,
        DirectoryInfo? outputTestPath,
        Tuple<OpenApiDocument, OpenApiDiagnostic, FileInfo> apiDocument,
        ApiOptions apiOptions,
        bool useCodingRules)
    {
        ArgumentNullException.ThrowIfNull(logger);
        ArgumentNullException.ThrowIfNull(projectPrefixName);
        ArgumentNullException.ThrowIfNull(outputPath);
        ArgumentNullException.ThrowIfNull(apiDocument);
        ArgumentNullException.ThrowIfNull(apiOptions);

        var projectOptions = new ApiProjectOptions(
            outputPath,
            outputTestPath,
            apiDocument.Item1,
            apiDocument.Item3,
            projectPrefixName,
            "Api.Generated",
            apiOptions,
            useCodingRules);
        var serverApiGenerator = new ServerApiGenerator(logger, projectOptions);
        return serverApiGenerator.Generate();
    }

    public static bool GenerateServerDomain(
        ILogger logger,
        string projectPrefixName,
        DirectoryInfo outputSourcePath,
        DirectoryInfo? outputTestPath,
        Tuple<OpenApiDocument, OpenApiDiagnostic, FileInfo> apiDocument,
        ApiOptions apiOptions,
        bool useCodingRules,
        DirectoryInfo apiPath)
    {
        ArgumentNullException.ThrowIfNull(logger);
        ArgumentNullException.ThrowIfNull(projectPrefixName);
        ArgumentNullException.ThrowIfNull(outputSourcePath);
        ArgumentNullException.ThrowIfNull(apiDocument);
        ArgumentNullException.ThrowIfNull(apiOptions);
        ArgumentNullException.ThrowIfNull(apiPath);

        var domainProjectOptions = new DomainProjectOptions(
            outputSourcePath,
            outputTestPath,
            apiDocument.Item1,
            apiDocument.Item3,
            projectPrefixName,
            apiOptions,
            useCodingRules,
            apiPath);
        var serverDomainGenerator = new ServerDomainGenerator(logger, domainProjectOptions);
        return serverDomainGenerator.Generate();
    }

    public static bool GenerateServerHost(
        ILogger logger,
        string projectPrefixName,
        DirectoryInfo outputSourcePath,
        DirectoryInfo? outputTestPath,
        Tuple<OpenApiDocument, OpenApiDiagnostic, FileInfo> apiDocument,
        ApiOptions apiOptions,
        bool usingCodingRules,
        DirectoryInfo apiPath,
        DirectoryInfo domainPath)
    {
        ArgumentNullException.ThrowIfNull(logger);
        ArgumentNullException.ThrowIfNull(projectPrefixName);
        ArgumentNullException.ThrowIfNull(outputSourcePath);
        ArgumentNullException.ThrowIfNull(apiDocument);
        ArgumentNullException.ThrowIfNull(apiOptions);
        ArgumentNullException.ThrowIfNull(apiPath);
        ArgumentNullException.ThrowIfNull(domainPath);

        var hostProjectOptions = new HostProjectOptions(
            outputSourcePath,
            outputTestPath,
            apiDocument.Item1,
            apiDocument.Item3,
            projectPrefixName,
            apiOptions,
            usingCodingRules,
            apiPath,
            domainPath);
        var serverHostGenerator = new ServerHostGenerator(logger, hostProjectOptions);
        return serverHostGenerator.Generate();
    }

    public static bool GenerateServerSln(
        ILogger logger,
        string projectPrefixName,
        string outputSlnPath,
        DirectoryInfo outputSourcePath,
        DirectoryInfo? outputTestPath)
    {
        ArgumentNullException.ThrowIfNull(logger);
        ArgumentNullException.ThrowIfNull(projectPrefixName);
        ArgumentNullException.ThrowIfNull(outputSlnPath);
        ArgumentNullException.ThrowIfNull(outputSourcePath);

        var projectName = projectPrefixName
            .Replace(" ", ".", StringComparison.Ordinal)
            .Replace("-", ".", StringComparison.Ordinal)
            .Trim();

        var apiPath = new DirectoryInfo(Path.Combine(outputSourcePath.FullName, $"{projectName}.Api.Generated"));
        var domainPath = new DirectoryInfo(Path.Combine(outputSourcePath.FullName, $"{projectName}.Domain"));
        var hostPath = new DirectoryInfo(Path.Combine(outputSourcePath.FullName, $"{projectName}.Api"));

        var slnFile = outputSlnPath.EndsWith(".sln", StringComparison.OrdinalIgnoreCase)
            ? new FileInfo(outputSlnPath)
            : new FileInfo(Path.Combine(outputSlnPath, $"{projectName}.sln"));

        if (outputTestPath is not null)
        {
            var domainTestPath = new DirectoryInfo(Path.Combine(outputTestPath.FullName, $"{projectName}.Domain"));
            var hostTestPath = new DirectoryInfo(Path.Combine(outputTestPath.FullName, $"{projectName}.Api"));

            SolutionAndProjectHelper.ScaffoldSlnFile(
                logger,
                slnFile,
                projectName,
                apiPath,
                domainPath,
                hostPath,
                domainTestPath,
                hostTestPath);

            return true;
        }

        SolutionAndProjectHelper.ScaffoldSlnFile(
            logger,
            slnFile,
            projectName,
            apiPath,
            domainPath,
            hostPath);

        return true;
    }

    public static bool GenerateServerCSharpClient(
        ILogger logger,
        string projectPrefixName,
        string? clientFolderName,
        DirectoryInfo outputPath,
        Tuple<OpenApiDocument, OpenApiDiagnostic, FileInfo> apiDocument,
        bool excludeEndpointGeneration,
        ApiOptions apiOptions,
        bool useCodingRules)
    {
        ArgumentNullException.ThrowIfNull(logger);
        ArgumentNullException.ThrowIfNull(projectPrefixName);
        ArgumentNullException.ThrowIfNull(outputPath);
        ArgumentNullException.ThrowIfNull(apiDocument);
        ArgumentNullException.ThrowIfNull(apiOptions);

        var clientCSharpApiProjectOptions = new ClientCSharpApiProjectOptions(
            outputPath,
            clientFolderName,
            apiDocument.Item1,
            apiDocument.Item3,
            projectPrefixName,
            "ApiClient.Generated",
            excludeEndpointGeneration,
            apiOptions,
            useCodingRules);
        var clientCSharpApiGenerator = new ClientCSharpApiGenerator(logger, clientCSharpApiProjectOptions);
        return clientCSharpApiGenerator.Generate();
    }
}