﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.InstallerJobs.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Retrieve a single installer job.
/// Operation: GetInstallerJob.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetInstallerJobEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<GetInstallerJobEndpointResult> ExecuteAsync(
        GetInstallerJobParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default);
}