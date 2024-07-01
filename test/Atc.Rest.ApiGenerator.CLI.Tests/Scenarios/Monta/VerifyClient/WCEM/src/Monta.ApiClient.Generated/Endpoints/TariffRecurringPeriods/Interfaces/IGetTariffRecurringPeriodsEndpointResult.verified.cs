﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TariffRecurringPeriods.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Retrieve recurring periods.
/// Operation: GetTariffRecurringPeriods.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetTariffRecurringPeriodsEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    PageTariffRecurringPeriodDto OkContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }
}