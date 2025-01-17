﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.TeamMemberProfiles;

/// <summary>
/// TeamMemberProfile.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class TeamMemberProfile
{
    /// <summary>
    /// Id of the team member profile.
    /// </summary>
    [Required]
    public long Id { get; set; }

    /// <summary>
    /// Team id of team member profile.
    /// </summary>
    public long TeamId { get; set; }

    /// <summary>
    /// The team member profile name.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// The team member profile description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Role of the this team member profile.
    /// </summary>
    [Required]
    public TeamMemberRole Role { get; set; }

    /// <summary>
    /// The price group for this team member profile.
    /// </summary>
    public long? PriceGroupId { get; set; }

    /// <summary>
    /// The cost group for this team member profile.
    /// </summary>
    public long? CostGroupId { get; set; }

    /// <summary>
    /// Indicates if the team member profile access to pay with team wallet when charging.
    /// </summary>
    public bool CanPayWithTeamWallet { get; set; } = false;

    /// <summary>
    /// Indicates if team member profile has access to withdraw and deposit from your team wallet to your bank account.
    /// </summary>
    public bool CanManageTeamWallet { get; set; } = false;

    /// <summary>
    /// Indicates if the team member profile is allowed to request sponsoring from this team for their charge point.
    /// </summary>
    public bool CanRequestSponsoring { get; set; } = false;

    /// <summary>
    /// Indicates that the team member profile can view and manage other members settings.
    /// </summary>
    public bool CanManageTeamMembers { get; set; } = false;

    /// <summary>
    /// Indicates that the team member profile can configure charge points.
    /// </summary>
    public bool CanConfigureChargePoints { get; set; } = false;

    /// <summary>
    /// Who can pay the charging with Wallet?.
    /// </summary>
    [Required]
    public TeamWalletChargePaymentType TeamWalletChargePaymentType { get; set; } = TeamWalletChargePaymentType.None;

    /// <summary>
    /// List of country ids for which the team member can pay for charges.
    /// </summary>
    public List<int>? CanPayForChargesCountryIds { get; set; } = new List<int>();

    /// <summary>
    /// Operator of this team member.
    /// </summary>
    public Operator? Operator { get; set; }

    /// <summary>
    /// Date the team member profile was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// Date the team member profile was updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// Date the team member profile was deleted.
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(TeamId)}: {TeamId}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Role)}: ({Role}), {nameof(PriceGroupId)}: {PriceGroupId}, {nameof(CostGroupId)}: {CostGroupId}, {nameof(CanPayWithTeamWallet)}: {CanPayWithTeamWallet}, {nameof(CanManageTeamWallet)}: {CanManageTeamWallet}, {nameof(CanRequestSponsoring)}: {CanRequestSponsoring}, {nameof(CanManageTeamMembers)}: {CanManageTeamMembers}, {nameof(CanConfigureChargePoints)}: {CanConfigureChargePoints}, {nameof(TeamWalletChargePaymentType)}: {TeamWalletChargePaymentType}, {nameof(CanPayForChargesCountryIds)}.Count: {CanPayForChargesCountryIds?.Count ?? 0}, {nameof(Operator)}: ({Operator}), {nameof(CreatedAt)}: ({CreatedAt}), {nameof(UpdatedAt)}: ({UpdatedAt}), {nameof(DeletedAt)}: ({DeletedAt})";
}