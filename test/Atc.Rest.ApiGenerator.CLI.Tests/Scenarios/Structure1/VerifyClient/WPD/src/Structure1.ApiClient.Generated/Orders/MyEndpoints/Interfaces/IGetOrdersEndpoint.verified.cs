﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.ApiClient.Generated.Orders.MyEndpoints.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Get orders.
/// Operation: GetOrders.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetOrdersEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<GetOrdersEndpointResult> ExecuteAsync(
        GetOrdersParameters parameters,
        string httpClientName = "Structure1-ApiClient",
        CancellationToken cancellationToken = default);
}