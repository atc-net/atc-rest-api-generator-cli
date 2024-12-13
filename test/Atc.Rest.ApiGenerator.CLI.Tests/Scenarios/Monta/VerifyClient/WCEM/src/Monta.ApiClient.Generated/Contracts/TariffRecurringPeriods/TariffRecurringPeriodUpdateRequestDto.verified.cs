﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.TariffRecurringPeriods;

/// <summary>
/// TariffRecurringPeriodUpdateRequestDto.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class TariffRecurringPeriodUpdateRequestDto
{
    /// <summary>
    /// Capitalized name of the day of the week.
    /// </summary>
    public DayOfWeek? DayOfWeek { get; set; }

    /// <summary>
    /// Capitalized name of the end day of the week.
    /// </summary>
    public DayOfWeek? EndDayOfWeek { get; set; }

    /// <summary>
    /// hour that the period starts at.
    /// </summary>
    public int? StartHour { get; set; }

    /// <summary>
    /// hour that the period ends at.
    /// </summary>
    public int? EndHour { get; set; }

    /// <summary>
    /// price during the period.
    /// </summary>
    public double? Price { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(DayOfWeek)}: ({DayOfWeek}), {nameof(EndDayOfWeek)}: ({EndDayOfWeek}), {nameof(StartHour)}: {StartHour}, {nameof(EndHour)}: {EndHour}, {nameof(Price)}: {Price}";
}