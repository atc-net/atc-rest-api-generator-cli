﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.ChargePoints.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Retrieve charge points / sites for map.
/// Operation: GetChargePointMap.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetChargePointMapEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    MapResult OkContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }
}