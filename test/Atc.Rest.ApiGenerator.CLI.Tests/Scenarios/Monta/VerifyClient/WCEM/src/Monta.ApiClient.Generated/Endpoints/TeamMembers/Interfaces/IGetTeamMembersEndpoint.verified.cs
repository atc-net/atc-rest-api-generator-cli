﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TeamMembers.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Retrieve a list of team members.
/// Operation: GetTeamMembers.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetTeamMembersEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<GetTeamMembersEndpointResult> ExecuteAsync(
        GetTeamMembersParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default);
}