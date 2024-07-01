namespace Atc.Rest.ApiGenerator.Options;

public class ApiOptionsGenerator
{
    public AspNetOutputType AspNetOutputType { get; set; } = AspNetOutputType.Mvc;

    public SwaggerThemeMode SwaggerThemeMode { get; set; } = SwaggerThemeMode.None;

    public bool UseRestExtended { get; set; } = true;

    public bool IncludeDeprecated { get; set; }

    public string ProjectName { get; set; } = string.Empty;

    public string ProjectSuffixName { get; set; } = string.Empty;

    public bool RemoveNamespaceGroupSeparatorInGlobalUsings { get; set; }

    public ApiOptionsGeneratorRequest Request { get; set; } = new();

    public ApiOptionsGeneratorResponse Response { get; set; } = new();

    public ApiOptionsGeneratorClient? Client { get; set; }
}