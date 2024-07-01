﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts;

/// <summary>
/// PriceGroup.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PriceGroup
{
    /// <summary>
    /// Id of the price group.
    /// </summary>
    [Required]
    [Range(0, 2147483647)]
    public long Id { get; set; }

    /// <summary>
    /// Name of the price group.
    /// </summary>
    [Required]
    public string Name { get; set; }

    public bool Default { get; set; }

    [Required]
    public PriceGroupType Type { get; set; }

    [Required]
    public Pricing MasterPrice { get; set; }

    /// <summary>
    /// Tariffs of the price group.
    /// </summary>
    [Required]
    public List<Pricing>? Tariffs { get; set; }

    /// <summary>
    /// Fees of the price group.
    /// </summary>
    public List<Pricing>? Fees { get; set; } = new List<Pricing>();

    /// <summary>
    /// To how many team members the price group has been applied to.
    /// </summary>
    public int? TeamMemberCount { get; set; }

    /// <summary>
    /// To how many charge points the price group has been applied to.
    /// </summary>
    public int? ChargePointCount { get; set; }

    [Required]
    public PriceGroupAppliedTo AppliedTo { get; set; }

    /// <summary>
    /// When the price group was created.
    /// </summary>
    [Required]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// When the price group was updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Default)}: {Default}, {nameof(Type)}: ({Type}), {nameof(MasterPrice)}: ({MasterPrice}), {nameof(Tariffs)}.Count: {Tariffs?.Count ?? 0}, {nameof(Fees)}.Count: {Fees?.Count ?? 0}, {nameof(TeamMemberCount)}: {TeamMemberCount}, {nameof(ChargePointCount)}: {ChargePointCount}, {nameof(AppliedTo)}: ({AppliedTo}), {nameof(CreatedAt)}: ({CreatedAt}), {nameof(UpdatedAt)}: ({UpdatedAt})";
}