﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Endpoints;

/// <summary>
/// Client Endpoint.
/// Description: Create a new item.
/// Operation: CreateItem.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreateItemEndpoint : ICreateItemEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public CreateItemEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<ICreateItemEndpointResult> ExecuteAsync(
        CreateItemParameters parameters,
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient("DemoSampleApi-ApiClient");

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/items");
        requestBuilder.WithBody(parameters.Request);

        using var requestMessage = requestBuilder.Build(HttpMethod.Post);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<string>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ValidationProblemDetails>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse(HttpStatusCode.Forbidden);
        responseBuilder.AddErrorResponse<string>(HttpStatusCode.InternalServerError);

        return await responseBuilder.BuildResponseAsync(x => new CreateItemEndpointResult(x), cancellationToken);
    }
}