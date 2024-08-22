﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.RouteWithDash;

/// <summary>
/// Client Endpoint.
/// Description: Your GET endpoint.
/// Operation: GetRouteWithDash.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetRouteWithDashEndpoint : IGetRouteWithDashEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetRouteWithDashEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<GetRouteWithDashEndpointResult> ExecuteAsync(
        string httpClientName = "DemoSample-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/route-with-dash");

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<string?>(HttpStatusCode.OK);
        return await responseBuilder.BuildResponseAsync(x => new GetRouteWithDashEndpointResult(x), cancellationToken);
    }
}