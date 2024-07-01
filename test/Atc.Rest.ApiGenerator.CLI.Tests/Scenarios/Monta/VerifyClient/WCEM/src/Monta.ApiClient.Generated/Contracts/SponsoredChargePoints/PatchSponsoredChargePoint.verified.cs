﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.SponsoredChargePoints;

/// <summary>
/// Note: Only use Optional for fields that can bet set null. Optional will insure jackson can differentiate between a field that was set to NULL X Field that was never present on the request.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PatchSponsoredChargePoint
{
    /// <summary>
    /// The price group for this sponsorship, Only price groups of type `reimbursement` or `sponsored` are allowed&lt;br /&gt;*Note:* if the `priceGroupId` is null the charge point cost price group will be used instead, if the charge point has no cost price group set the request will fail.
    /// </summary>
    public long? PriceGroupId { get; set; }

    public SponsoredChargePointPayoutType? PayoutSchedule { get; set; }

    /// <summary>
    /// Indicates that company pay for subscriptions.
    /// </summary>
    public bool? PayForSubscriptions { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(PriceGroupId)}: {PriceGroupId}, {nameof(PayoutSchedule)}: ({PayoutSchedule}), {nameof(PayForSubscriptions)}: {PayForSubscriptions}";
}