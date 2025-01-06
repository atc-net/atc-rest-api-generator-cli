﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.WalletTransactions;

/// <summary>
/// Client Endpoint.
/// Description: Retrieves wallet transactions for an invoice.
/// Operation: GetWalletTransactions1.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetWalletTransactions1Endpoint : IGetWalletTransactions1Endpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetWalletTransactions1Endpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<GetWalletTransactions1EndpointResult> ExecuteAsync(
        GetWalletTransactions1Parameters parameters,
        string httpClientName = "Monta-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/wallet-transactions/invoices/{invoiceId}");
        requestBuilder.WithPathParameter("invoiceId", parameters.InvoiceId);
        requestBuilder.WithQueryParameter("pageable", parameters.Pageable);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<MontaPageWalletTransactionDto>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.Forbidden);
        responseBuilder.AddErrorResponse<ErrorResponse>(HttpStatusCode.NotFound);
        return await responseBuilder.BuildResponseAsync(x => new GetWalletTransactions1EndpointResult(x), cancellationToken);
    }
}