﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TariffRecurringPeriods.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Create new recurring period.
/// Operation: CreateTariffRecurringPeriods.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface ICreateTariffRecurringPeriodsEndpointResult : IEndpointResponse
{

    bool IsCreated { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    string? CreatedContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }
}