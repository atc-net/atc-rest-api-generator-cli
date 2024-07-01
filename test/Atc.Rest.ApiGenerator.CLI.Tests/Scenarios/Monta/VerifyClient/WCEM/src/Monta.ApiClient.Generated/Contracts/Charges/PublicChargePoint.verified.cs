﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Charges;

/// <summary>
/// PublicChargePoint.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PublicChargePoint
{
    /// <summary>
    /// Id of this charge point.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// The EVSE id for this charge point.
    /// </summary>
    [Required]
    public string EvseId { get; set; }

    /// <summary>
    /// Name of the charge point.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The charge point operator name.
    /// </summary>
    [Required]
    public string ChargePointOperatorName { get; set; }

    [Required]
    public Location Location { get; set; }

    /// <summary>
    /// Max KW available at this charge point.
    /// </summary>
    public double? MaxKw { get; set; }

    /// <summary>
    /// The ID of the charge point model for this charge point.
    /// </summary>
    public long? ChargePointModelId { get; set; }

    /// <summary>
    /// Brand name for this charge point.
    /// </summary>
    public string? BrandName { get; set; }

    /// <summary>
    /// Model name for this charge point.
    /// </summary>
    public string? ModelName { get; set; }

    /// <summary>
    /// Date this charge point was deleted.
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(EvseId)}: {EvseId}, {nameof(Name)}: {Name}, {nameof(ChargePointOperatorName)}: {ChargePointOperatorName}, {nameof(Location)}: ({Location}), {nameof(MaxKw)}: {MaxKw}, {nameof(ChargePointModelId)}: {ChargePointModelId}, {nameof(BrandName)}: {BrandName}, {nameof(ModelName)}: {ModelName}, {nameof(DeletedAt)}: ({DeletedAt})";
}