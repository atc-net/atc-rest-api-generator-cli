﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Charges;

/// <summary>
/// Breakdown.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Breakdown
{
    /// <summary>
    /// The initial timestamp for this breakdown entry, currently in hourly format.
    /// </summary>
    public DateTimeOffset? From { get; set; }

    /// <summary>
    /// The final timestamp for this breakdown entry, currently in hourly format.
    /// </summary>
    public DateTimeOffset? To { get; set; }

    /// <summary>
    /// The total price for this breakdown entry.
    /// </summary>
    [Required]
    public long SubTotalPrice { get; set; }

    /// <summary>
    /// The total master price for this breakdown entry.
    /// </summary>
    [Required]
    public long SubTotalMasterPrice { get; set; }

    /// <summary>
    /// The total secondary price for this breakdown entry.
    /// </summary>
    [Required]
    public long SubTotalSecondaryPrice { get; set; }

    /// <summary>
    /// The list of prices and tariffs relevant for this breakdown entry.
    /// </summary>
    [Required]
    public List<Component> Components { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(From)}: ({From}), {nameof(To)}: ({To}), {nameof(SubTotalPrice)}: {SubTotalPrice}, {nameof(SubTotalMasterPrice)}: {SubTotalMasterPrice}, {nameof(SubTotalSecondaryPrice)}: {SubTotalSecondaryPrice}, {nameof(Components)}.Count: {Components?.Count ?? 0}";
}