﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.ChargeAuthTokens;

/// <summary>
/// CreateChargeAuthToken.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreateChargeAuthToken
{
    /// <summary>
    /// Id of the team the charge auth token belongs.
    /// </summary>
    [Required]
    [Range(0, 2147483647)]
    public long TeamId { get; set; }

    /// <summary>
    /// Id of the user the charge auth token should be associated to.
    /// </summary>
    [Range(0, 2147483647)]
    public long? UserId { get; set; }

    /// <summary>
    /// Identifier of the the charge auth token, Note: without prefix e.g `VID:`.
    /// </summary>
    [Required]
    [MinLength(1)]
    [RegularExpression("^(?!VID:)[\\s\\S]*")]
    public string Identifier { get; set; }

    [Required]
    public ChargeAuthenticationType Type { get; set; }

    /// <summary>
    /// Name of the charge auth token.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// If the charge auth token should be active in the Monta network.
    /// </summary>
    public bool MontaNetwork { get; set; } = true;

    /// <summary>
    /// If the charge auth token should be active in the Roaming network.
    /// </summary>
    public bool RoamingNetwork { get; set; } = true;

    /// <summary>
    /// Indicates that the charge auth token can be used on other teams charge points underthe same operator.
    /// </summary>
    public bool? OperatorNetwork { get; set; } = true;

    /// <summary>
    /// Indicates until when this charge auth token should be active, null means indefinitely.
    /// </summary>
    public DateTimeOffset? ActiveUntil { get; set; }

    /// <summary>
    /// If the charge auth token is blocked, it will not be able to charge.
    /// * `null` = not blocked
    /// * date-time = blocked since date-time.
    /// </summary>
    public DateTimeOffset? BlockedAt { get; set; }

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
        => $"{nameof(TeamId)}: {TeamId}, {nameof(UserId)}: {UserId}, {nameof(Identifier)}: {Identifier}, {nameof(Type)}: ({Type}), {nameof(Name)}: {Name}, {nameof(MontaNetwork)}: {MontaNetwork}, {nameof(RoamingNetwork)}: {RoamingNetwork}, {nameof(OperatorNetwork)}: {OperatorNetwork}, {nameof(ActiveUntil)}: ({ActiveUntil}), {nameof(BlockedAt)}: ({BlockedAt}), {nameof(PartnerExternalId)}: {PartnerExternalId}, {nameof(PartnerCustomPayload)}.Count: {PartnerCustomPayload?.Count ?? 0}";
}