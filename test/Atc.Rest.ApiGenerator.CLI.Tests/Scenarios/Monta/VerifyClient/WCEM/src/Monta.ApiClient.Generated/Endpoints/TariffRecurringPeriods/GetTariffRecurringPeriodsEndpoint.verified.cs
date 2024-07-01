﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TariffRecurringPeriods;

/// <summary>
/// Client Endpoint.
/// Description: Retrieve recurring periods.
/// Operation: GetTariffRecurringPeriods.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetTariffRecurringPeriodsEndpoint : IGetTariffRecurringPeriodsEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetTariffRecurringPeriodsEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<GetTariffRecurringPeriodsEndpointResult> ExecuteAsync(
        GetTariffRecurringPeriodsParameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/tariff-recurring-periods");
        requestBuilder.WithQueryParameter("page", parameters.Page);
        requestBuilder.WithQueryParameter("perPage", parameters.PerPage);
        requestBuilder.WithQueryParameter("tariffId", parameters.TariffId);
        requestBuilder.WithQueryParameter("tariffPeriodGroupId", parameters.TariffPeriodGroupId);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<PageTariffRecurringPeriodDto>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        return await responseBuilder.BuildResponseAsync(x => new GetTariffRecurringPeriodsEndpointResult(x), cancellationToken);
    }
}