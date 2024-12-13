﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.ChargeAuthTokens.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Retrieve list of charge auth tokens.
/// Operation: GetChargeAuthTokens.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetChargeAuthTokensEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    bool IsForbidden { get; }

    bool IsNotFound { get; }

    MontaPageChargeAuthTokenDto OkContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }

    string? ForbiddenContent { get; }

    string? NotFoundContent { get; }
}