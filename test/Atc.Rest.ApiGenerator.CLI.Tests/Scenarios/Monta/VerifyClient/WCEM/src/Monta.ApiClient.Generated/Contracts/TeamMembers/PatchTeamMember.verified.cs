﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.TeamMembers;

/// <summary>
/// PatchTeamMember.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PatchTeamMember
{
    /// <summary>
    /// Ids of the charge points to patch this team member with.
    /// </summary>
    public List<long>? ChargePointIds { get; set; } = new List<long>();

    public TeamMemberRole? Role { get; set; }

    /// <summary>
    /// The price group for this team member.
    /// </summary>
    public long? PriceGroupId { get; set; }

    /// <summary>
    /// Gives the team member access to pay with team wallet when charging.
    /// </summary>
    public bool? CanPayWithTeamWallet { get; set; } = false;

    /// <summary>
    /// Gives the team member access to withdraw and deposit from your team wallet to your bank account.
    /// </summary>
    public bool? CanManageTeamWallet { get; set; } = false;

    /// <summary>
    /// Allows the team member to request sponsoring from this team for their charge point.
    /// </summary>
    public bool? CanRequestSponsoring { get; set; } = false;

    /// <summary>
    /// Allows the team member to view and manage other members settings.
    /// </summary>
    public bool? CanManageTeamMembers { get; set; } = false;

    public TeamWalletChargePaymentType? TeamWalletChargePaymentType { get; set; }

    /// <summary>
    /// A note for the team member.
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// External Id of this entity, managed by you.
    /// </summary>
    public string? PartnerExternalId { get; set; }

    /// <summary>
    /// Custom JSON payload for this entity, managed by you.
    /// </summary>
    public List<object>? PartnerCustomPayload { get; set; } = new List<object>();

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ChargePointIds)}.Count: {ChargePointIds?.Count ?? 0}, {nameof(Role)}: ({Role}), {nameof(PriceGroupId)}: {PriceGroupId}, {nameof(CanPayWithTeamWallet)}: {CanPayWithTeamWallet}, {nameof(CanManageTeamWallet)}: {CanManageTeamWallet}, {nameof(CanRequestSponsoring)}: {CanRequestSponsoring}, {nameof(CanManageTeamMembers)}: {CanManageTeamMembers}, {nameof(TeamWalletChargePaymentType)}: ({TeamWalletChargePaymentType}), {nameof(Note)}: {Note}, {nameof(PartnerExternalId)}: {PartnerExternalId}, {nameof(PartnerCustomPayload)}.Count: {PartnerCustomPayload?.Count ?? 0}";
}