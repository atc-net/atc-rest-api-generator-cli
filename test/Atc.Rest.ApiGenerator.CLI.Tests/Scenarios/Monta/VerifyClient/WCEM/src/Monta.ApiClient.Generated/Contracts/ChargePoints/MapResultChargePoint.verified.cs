﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.ChargePoints;

/// <summary>
/// Reduced model of Charge Point.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class MapResultChargePoint
{
    /// <summary>
    /// Id of this charge point.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Id of the site.
    /// </summary>
    public long? SiteId { get; set; }

    /// <summary>
    /// Name of the site.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Indicates if this charge point is `public` or `private`.
    /// </summary>
    [Required]
    public string Visibility { get; set; }

    /// <summary>
    /// Max KW available at this charge point.
    /// </summary>
    public double? MaxKw { get; set; }

    /// <summary>
    /// Type of charge point (`AC` / `DC`).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// A note you have entered for this charge point, e.g. via our Portal.
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Chargepoint state.
    /// </summary>
    public string? State { get; set; }

    [Required]
    public Location Location { get; set; }

    /// <summary>
    /// List of supported connector types at this charge point (e.g. type-2, ccs, ...).
    /// </summary>
    [Required]
    public List<ChargePointConnector> Connectors { get; set; }

    [Required]
    public ChargePointDeeplinks Deeplinks { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(SiteId)}: {SiteId}, {nameof(Name)}: {Name}, {nameof(Visibility)}: {Visibility}, {nameof(MaxKw)}: {MaxKw}, {nameof(Type)}: {Type}, {nameof(Note)}: {Note}, {nameof(State)}: {State}, {nameof(Location)}: ({Location}), {nameof(Connectors)}.Count: {Connectors?.Count ?? 0}, {nameof(Deeplinks)}: ({Deeplinks})";
}