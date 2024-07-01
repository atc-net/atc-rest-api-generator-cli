﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Teams;

/// <summary>
/// CreateTeamDto.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreateTeamDto
{
    /// <summary>
    /// Id of the user that owns the team.
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// email of the user that owns the team, useful when the userId is not known.
    /// </summary>
    /// <remarks>
    /// Email validation being enforced.
    /// </remarks>
    [EmailAddress]
    public string? UserEmail { get; set; }

    /// <summary>
    /// Name of the team.
    /// </summary>
    [Required]
    [MinLength(1)]
    public string Name { get; set; }

    /// <summary>
    /// Contact email of the team.
    /// </summary>
    /// <remarks>
    /// Email validation being enforced.
    /// </remarks>
    [Required]
    [EmailAddress]
    public string ContactEmail { get; set; }

    [Required]
    public TeamTypeCreatable Type { get; set; }

    [Required]
    public CreatedOrUpdateAddress Address { get; set; }

    /// <summary>
    /// The company name for the team.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// The vat number for the team.
    /// </summary>
    public string? VatNumber { get; set; }

    /// <summary>
    /// finance contact email of the team.
    /// </summary>
    /// <remarks>
    /// Email validation being enforced.
    /// </remarks>
    [EmailAddress]
    public string? FinanceEmail { get; set; }

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
        => $"{nameof(UserId)}: {UserId}, {nameof(UserEmail)}: {UserEmail}, {nameof(Name)}: {Name}, {nameof(ContactEmail)}: {ContactEmail}, {nameof(Type)}: ({Type}), {nameof(Address)}: ({Address}), {nameof(CompanyName)}: {CompanyName}, {nameof(VatNumber)}: {VatNumber}, {nameof(FinanceEmail)}: {FinanceEmail}, {nameof(PartnerExternalId)}: {PartnerExternalId}, {nameof(PartnerCustomPayload)}.Count: {PartnerCustomPayload?.Count ?? 0}";
}