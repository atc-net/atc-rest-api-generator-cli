﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Endpoints;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Get order by id.
/// Operation: GetOrderById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetOrderByIdEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<IGetOrderByIdEndpointResult> ExecuteAsync(
        GetOrderByIdParameters parameters,
        CancellationToken cancellationToken = default);
}