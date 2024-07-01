﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Charges;

/// <summary>
/// ChargesInsight.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class ChargesInsight
{
    [Required]
    public ChargesInsightTypeDto Type { get; set; }

    /// <summary>
    /// Indicates the starting period (`fromDate`) used calculate the insights, format (YYYY-MM-DD)&lt;br /&gt;&lt;br /&gt;*Note*: The date will be always in UTC.
    /// </summary>
    [Required]
    public DateTimeOffset FromDate { get; set; }

    /// <summary>
    /// Indicates the end period (`toDate`) used calculate the insights, format (YYYY-MM-DD), always in UCT&lt;br /&gt;&lt;br /&gt;*Note*: The date will be always in UTC.
    /// </summary>
    [Required]
    public DateTimeOffset ToDate { get; set; }

    /// <summary>
    /// The title for for this charge insight.
    /// </summary>
    [Required]
    public string Title { get; set; }

    [Required]
    public Operator Operator { get; set; }

    [Required]
    public Currency Currency { get; set; }

    /// <summary>
    /// The compilation of insights entries composing this charge insight.
    /// </summary>
    [Required]
    public List<ChargesInsightEntry> Insights { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Type)}: ({Type}), {nameof(FromDate)}: ({FromDate}), {nameof(ToDate)}: ({ToDate}), {nameof(Title)}: {Title}, {nameof(Operator)}: ({Operator}), {nameof(Currency)}: ({Currency}), {nameof(Insights)}.Count: {Insights?.Count ?? 0}";
}