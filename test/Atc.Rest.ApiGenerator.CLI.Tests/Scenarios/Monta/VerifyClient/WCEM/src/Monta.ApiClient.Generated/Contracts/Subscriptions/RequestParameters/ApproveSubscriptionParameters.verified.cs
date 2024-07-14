﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Subscriptions;

/// <summary>
/// Parameters for operation request.
/// Description: Approve subscription.
/// Operation: ApproveSubscription.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class ApproveSubscriptionParameters
{
    [Required]
    public long SubscriptionId { get; set; }

    [Required]
    public ApproveSubscription Request { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(SubscriptionId)}: {SubscriptionId}, {nameof(Request)}: ({Request})";
}