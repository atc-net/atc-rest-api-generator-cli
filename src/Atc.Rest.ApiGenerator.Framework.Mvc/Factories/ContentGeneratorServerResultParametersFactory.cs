// ReSharper disable ConvertIfStatementToReturnStatement
// ReSharper disable SwitchStatementMissingSomeEnumCasesNoDefault
// ReSharper disable InvertIf
namespace Atc.Rest.ApiGenerator.Framework.Mvc.Factories;

public static class ContentGeneratorServerResultParametersFactory
{
    public static ContentGeneratorServerResultParameters Create(
        string @namespace,
        OpenApiOperation openApiOperation)
    {
        ArgumentNullException.ThrowIfNull(openApiOperation);

        var operationName = openApiOperation.GetOperationName();
        var httpStatusCodes = openApiOperation.Responses.GetHttpStatusCodes();

        // TODO: ???
        string? modelNameForImplicitOperator = null;

        // Methods
        var methodParameters = new List<ContentGeneratorServerResultMethodParameters>();
        var responseModels = openApiOperation.ExtractApiOperationResponseModels(@namespace).ToList();

        foreach (var responseModel in responseModels.OrderBy(x => x.StatusCode))
        {
            var httpStatusCode = responseModel.StatusCode;
            var documentationTags = new CodeDocumentationTags($"{(int)httpStatusCode} - {httpStatusCode.ToNormalizedString()} response.");

            methodParameters.Add(
                new ContentGeneratorServerResultMethodParameters(
                    documentationTags,
                    responseModel));
        }

        ContentGeneratorServerResultImplicitOperatorParameters? implicitOperatorParameters = null;

        if (ShouldAppendImplicitOperatorContent(httpStatusCodes, modelNameForImplicitOperator, openApiOperation.Responses.IsSchemaUsingBinaryFormatForOkResponse()))
        {
            var responseModel = responseModels.FirstOrDefault(x => x.StatusCode == HttpStatusCode.OK) ??
                                responseModels.FirstOrDefault(x => x.StatusCode == HttpStatusCode.Created);

            var collectionDataType = responseModel?.CollectionDataType;
            var dataType = responseModel?.DataType;
            var useAsyncEnumerable = responseModel?.UseAsyncEnumerable ?? false;

            // Implicit Operator
            implicitOperatorParameters = new ContentGeneratorServerResultImplicitOperatorParameters(
                CollectionDataType: collectionDataType,
                DataType: dataType,
                UseAsyncEnumerable: useAsyncEnumerable);
        }

        return new ContentGeneratorServerResultParameters(
            @namespace,
            operationName,
            openApiOperation.ExtractDocumentationTagsForResult(),
            DeclarationModifiers.PublicClass,
            $"{operationName}{ContentGeneratorConstants.Result}",
            methodParameters,
            implicitOperatorParameters);
    }

    private static bool ShouldAppendImplicitOperatorContent(
        ICollection<HttpStatusCode> httpStatusCodes,
        string? modelName,
        bool isSchemaUsingBinaryFormatForOkResponse)
    {
        if (!httpStatusCodes.Contains(HttpStatusCode.OK) &&
            !httpStatusCodes.Contains(HttpStatusCode.Created))
        {
            return false;
        }

        if (httpStatusCodes.Contains(HttpStatusCode.OK) &&
            httpStatusCodes.Contains(HttpStatusCode.Created))
        {
            return false;
        }

        var httpStatusCode = HttpStatusCode.Continue; // Dummy
        if (httpStatusCodes.Contains(HttpStatusCode.OK))
        {
            httpStatusCode = HttpStatusCode.OK;
        }
        else if (httpStatusCodes.Contains(HttpStatusCode.Created))
        {
            httpStatusCode = HttpStatusCode.Created;
        }

        if (string.IsNullOrEmpty(modelName) &&
            httpStatusCode == HttpStatusCode.Created)
        {
            return false;
        }

        if (isSchemaUsingBinaryFormatForOkResponse)
        {
            return false;
        }

        return true;
    }
}