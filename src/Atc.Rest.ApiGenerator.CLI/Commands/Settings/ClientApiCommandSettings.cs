namespace Atc.Rest.ApiGenerator.CLI.Commands.Settings;

public class ClientApiCommandSettings : BaseGenerateCommandSettings
{
    [CommandOption($"{ArgumentCommandConstants.ShortOutputPath}|{ArgumentCommandConstants.LongOutputPath} <OUTPUTPATH>")]
    [Description("Path to generated project (directory)")]
    public string OutputPath { get; init; } = string.Empty;

    [CommandOption(ArgumentCommandConstants.LongExcludeEndpointGeneration)]
    [Description("Exclude endpoint generation")]
    public bool ExcludeEndpointGeneration { get; init; }

    [CommandOption($"{ArgumentCommandConstants.LongClientHttpClientName} [HTTPCLIENTNAME]")]
    [Description("If provided this name will be added as the client name in endpoint files.")]
    public FlagValue<string>? HttpClientName { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        return string.IsNullOrEmpty(OutputPath)
            ? ValidationResult.Error($"{nameof(OutputPath)} is missing.")
            : ValidationResult.Success();
    }
}