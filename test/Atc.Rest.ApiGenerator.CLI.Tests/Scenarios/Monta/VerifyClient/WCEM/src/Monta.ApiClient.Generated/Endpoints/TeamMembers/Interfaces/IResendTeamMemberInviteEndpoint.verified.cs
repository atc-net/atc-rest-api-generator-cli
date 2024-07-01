﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TeamMembers.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Resend an invite to a team member and reset expiry date.
/// Operation: ResendTeamMemberInvite.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IResendTeamMemberInviteEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<ResendTeamMemberInviteEndpointResult> ExecuteAsync(
        ResendTeamMemberInviteParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default);
}