﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.ApiClient.Generated.Accounts.MyEndpoints.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Update name of account.
/// Operation: UpdateAccountName.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IUpdateAccountNameEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<UpdateAccountNameEndpointResult> ExecuteAsync(
        UpdateAccountNameParameters parameters,
        string httpClientName = "Structure1-ApiClient",
        CancellationToken cancellationToken = default);
}