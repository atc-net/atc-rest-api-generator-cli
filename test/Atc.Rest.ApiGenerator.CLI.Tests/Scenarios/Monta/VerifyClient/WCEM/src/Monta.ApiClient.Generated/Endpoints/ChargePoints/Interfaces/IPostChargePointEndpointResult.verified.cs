﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.ChargePoints.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Create a charge point.
/// Operation: PostChargePoint.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IPostChargePointEndpointResult : IEndpointResponse
{

    bool IsCreated { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    bool IsForbidden { get; }

    bool IsNotFound { get; }

    string? CreatedContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }

    string? ForbiddenContent { get; }

    string? NotFoundContent { get; }
}