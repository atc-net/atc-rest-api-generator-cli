﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.InstallerJobs;

/// <summary>
/// Client Endpoint.
/// Description: Retrieve a list of installer jobs.
/// Operation: GetInstallerJobs.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetInstallerJobsEndpoint : IGetInstallerJobsEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetInstallerJobsEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<GetInstallerJobsEndpointResult> ExecuteAsync(
        GetInstallerJobsParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/installer-jobs");
        requestBuilder.WithQueryParameter("page", parameters.Page);
        requestBuilder.WithQueryParameter("perPage", parameters.PerPage);
        requestBuilder.WithQueryParameter("siteId", parameters.SiteId);
        requestBuilder.WithQueryParameter("teamId", parameters.TeamId);
        requestBuilder.WithQueryParameter("includeDeleted", parameters.IncludeDeleted);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<MontaPageInstallerJobDto>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        return await responseBuilder.BuildResponseAsync(x => new GetInstallerJobsEndpointResult(x), cancellationToken);
    }
}