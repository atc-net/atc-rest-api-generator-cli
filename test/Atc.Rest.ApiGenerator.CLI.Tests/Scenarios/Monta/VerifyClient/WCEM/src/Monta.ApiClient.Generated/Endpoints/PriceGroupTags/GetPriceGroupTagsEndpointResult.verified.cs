﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.PriceGroupTags;

/// <summary>
/// Client Endpoint result.
/// Description: Retrieve price group tags.
/// Operation: GetPriceGroupTags.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetPriceGroupTagsEndpointResult : EndpointResponse, IGetPriceGroupTagsEndpointResult
{
    public GetPriceGroupTagsEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsOk
        => StatusCode == HttpStatusCode.OK;

    public bool IsBadRequest
        => StatusCode == HttpStatusCode.BadRequest;

    public bool IsUnauthorized
        => StatusCode == HttpStatusCode.Unauthorized;

    public MontaPagePriceGroupTagDto OkContent
        => IsOk && ContentObject is MontaPagePriceGroupTagDto result
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