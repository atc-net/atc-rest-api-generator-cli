namespace Atc.Rest.ApiGenerator.CLI.Commands;

public class GenerateServerHostCommand : AsyncCommand<ServerHostCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<GenerateServerHostCommand> logger;
    private readonly IApiOperationExtractor apiOperationExtractor;
    private readonly INugetPackageReferenceProvider nugetPackageReferenceProvider;
    private readonly IOpenApiDocumentValidator openApiDocumentValidator;

    public GenerateServerHostCommand(
        ILoggerFactory loggerFactory,
        IApiOperationExtractor apiOperationExtractor,
        INugetPackageReferenceProvider nugetPackageReferenceProvider,
        IOpenApiDocumentValidator openApiDocumentValidator)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<GenerateServerHostCommand>();
        this.apiOperationExtractor = apiOperationExtractor;
        this.nugetPackageReferenceProvider = nugetPackageReferenceProvider;
        this.openApiDocumentValidator = openApiDocumentValidator;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ServerHostCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);
        return ExecuteInternalAsync(settings);
    }

    [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "OK.")]
    [SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "OK.")]
    private async Task<int> ExecuteInternalAsync(
        ServerHostCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        DirectoryInfo? outputTestPath = null;

        if (settings.OutputTestPath is not null &&
            settings.OutputTestPath.IsSet)
        {
            outputTestPath = new DirectoryInfo(settings.OutputTestPath.Value);
        }

        var apiOptions = await ApiOptionsHelper.CreateDefault(settings);
        var apiSpecificationContentReader = new ApiSpecificationContentReader();
        var apiDocumentContainer = apiSpecificationContentReader.CombineAndGetApiDocumentContainer(logger, settings.SpecificationPath);
        if (apiDocumentContainer.Exception is not null)
        {
            logger.LogError(apiDocumentContainer.Exception, $"{EmojisConstants.Error} Reading specification failed.");
            return ConsoleExitStatusCodes.Failure;
        }

        var shouldScaffoldCodingRules = CodingRulesHelper.ShouldScaffoldCodingRules(settings.OutputPath, settings.DisableCodingRules);
        var isUsingCodingRules = CodingRulesHelper.IsUsingCodingRules(settings.OutputPath, settings.DisableCodingRules);

        if (shouldScaffoldCodingRules &&
            !NetworkInformationHelper.HasHttpConnection())
        {
            System.Console.WriteLine("This tool requires internet connection!");
            return ConsoleExitStatusCodes.Failure;
        }

        try
        {
            if (!openApiDocumentValidator.IsValid(
                    apiOptions.Validation,
                    apiOptions.IncludeDeprecatedOperations,
                    apiDocumentContainer))
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (!GenerateHelper.GenerateServerHost(
                    loggerFactory,
                    apiOperationExtractor,
                    nugetPackageReferenceProvider,
                    settings.ProjectPrefixName,
                    new DirectoryInfo(settings.OutputPath),
                    outputTestPath,
                    apiDocumentContainer,
                    apiOptions,
                    isUsingCodingRules,
                    new DirectoryInfo(settings.ApiPath),
                    new DirectoryInfo(settings.DomainPath)))
            {
                return ConsoleExitStatusCodes.Failure;
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"{EmojisConstants.Error} Generation failed.");
            return ConsoleExitStatusCodes.Failure;
        }

        logger.LogInformation($"{EmojisConstants.Success} Done");
        return ConsoleExitStatusCodes.Success;
    }
}