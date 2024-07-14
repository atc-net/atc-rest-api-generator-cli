﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TariffPeriodGroups;

/// <summary>
/// Client Endpoint result.
/// Description: Delete an existing Tariff Period Group, and all contained recurring periods and prices.
/// Operation: DeleteTariffPeriodGroup.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class DeleteTariffPeriodGroupEndpointResult : EndpointResponse, IDeleteTariffPeriodGroupEndpointResult
{
    public DeleteTariffPeriodGroupEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsNoContent
        => StatusCode == HttpStatusCode.NoContent;

    public bool IsBadRequest
        => StatusCode == HttpStatusCode.BadRequest;

    public bool IsUnauthorized
        => StatusCode == HttpStatusCode.Unauthorized;

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
}