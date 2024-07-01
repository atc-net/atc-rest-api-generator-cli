﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.Prices;

/// <summary>
/// Client Endpoint result.
/// Description: Retrieve prices forecast.
/// Operation: GetPricesForecast.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetPricesForecastEndpointResult : EndpointResponse, IGetPricesForecastEndpointResult
{
    public GetPricesForecastEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsOk
        => StatusCode == HttpStatusCode.OK;

    public bool IsBadRequest
        => StatusCode == HttpStatusCode.BadRequest;

    public bool IsUnauthorized
        => StatusCode == HttpStatusCode.Unauthorized;

    public PricesForecast OkContent
        => IsOk && ContentObject is PricesForecast result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsOk property first.");

    public string? BadRequestContent
        => IsBadRequest && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsBadRequest property first.");

    public string? UnauthorizedContent
        => IsUnauthorized && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsUnauthorized property first.");
}