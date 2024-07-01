﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.CountryAreas.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Retrieve a country areas.
/// Operation: GetCountriesAreas.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetCountriesAreasEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    bool IsNotFound { get; }

    MontaPageCountryAreaDto OkContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }

    string? NotFoundContent { get; }
}