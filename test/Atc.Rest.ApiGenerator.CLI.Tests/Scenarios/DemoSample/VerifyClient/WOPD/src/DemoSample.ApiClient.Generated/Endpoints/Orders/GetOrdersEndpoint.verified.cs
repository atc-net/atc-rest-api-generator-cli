﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.Orders;

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

    public async Task<GetOrdersEndpointResult> ExecuteAsync(
        GetOrdersParameters parameters,
        string httpClientName = "DemoSample-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/orders");
        requestBuilder.WithQueryParameter("pageSize", parameters.PageSize);
        requestBuilder.WithQueryParameter("pageIndex", parameters.PageIndex);
        requestBuilder.WithQueryParameter("queryString", parameters.QueryString);
        if (parameters.QueryStringArray.Any())
        {
            requestBuilder.WithQueryParameter("queryStringArray", parameters.QueryStringArray);
        }

        requestBuilder.WithQueryParameter("continuationToken", parameters.ContinuationToken);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<Pagination<Order>>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ValidationProblemDetails>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<string>(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse<string?>(HttpStatusCode.NotFound);
        return await responseBuilder.BuildResponseAsync(x => new GetOrdersEndpointResult(x), cancellationToken);
    }
}