﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.CountryAreas;

/// <summary>
/// Client Endpoint result.
/// Description: Retrieve a country areas.
/// Operation: GetCountriesAreas.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetCountriesAreasEndpointResult : EndpointResponse, IGetCountriesAreasEndpointResult
{
    public GetCountriesAreasEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsOk
        => StatusCode == HttpStatusCode.OK;

    public bool IsBadRequest
        => StatusCode == HttpStatusCode.BadRequest;

    public bool IsUnauthorized
        => StatusCode == HttpStatusCode.Unauthorized;

    public bool IsNotFound
        => StatusCode == HttpStatusCode.NotFound;

    public MontaPageCountryAreaDto OkContent
        => IsOk && ContentObject is MontaPageCountryAreaDto result
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

    public string? NotFoundContent
        => IsNotFound && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsNotFound property first.");
}