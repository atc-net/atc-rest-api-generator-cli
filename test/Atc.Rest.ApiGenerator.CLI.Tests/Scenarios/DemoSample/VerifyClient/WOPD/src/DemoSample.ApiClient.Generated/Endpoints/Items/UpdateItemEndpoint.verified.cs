//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.Items;

/// <summary>
/// Client Endpoint.
/// Description: Updates an item.
/// Operation: UpdateItem.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateItemEndpoint : IUpdateItemEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public UpdateItemEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<UpdateItemEndpointResult> ExecuteAsync(
        UpdateItemParameters parameters,
        string httpClientName = "DemoSample-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/items/{id}");
        requestBuilder.WithPathParameter("id", parameters.Id);
        requestBuilder.WithBody(parameters.Request);

        using var requestMessage = requestBuilder.Build(HttpMethod.Put);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<Guid>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ValidationProblemDetails>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<string>(HttpStatusCode.Unauthorized);
        return await responseBuilder.BuildResponseAsync(x => new UpdateItemEndpointResult(x), cancellationToken);
    }
}
