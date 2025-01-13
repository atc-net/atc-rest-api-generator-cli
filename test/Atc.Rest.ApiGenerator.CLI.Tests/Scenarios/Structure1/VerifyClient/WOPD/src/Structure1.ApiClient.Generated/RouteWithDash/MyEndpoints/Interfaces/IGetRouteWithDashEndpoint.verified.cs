﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.ApiClient.Generated.RouteWithDash.MyEndpoints.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Your GET endpoint.
/// Operation: GetRouteWithDash.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetRouteWithDashEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<GetRouteWithDashEndpointResult> ExecuteAsync(
        string httpClientName = "Structure1-ApiClient",
        CancellationToken cancellationToken = default);
}