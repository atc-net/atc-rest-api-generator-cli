// ReSharper disable SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
namespace Atc.Rest.ApiGenerator.Framework.Mvc.ContentGenerators.Client;

public class ContentGeneratorClientEndpoint : IContentGenerator
{
    private readonly GeneratedCodeHeaderGenerator codeHeaderGenerator;
    private readonly GeneratedCodeAttributeGenerator codeAttributeGenerator;
    private readonly CodeDocumentationTagsGenerator codeDocumentationTagsGenerator;
    private readonly ContentGeneratorClientEndpointParameters parameters;

    public ContentGeneratorClientEndpoint(
        GeneratedCodeHeaderGenerator codeHeaderGenerator,
        GeneratedCodeAttributeGenerator codeAttributeGenerator,
        CodeDocumentationTagsGenerator codeDocumentationTagsGenerator,
        ContentGeneratorClientEndpointParameters parameters)
    {
        this.codeHeaderGenerator = codeHeaderGenerator;
        this.codeAttributeGenerator = codeAttributeGenerator;
        this.codeDocumentationTagsGenerator = codeDocumentationTagsGenerator;
        this.parameters = parameters;
    }

    public string Generate()
    {
        var sb = new StringBuilder();

        sb.Append(codeHeaderGenerator.Generate());
        sb.AppendLine($"namespace {parameters.Namespace};");
        sb.AppendLine();
        if (codeDocumentationTagsGenerator.ShouldGenerateTags(parameters.DocumentationTagsForClass))
        {
            sb.Append(codeDocumentationTagsGenerator.GenerateTags(0, parameters.DocumentationTagsForClass));
        }

        sb.AppendLine(codeAttributeGenerator.Generate());
        sb.AppendLine($"public class {parameters.EndpointName} : {parameters.InterfaceName}");
        sb.AppendLine("{");

        sb.AppendLine(4, "private readonly IHttpClientFactory factory;");
        sb.AppendLine(4, "private readonly IHttpMessageFactory httpMessageFactory;");
        sb.AppendLine();
        sb.AppendLine(4, $"public {parameters.EndpointName}(");
        sb.AppendLine(8, "IHttpClientFactory factory,");
        sb.AppendLine(8, "IHttpMessageFactory httpMessageFactory)");
        sb.AppendLine(4, "{");
        sb.AppendLine(8, "this.factory = factory;");
        sb.AppendLine(8, "this.httpMessageFactory = httpMessageFactory;");
        sb.AppendLine(4, "}");
        sb.AppendLine();

        sb.AppendLine(4, $"public async Task<{parameters.ResultName}> ExecuteAsync(");
        if (parameters.ParameterName is not null)
        {
            sb.AppendLine(8, $"{parameters.ParameterName} parameters,");
        }

        sb.AppendLine(8, "CancellationToken cancellationToken = default)");
        sb.AppendLine(4, "{");
        sb.AppendLine(8, $"var client = factory.CreateClient(\"{parameters.HttpClientName}\");");
        sb.AppendLine();
        sb.AppendLine(8, $"var requestBuilder = httpMessageFactory.FromTemplate(\"{parameters.UrlPath}\");");

        if (parameters.Parameters is not null && parameters.Parameters.Any())
        {
            foreach (var item in parameters.Parameters)
            {
                if (item.ParameterLocationType == ParameterLocationType.Body)
                {
                    sb.AppendLine(8, $"requestBuilder.WithBody(parameters.Request);");
                }
                else
                {
                    var methodName = item.ParameterLocationType switch
                    {
                        ParameterLocationType.Query => "WithQueryParameter",
                        ParameterLocationType.Header => "WithHeaderParameter",
                        ParameterLocationType.Route => "WithPathParameter",
                        _ => throw new SwitchCaseDefaultException(item.ParameterLocationType),
                    };

                    sb.AppendLine(8, $"requestBuilder.{methodName}(\"{item.Name}\", parameters.{item.ParameterName});");
                }
            }
        }

        sb.AppendLine();
        sb.AppendLine(8, $"using var requestMessage = requestBuilder.Build(HttpMethod.{parameters.HttpMethod});");
        sb.AppendLine(8, "using var response = await client.SendAsync(requestMessage, cancellationToken);");
        sb.AppendLine();
        sb.AppendLine(8, "var responseBuilder = httpMessageFactory.FromResponse(response);");

        /*
responseBuilder.AddSuccessResponse<DataTemplate>(HttpStatusCode.OK);
responseBuilder.AddErrorResponse<ValidationProblemDetails>(HttpStatusCode.BadRequest);
responseBuilder.AddErrorResponse<ProblemDetails>(HttpStatusCode.Unauthorized);
responseBuilder.AddErrorResponse<ProblemDetails>(HttpStatusCode.Forbidden);
responseBuilder.AddErrorResponse<ProblemDetails>(HttpStatusCode.NotFound);
responseBuilder.AddErrorResponse<ProblemDetails>(HttpStatusCode.Conflict);
responseBuilder.AddErrorResponse<ProblemDetails>(HttpStatusCode.InternalServerError);
 */
        sb.AppendLine();
        sb.AppendLine(8, $"return await responseBuilder.BuildResponseAsync(x => new {parameters.ResultName}(x), cancellationToken);");
        sb.AppendLine(4, "}");
        sb.AppendLine("}");

        return sb.ToString();
    }
}