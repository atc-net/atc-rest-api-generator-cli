﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace MontaPartner.ApiClient.Generated.Contracts.ChargePoints;

/// <summary>
/// CreateChargePoint.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreateChargePoint
{
    /// <summary>
    /// Id of the team that the charge point belongs to.
    /// </summary>
    [Required]
    [Range(0, 2147483647)]
    public long TeamId { get; set; }

    /// <summary>
    /// Id of the site the charge point belongs to.
    /// </summary>
    [Required]
    [Range(0, 2147483647)]
    public long SiteId { get; set; }

    /// <summary>
    /// Id of the charge point model.
    /// </summary>
    [Required]
    [Range(0, 2147483647)]
    public long ChargePointModelId { get; set; }

    /// <summary>
    /// Name of the charge point.
    /// </summary>
    [Required]
    [MinLength(1)]
    public string Name { get; set; }

    /// <summary>
    /// Max Kw (Max Power) the charge point can output.
    /// </summary>
    [Required]
    public double MaxKw { get; set; }

    [Required]
    public VisibilityType Visibility { get; set; }

    [Required]
    public ElectricCurrentType Type { get; set; }

    /// <summary>
    /// Indicates the charge point is active.
    /// </summary>
    public bool? Active { get; set; } = true;

    /// <summary>
    /// Indicates the charge point should be displayed on map.
    /// By setting this to false, the charge point will not be shown on the app's map,
    /// but will still be fully functional for users of the charge point.
    /// </summary>
    public bool? ShowOnMap { get; set; } = true;

    /// <summary>
    /// Ids of the connectors this charge point support,
    /// When not present the provide charge point model connectors will be used instead.
    /// </summary>
    public List<long>? ConnectorIds { get; set; } = new List<long>();

    /// <summary>
    /// A note (instructions, warning, information) you have entered for this charge point.
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// External Id of this entity, managed by you.
    /// </summary>
    public string? PartnerExternalId { get; set; }

    /// <summary>
    /// Custom JSON payload for this entity, managed by you.
    /// </summary>
    public List<Object>? PartnerCustomPayload { get; set; } = new List<Object>();

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(TeamId)}: {TeamId}, {nameof(SiteId)}: {SiteId}, {nameof(ChargePointModelId)}: {ChargePointModelId}, {nameof(Name)}: {Name}, {nameof(MaxKw)}: {MaxKw}, {nameof(Visibility)}: ({Visibility}), {nameof(Type)}: ({Type}), {nameof(Active)}: {Active}, {nameof(ShowOnMap)}: {ShowOnMap}, {nameof(ConnectorIds)}.Count: {ConnectorIds?.Count ?? 0}, {nameof(Note)}: {Note}, {nameof(PartnerExternalId)}: {PartnerExternalId}, {nameof(PartnerCustomPayload)}.Count: {PartnerCustomPayload?.Count ?? 0}";
}