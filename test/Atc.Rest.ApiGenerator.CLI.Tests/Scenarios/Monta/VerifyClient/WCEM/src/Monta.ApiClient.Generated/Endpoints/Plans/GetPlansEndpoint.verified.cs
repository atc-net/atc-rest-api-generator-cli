﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.Plans;

/// <summary>
/// Client Endpoint.
/// Description: Retrieve plans.
/// Operation: GetPlans.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetPlansEndpoint : IGetPlansEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetPlansEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<GetPlansEndpointResult> ExecuteAsync(
        GetPlansParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/plans");
        requestBuilder.WithQueryParameter("page", parameters.Page);
        requestBuilder.WithQueryParameter("perPage", parameters.PerPage);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<MontaPagePlanDto>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        return await responseBuilder.BuildResponseAsync(x => new GetPlansEndpointResult(x), cancellationToken);
    }
}