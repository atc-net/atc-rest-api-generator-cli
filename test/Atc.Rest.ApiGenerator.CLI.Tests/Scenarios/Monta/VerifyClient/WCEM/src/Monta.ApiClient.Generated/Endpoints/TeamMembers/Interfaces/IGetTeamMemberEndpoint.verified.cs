﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TeamMembers.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Retrieve a team member.
/// Operation: GetTeamMember.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetTeamMemberEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<GetTeamMemberEndpointResult> ExecuteAsync(
        GetTeamMemberParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default);
}