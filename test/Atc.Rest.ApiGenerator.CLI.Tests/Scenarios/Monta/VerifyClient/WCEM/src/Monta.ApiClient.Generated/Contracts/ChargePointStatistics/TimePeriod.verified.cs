﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.ChargePointStatistics;

/// <summary>
/// TimePeriod.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class TimePeriod
{
    /// <summary>
    /// Date for the statistics.
    /// </summary>
    [Required]
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Performance metrics for the day.
    /// </summary>
    [Required]
    public List<Performance> DailyPerformance { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Date)}: ({Date}), {nameof(DailyPerformance)}.Count: {DailyPerformance?.Count ?? 0}";
}