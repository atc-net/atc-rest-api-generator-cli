﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.ChargePoints;

/// <summary>
/// Client Endpoint.
/// Description: Unlock an existing charge point.
/// Operation: UnlockChargePoint.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UnlockChargePointEndpoint : IUnlockChargePointEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public UnlockChargePointEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<UnlockChargePointEndpointResult> ExecuteAsync(
        UnlockChargePointParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/charge-points/{chargePointId}/unlock");
        requestBuilder.WithPathParameter("chargePointId", parameters.ChargePointId);

        using var requestMessage = requestBuilder.Build(HttpMethod.Post);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.NoContent);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Forbidden);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.NotFound);
        return await responseBuilder.BuildResponseAsync(x => new UnlockChargePointEndpointResult(x), cancellationToken);
    }
}