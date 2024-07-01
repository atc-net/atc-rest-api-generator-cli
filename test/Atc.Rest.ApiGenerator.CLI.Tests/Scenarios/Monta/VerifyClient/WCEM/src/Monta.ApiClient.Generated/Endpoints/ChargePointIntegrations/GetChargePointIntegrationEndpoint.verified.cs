﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.ChargePointIntegrations;

/// <summary>
/// Client Endpoint.
/// Description: Retrieve a single charge point integration.
/// Operation: GetChargePointIntegration.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetChargePointIntegrationEndpoint : IGetChargePointIntegrationEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetChargePointIntegrationEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<GetChargePointIntegrationEndpointResult> ExecuteAsync(
        GetChargePointIntegrationParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/charge-point-integrations/{chargePointIntegrationId}");
        requestBuilder.WithPathParameter("chargePointIntegrationId", parameters.ChargePointIntegrationId);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<ChargePointIntegration>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Forbidden);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.NotFound);
        return await responseBuilder.BuildResponseAsync(x => new GetChargePointIntegrationEndpointResult(x), cancellationToken);
    }
}