﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.PriceGroups.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Sets a price group as default.
/// Operation: SetDefaultPriceGroup.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface ISetDefaultPriceGroupEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    bool IsForbidden { get; }

    bool IsNotFound { get; }

    PriceGroup OkContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }

    string? ForbiddenContent { get; }

    string? NotFoundContent { get; }
}