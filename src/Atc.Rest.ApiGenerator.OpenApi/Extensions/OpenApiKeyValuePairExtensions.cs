// ReSharper disable InvertIf
namespace Atc.Rest.ApiGenerator.OpenApi.Extensions;

public static class OpenApiKeyValuePairExtensions
{
    public static string GetFormattedKey(
        this KeyValuePair<string, OpenApiSchema> value)
        => value.Key.PascalCase(ApiOperationExtractor.ModelNameSeparators, removeSeparators: true);

    public static string GetFormattedKey(
        this KeyValuePair<string, OpenApiResponse> value)
        => value.Key.PascalCase(ApiOperationExtractor.ModelNameSeparators, removeSeparators: true);
}