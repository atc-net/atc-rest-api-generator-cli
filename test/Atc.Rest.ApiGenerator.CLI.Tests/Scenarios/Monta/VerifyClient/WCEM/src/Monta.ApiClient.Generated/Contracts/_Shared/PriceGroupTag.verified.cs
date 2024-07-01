﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts;

/// <summary>
/// PriceGroupTag.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PriceGroupTag
{
    /// <summary>
    /// The id for this tag.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// The name for this tag.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// The description for this tag.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// External Id of this entity, managed by you.
    /// </summary>
    public string? PartnerExternalId { get; set; }

    /// <summary>
    /// Custom JSON payload for this entity, managed by you.
    /// </summary>
    public List<Object>? PartnerCustomPayload { get; set; } = new List<Object>();

    public Operator? Operator { get; set; }

    /// <summary>
    /// Creation date of this resource.
    /// </summary>
    [Required]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Last update date of this resource.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(PartnerExternalId)}: {PartnerExternalId}, {nameof(PartnerCustomPayload)}.Count: {PartnerCustomPayload?.Count ?? 0}, {nameof(Operator)}: ({Operator}), {nameof(CreatedAt)}: ({CreatedAt}), {nameof(UpdatedAt)}: ({UpdatedAt})";
}