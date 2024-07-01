﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.PriceGroupTags.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Retrieve price group tags.
/// Operation: GetPriceGroupTags.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetPriceGroupTagsEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    MontaPagePriceGroupTagDto OkContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }
}