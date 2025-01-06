﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Insights;

/// <summary>
/// ChargesInsightDriverMemberCostsReportDtoConsumptionCountryBreakdown.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class ChargesInsightDriverMemberCostsReportDtoConsumptionCountryBreakdown
{
    /// <summary>
    /// Two letter Country Code.
    /// </summary>
    [Required]
    public string CountryCode { get; set; }

    /// <summary>
    /// Number of charging sessions.
    /// </summary>
    [Required]
    public long TotalSessions { get; set; }

    /// <summary>
    /// Sum of all Kwh consumed.
    /// </summary>
    [Required]
    public double TotalKwh { get; set; }

    /// <summary>
    /// Sum of all charge net prices.
    /// </summary>
    [Required]
    public double TotalNetPrice { get; set; }

    /// <summary>
    /// Sum of all charge vat amounts.
    /// </summary>
    [Required]
    public double TotalVat { get; set; }

    /// <summary>
    /// Sum of all charge gross prices.
    /// </summary>
    [Required]
    public double TotalGrossPrice { get; set; }

    /// <summary>
    /// Sum of all charge costs in the Member Cost Group currency, or Null if none.
    /// </summary>
    public double? MemberCostGroupPrice { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(CountryCode)}: {CountryCode}, {nameof(TotalSessions)}: {TotalSessions}, {nameof(TotalKwh)}: {TotalKwh}, {nameof(TotalNetPrice)}: {TotalNetPrice}, {nameof(TotalVat)}: {TotalVat}, {nameof(TotalGrossPrice)}: {TotalGrossPrice}, {nameof(MemberCostGroupPrice)}: {MemberCostGroupPrice}";
}