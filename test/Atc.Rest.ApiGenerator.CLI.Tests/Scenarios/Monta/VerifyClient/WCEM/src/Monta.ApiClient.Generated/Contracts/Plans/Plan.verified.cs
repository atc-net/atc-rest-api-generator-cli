﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Plans;

/// <summary>
/// Plan.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Plan
{
    /// <summary>
    /// The id of the Plan.
    /// </summary>
    [Required]
    public long Id { get; set; }

    /// <summary>
    /// A unique, readable, identifier of the Plan.
    /// </summary>
    [Required]
    public string Identifier { get; set; }

    /// <summary>
    /// Name of the Plan.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Determines the country where the plan is available. `null` means it is available in all countries.
    /// </summary>
    public long? CountryId { get; set; }

    /// <summary>
    /// Description of the Plan.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Summary of the Plan.
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// Terms of the Plan.
    /// </summary>
    public string? Terms { get; set; }

    /// <summary>
    /// URL for a generic contract template the user can fill out right after subscribing.
    /// </summary>
    public string? ContractUrl { get; set; }

    /// <summary>
    /// Support E-Mail for this Plan.
    /// </summary>
    public string? SupportEmail { get; set; }

    [Required]
    public PlanApplicableFor ApplicableFor { get; set; }

    /// <summary>
    /// Indicates if the plan is active (only active plans can be applied).
    /// </summary>
    [Required]
    public bool Active { get; set; }

    [Required]
    public PlanApplicationAudience ApplicationAudience { get; set; }

    /// <summary>
    /// Indicates whether this plan is shown in the market place or not.
    /// </summary>
    [Required]
    public bool VisibleInMarketPlace { get; set; }

    [Required]
    public PlanPriceModel PriceModel { get; set; }

    /// <summary>
    /// Active plan prices.
    /// </summary>
    [Required]
    public List<PlanPrice> Prices { get; set; }

    /// <summary>
    /// Indicates if the prices are incl. VAT or not. Default is `true`.
    /// </summary>
    [Required]
    public bool PricesWithVat { get; set; }

    [Required]
    public PlanServiceType ServiceType { get; set; }

    [Required]
    public PlanServiceConfig ServiceConfig { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(Identifier)}: {Identifier}, {nameof(Name)}: {Name}, {nameof(CountryId)}: {CountryId}, {nameof(Description)}: {Description}, {nameof(Summary)}: {Summary}, {nameof(Terms)}: {Terms}, {nameof(ContractUrl)}: {ContractUrl}, {nameof(SupportEmail)}: {SupportEmail}, {nameof(ApplicableFor)}: ({ApplicableFor}), {nameof(Active)}: {Active}, {nameof(ApplicationAudience)}: ({ApplicationAudience}), {nameof(VisibleInMarketPlace)}: {VisibleInMarketPlace}, {nameof(PriceModel)}: ({PriceModel}), {nameof(Prices)}.Count: {Prices?.Count ?? 0}, {nameof(PricesWithVat)}: {PricesWithVat}, {nameof(ServiceType)}: ({ServiceType}), {nameof(ServiceConfig)}: ({ServiceConfig})";
}