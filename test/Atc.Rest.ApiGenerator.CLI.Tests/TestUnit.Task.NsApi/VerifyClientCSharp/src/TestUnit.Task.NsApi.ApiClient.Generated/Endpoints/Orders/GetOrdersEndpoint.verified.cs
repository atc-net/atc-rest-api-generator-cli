﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestUnit.Task.NsApi.ApiClient.Generated.Endpoints.Orders;

/// <summary>
/// Client Endpoint.
/// Description: Get orders.
/// Operation: GetOrders.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetOrdersEndpoint : IGetOrdersEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetOrdersEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<IGetOrdersEndpointResult> ExecuteAsync(
        GetOrdersParameters parameters,
        string httpClientName = "TestUnit.Task.NsApi-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/orders");
        requestBuilder.WithQueryParameter("pageSize", parameters.PageSize);
        requestBuilder.WithQueryParameter("pageIndex", parameters.PageIndex);
        requestBuilder.WithQueryParameter("continuationToken", parameters.ContinuationToken);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<PaginationResult<Order>>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ValidationProblemDetails>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse(HttpStatusCode.Forbidden);
        responseBuilder.AddErrorResponse(HttpStatusCode.NotFound);
        responseBuilder.AddErrorResponse<string>(HttpStatusCode.InternalServerError);

        return await responseBuilder.BuildResponseAsync(x => new GetOrdersEndpointResult(x), cancellationToken);
    }
}