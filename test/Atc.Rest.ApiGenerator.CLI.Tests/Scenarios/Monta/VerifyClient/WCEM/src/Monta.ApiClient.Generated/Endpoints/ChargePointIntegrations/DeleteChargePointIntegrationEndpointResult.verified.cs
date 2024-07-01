﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.ChargePointIntegrations;

/// <summary>
/// Client Endpoint result.
/// Description: Delete a charge point integration.
/// Operation: DeleteChargePointIntegration.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class DeleteChargePointIntegrationEndpointResult : EndpointResponse, IDeleteChargePointIntegrationEndpointResult
{
    public DeleteChargePointIntegrationEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsNoContent
        => StatusCode == HttpStatusCode.NoContent;

    public bool IsBadRequest
        => StatusCode == HttpStatusCode.BadRequest;

    public bool IsUnauthorized
        => StatusCode == HttpStatusCode.Unauthorized;

    public bool IsForbidden
        => StatusCode == HttpStatusCode.Forbidden;

    public bool IsNotFound
        => StatusCode == HttpStatusCode.NotFound;

    public string? NoContentContent
        => IsNoContent && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsNoContent property first.");

    public string? BadRequestContent
        => IsBadRequest && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsBadRequest property first.");

    public string? UnauthorizedContent
        => IsUnauthorized && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsUnauthorized property first.");

    public string? ForbiddenContent
        => IsForbidden && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsForbidden property first.");

    public string? NotFoundContent
        => IsNotFound && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsNotFound property first.");
}