﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Subscriptions;

/// <summary>
/// CreateSubscription.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreateSubscription
{
    /// <summary>
    /// Id of the plan to subscribe to.
    /// </summary>
    [Range(0, 2147483647)]
    public long PlanId { get; set; }

    [Required]
    public SubscriptionCustomerType CustomerType { get; set; }

    /// <summary>
    /// Id of the customer the subscription is created for, e.g. a chargePointId.
    /// </summary>
    [Range(0, 2147483647)]
    public long CustomerId { get; set; }

    /// <summary>
    /// Allows to modify the absolute discount on a subscription if provided.
    /// If not provided, the discount of the plan is used.
    /// Note: If you want to set it on an existing subscription, you have to cancel the subscription first.
    /// </summary>
    public double? DiscountAbsolute { get; set; }

    /// <summary>
    /// Allows to modify the percentage discount on a subscription if provided.
    /// If not provided, the discount of the plan is used.
    /// Note: If you want to set it on an existing subscription, you have to cancel the subscription first.
    /// </summary>
    public double? DiscountPercentage { get; set; }

    public SubscriptionServiceConfig? ServiceConfig { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(PlanId)}: {PlanId}, {nameof(CustomerType)}: ({CustomerType}), {nameof(CustomerId)}: {CustomerId}, {nameof(DiscountAbsolute)}: {DiscountAbsolute}, {nameof(DiscountPercentage)}: {DiscountPercentage}, {nameof(ServiceConfig)}: ({ServiceConfig})";
}