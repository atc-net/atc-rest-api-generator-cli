﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.ChargePoints;

/// <summary>
/// Client Endpoint.
/// Description: Retrieve charge points / sites for map.
/// Operation: GetChargePointMap.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetChargePointMapEndpoint : IGetChargePointMapEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetChargePointMapEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<GetChargePointMapEndpointResult> ExecuteAsync(
        GetChargePointMapParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/charge-points/map");
        requestBuilder.WithQueryParameter("topLatitude", parameters.TopLatitude);
        requestBuilder.WithQueryParameter("rightLongitude", parameters.RightLongitude);
        requestBuilder.WithQueryParameter("bottomLatitude", parameters.BottomLatitude);
        requestBuilder.WithQueryParameter("leftLongitude", parameters.LeftLongitude);
        requestBuilder.WithQueryParameter("centerLatitude", parameters.CenterLatitude);
        requestBuilder.WithQueryParameter("centerLongitude", parameters.CenterLongitude);
        requestBuilder.WithQueryParameter("zoom", parameters.Zoom);
        requestBuilder.WithQueryParameter("includeBusy", parameters.IncludeBusy);
        requestBuilder.WithQueryParameter("includeAllOperators", parameters.IncludeAllOperators);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<MapResult>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        return await responseBuilder.BuildResponseAsync(x => new GetChargePointMapEndpointResult(x), cancellationToken);
    }
}