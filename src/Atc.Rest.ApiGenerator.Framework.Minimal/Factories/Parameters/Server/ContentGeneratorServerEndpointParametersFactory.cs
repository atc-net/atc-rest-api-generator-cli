// ReSharper disable LoopCanBeConvertedToQuery
// ReSharper disable ReplaceWithSingleAssignment.True
namespace Atc.Rest.ApiGenerator.Framework.Minimal.Factories.Parameters.Server;

public static class ContentGeneratorServerEndpointParametersFactory
{
    public static ContentGeneratorServerEndpointParameters Create(
        IList<ApiOperation> operationSchemaMappings,
        string projectName,
        bool useProblemDetailsAsDefaultBody,
        string @namespace,
        string apiGroupName,
        string route,
        OpenApiDocument openApiDocument)
    {
        var methodParameters = new List<ContentGeneratorServerEndpointMethodParameters>();

        foreach (var (apiPath, apiPathData) in openApiDocument.GetPathsByBasePathSegmentName(apiGroupName))
        {
            var apiPathAuthenticationRequired = apiPathData.Extensions.ExtractAuthenticationRequired();
            var apiPathAuthorizationRoles = apiPathData.Extensions.ExtractAuthorizationRoles();
            var apiPathAuthenticationSchemes = apiPathData.Extensions.ExtractAuthenticationSchemes();

            foreach (var apiOperation in apiPathData.Operations)
            {
                var apiOperationAuthenticationRequired = apiOperation.Value.Extensions.ExtractAuthenticationRequired();
                var apiOperationAuthorizationRoles = apiOperation.Value.Extensions.ExtractAuthorizationRoles();
                var apiOperationAuthenticationSchemes = apiOperation.Value.Extensions.ExtractAuthenticationSchemes();

                var operationName = apiOperation.Value.GetOperationName();

                methodParameters.Add(new ContentGeneratorServerEndpointMethodParameters(
                    OperationTypeRepresentation: apiOperation.Key.ToString(),
                    Name: operationName,
                    DocumentationTags: apiOperation.Value.ExtractDocumentationTags(),
                    RouteSuffix: GetRouteSuffix(apiPath),
                    InterfaceName: $"I{operationName}{ContentGeneratorConstants.Handler}",
                    ParameterTypeName: GetParameterTypeName(operationName, apiPathData, apiOperation.Value),
                    MultipartBodyLengthLimit: GetMultipartBodyLengthLimit(apiOperation.Value),
                    HttpResults: GetHttpResults(
                        operationSchemaMappings,
                        apiOperation.Value,
                        apiGroupName,
                        projectName,
                        useProblemDetailsAsDefaultBody,
                        ShouldUseAuthorization(apiPathAuthenticationRequired, apiOperationAuthenticationRequired)),
                    apiPathAuthenticationRequired,
                    apiPathAuthorizationRoles,
                    apiPathAuthenticationSchemes,
                    apiOperationAuthenticationRequired,
                    apiOperationAuthorizationRoles,
                    apiOperationAuthenticationSchemes));
            }
        }

        var documentationTags = new CodeDocumentationTags("Endpoint definitions.");

        return new ContentGeneratorServerEndpointParameters(
            Namespace: @namespace,
            ApiGroupName: apiGroupName,
            route,
            documentationTags,
            EndpointName: $"{apiGroupName}{ContentGeneratorConstants.EndpointDefinition}",
            methodParameters);
    }

    private static string? GetRouteSuffix(
        string apiPath)
    {
        var apiPathParts = apiPath.Split('/', StringSplitOptions.RemoveEmptyEntries);
        if (apiPathParts.Length <= 1)
        {
            return null;
        }

        var sb = new StringBuilder();
        for (var i = 1; i < apiPathParts.Length; i++)
        {
            if (i != 1)
            {
                sb.Append('/');
            }

            sb.Append(apiPathParts[i]);
        }

        return sb.ToString();
    }

    private static string? GetParameterTypeName(
        string operationName,
        OpenApiPathItem apiPathData,
        OpenApiOperation apiOperation)
        => apiPathData.HasParameters() ||
           apiOperation.HasParametersOrRequestBody()
            ? $"{operationName}{ContentGeneratorConstants.Parameters}"
            : null;

    private static long? GetMultipartBodyLengthLimit(
        OpenApiOperation apiOperation)
    {
        if (apiOperation.HasRequestBodyWithAnythingAsFormatTypeBinary())
        {
            // TODO: Use project settings
            return long.MaxValue;
        }

        return null;
    }

    private static List<(HttpStatusCode HttpStatusCode, string ReturnType)> GetHttpResults(
        IList<ApiOperation> operationSchemaMappings,
        OpenApiOperation apiOperation,
        string apiGroupName,
        string projectName,
        bool useProblemDetailsAsDefaultBody,
        bool shouldUseAuthorization)
    {
        var responseTypes = apiOperation.Responses.GetResponseTypes(
            operationSchemaMappings,
            apiGroupName,
            projectName,
            useProblemDetailsAsDefaultBody,
            includeEmptyResponseTypes: true,
            apiOperation.HasParametersOrRequestBody(),
            shouldUseAuthorization,
            includeIfNotDefinedInternalServerError: false);

        return responseTypes
            .Where(x => x.Item1 != HttpStatusCode.Forbidden && x.Item1 != HttpStatusCode.Unauthorized)
            .Select(tuple => (HttpStatusCode: tuple.Item1, ReturnType: tuple.Item2))
            .ToList();
    }

    private static bool ShouldUseAuthorization(
        bool? apiPathAuthenticationRequired,
        bool? apiOperationAuthenticationRequired)
    {
        var shouldUseAuthorization = true;

        if (apiPathAuthenticationRequired.HasValue && !apiPathAuthenticationRequired.Value)
        {
            shouldUseAuthorization = false;
        }

        if (shouldUseAuthorization && apiOperationAuthenticationRequired.HasValue && !apiOperationAuthenticationRequired.Value)
        {
            shouldUseAuthorization = false;
        }

        return shouldUseAuthorization;
    }
}