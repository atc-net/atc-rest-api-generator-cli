﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.Webhooks;

/// <summary>
/// Client Endpoint.
/// Description: Delete webhook config.
/// Operation: DeleteWebhookConfig.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class DeleteWebhookConfigEndpoint : IDeleteWebhookConfigEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public DeleteWebhookConfigEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<DeleteWebhookConfigEndpointResult> ExecuteAsync(
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/webhooks/config");

        using var requestMessage = requestBuilder.Build(HttpMethod.Delete);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.NoContent);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        return await responseBuilder.BuildResponseAsync(x => new DeleteWebhookConfigEndpointResult(x), cancellationToken);
    }
}