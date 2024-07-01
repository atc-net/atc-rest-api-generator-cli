﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.TariffPeriodGroups.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Create a new Tariff Period Group.
/// Operation: CreateTariffPeriodGroup.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface ICreateTariffPeriodGroupEndpointResult : IEndpointResponse
{

    bool IsCreated { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    string? CreatedContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }
}