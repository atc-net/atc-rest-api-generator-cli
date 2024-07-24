﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.TeamMembers;

/// <summary>
/// CreateTeamMember.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreateTeamMember
{
    /// <summary>
    /// Id of the team that the user will be invited.
    /// </summary>
    [Range(0, int.MaxValue)]
    public long TeamId { get; set; }

    /// <summary>
    /// Id of the user to be invited&lt;br /&gt;*Note*: When inviting by `userId` the fields `email` or `phone` must not be provided.
    /// </summary>
    [Range(0, int.MaxValue)]
    public long? UserId { get; set; }

    /// <summary>
    /// Email of the user to be invited&lt;br /&gt;*Note*: When inviting by `email` the fields `userId` or `phone` must not be provided.
    /// </summary>
    /// <remarks>
    /// Email validation being enforced.
    /// </remarks>
    [EmailAddress]
    public string? Email { get; set; }

    /// <summary>
    /// Phone of the user to be invited&lt;br /&gt;*Note*: When inviting by `phone` the fields `userId` or `email` must not be provided.
    /// </summary>
    [RegularExpression("^\\+[1-9]\\d{1,14}$")]
    public string? Phone { get; set; }

    [Required]
    public TeamMemberRole Role { get; set; }

    /// <summary>
    /// The price group for this team member, when not provided the default team price group will be applied.
    /// </summary>
    public long? PriceGroupId { get; set; }

    /// <summary>
    /// Gives the team member access to pay with team wallet when charging.
    /// </summary>
    public bool CanPayWithTeamWallet { get; set; } = false;

    /// <summary>
    /// Allows the team member to request sponsoring from this team for their charge point.
    /// </summary>
    public bool CanRequestSponsoring { get; set; } = false;

    /// <summary>
    /// Allows the team member to view and manage other members settings.
    /// </summary>
    public bool CanManageTeamMembers { get; set; } = false;

    public TeamWalletChargePaymentType? TeamWalletChargePaymentType { get; set; }

    /// <summary>
    /// Gives the team member access to withdraw and deposit from your team wallet to your bank account.
    /// </summary>
    public bool CanManageTeamWallet { get; set; } = false;

    /// <summary>
    /// A note for the team member.
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Ids of the charge point this team member with will have access.
    /// </summary>
    public List<long>? ChargePointIds { get; set; } = new List<long>();

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
        => $"{nameof(TeamId)}: {TeamId}, {nameof(UserId)}: {UserId}, {nameof(Email)}: {Email}, {nameof(Phone)}: {Phone}, {nameof(Role)}: ({Role}), {nameof(PriceGroupId)}: {PriceGroupId}, {nameof(CanPayWithTeamWallet)}: {CanPayWithTeamWallet}, {nameof(CanRequestSponsoring)}: {CanRequestSponsoring}, {nameof(CanManageTeamMembers)}: {CanManageTeamMembers}, {nameof(TeamWalletChargePaymentType)}: ({TeamWalletChargePaymentType}), {nameof(CanManageTeamWallet)}: {CanManageTeamWallet}, {nameof(Note)}: {Note}, {nameof(ChargePointIds)}.Count: {ChargePointIds?.Count ?? 0}, {nameof(PartnerExternalId)}: {PartnerExternalId}, {nameof(PartnerCustomPayload)}.Count: {PartnerCustomPayload?.Count ?? 0}";
}