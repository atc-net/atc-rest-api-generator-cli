﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.ChargeAuthTokens;

/// <summary>
/// Parameters for operation request.
/// Description: Retrieve list of charge auth tokens.
/// Operation: GetChargeAuthTokens.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetChargeAuthTokensParameters
{
    /// <summary>
    /// Filter to retrieve charges auth tokens with specified teamId.
    /// </summary>
    public long TeamId { get; set; }

    /// <summary>
    /// Filter charge auth tokens by partnerExternalId, to filter only resources without `partnerExternalId` *use* `partnerExternalId=""`.
    /// </summary>
    public string PartnerExternalId { get; set; }

    /// <summary>
    /// page number to retrieve (starts with 0).
    /// </summary>
    public int Page { get; set; } = 0;

    /// <summary>
    /// number of items per page (between 1 and 100, default 10).
    /// </summary>
    public int PerPage { get; set; } = 10;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(TeamId)}: {TeamId}, {nameof(PartnerExternalId)}: {PartnerExternalId}, {nameof(Page)}: {Page}, {nameof(PerPage)}: {PerPage}";
}