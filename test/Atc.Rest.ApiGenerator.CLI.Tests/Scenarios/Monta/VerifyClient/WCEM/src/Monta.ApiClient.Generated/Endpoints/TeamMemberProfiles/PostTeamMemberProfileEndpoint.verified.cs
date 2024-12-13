﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TeamMemberProfiles;

/// <summary>
/// Client Endpoint.
/// Description: Create a team member profile.
/// Operation: PostTeamMemberProfile.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PostTeamMemberProfileEndpoint : IPostTeamMemberProfileEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public PostTeamMemberProfileEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<PostTeamMemberProfileEndpointResult> ExecuteAsync(
        PostTeamMemberProfileParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/team-member-profiles");
        requestBuilder.WithBody(parameters.Request);

        using var requestMessage = requestBuilder.Build(HttpMethod.Post);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Created);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Forbidden);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.NotFound);
        return await responseBuilder.BuildResponseAsync(x => new PostTeamMemberProfileEndpointResult(x), cancellationToken);
    }
}