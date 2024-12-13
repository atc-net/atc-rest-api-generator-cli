﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Endpoints.Insights.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Retrieve insights about charges broken down by team members of a team.
/// Operation: GetInsightsChargesDriverReport.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetInsightsChargesDriverReportEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    bool IsForbidden { get; }

    bool IsNotFound { get; }

    MontaPageChargesInsightDriverReportDto OkContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }

    string? ForbiddenContent { get; }

    string? NotFoundContent { get; }
}