﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace MontaPartner.ApiClient.Generated.Contracts.Sites;

/// <summary>
/// Parameters for operation request.
/// Description: Retrieve your (charge) sites.
/// Operation: GetSites.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetSitesParameters
{
    /// <summary>
    /// page number to retrieve (starts with 0).
    /// </summary>
    public int Page { get; set; } = 0;

    /// <summary>
    /// number of items per page (between 1 and 100, default 10).
    /// </summary>
    public int PerPage { get; set; } = 10;

    /// <summary>
    /// The team id from which sites will be filtered by.
    /// </summary>
    public long TeamId { get; set; }

    /// <summary>
    /// Filter sites by partnerExternalId, to filter only resources without `partnerExternalId` *use* `partnerExternalId=""`.
    /// </summary>
    public string PartnerExternalId { get; set; }

    /// <summary>
    /// lat,long coordinates. If supplied, the Charge Points will be sorted in nearest first order relative
    /// to this point. (Format: 55.7096,12.5856).
    /// </summary>
    public string SortByLocation { get; set; }

    /// <summary>
    /// Includes deleted resources in the response.
    /// </summary>
    public bool IncludeDeleted { get; set; } = false;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Page)}: {Page}, {nameof(PerPage)}: {PerPage}, {nameof(TeamId)}: {TeamId}, {nameof(PartnerExternalId)}: {PartnerExternalId}, {nameof(SortByLocation)}: {SortByLocation}, {nameof(IncludeDeleted)}: {IncludeDeleted}";
}