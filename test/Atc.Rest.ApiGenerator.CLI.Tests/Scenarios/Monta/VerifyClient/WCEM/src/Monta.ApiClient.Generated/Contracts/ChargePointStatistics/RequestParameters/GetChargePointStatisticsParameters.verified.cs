﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.ChargePointStatistics;

/// <summary>
/// Parameters for operation request.
/// Description: Retrieve statistics related to a charge point.
/// Operation: GetChargePointStatistics.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetChargePointStatisticsParameters
{
    [Required]
    [Range(0, 2147483647)]
    public long ChargePointId { get; set; }

    [Required]
    [RegularExpression("\\d{4}-\\d{2}-\\d{2}")]
    public DateTimeOffset FromDate { get; set; }

    [Required]
    [RegularExpression("\\d{4}-\\d{2}-\\d{2}")]
    public DateTimeOffset ToDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ChargePointId)}: {ChargePointId}, {nameof(FromDate)}: ({FromDate}), {nameof(ToDate)}: ({ToDate})";
}