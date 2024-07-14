﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts;

/// <summary>
/// Subscription.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Subscription
{
    /// <summary>
    /// Id of the subscription.
    /// </summary>
    public long Id { get; set; }

    [Required]
    public SubscriptionState State { get; set; }

    /// <summary>
    /// Date of next purchase.
    /// </summary>
    public DateTimeOffset? NextPurchaseAt { get; set; }

    /// <summary>
    /// Subscription cancellation date.
    /// </summary>
    public DateTimeOffset? CancelledAt { get; set; }

    /// <summary>
    /// Subscription end date.
    /// </summary>
    public DateTimeOffset? EndAt { get; set; }

    /// <summary>
    /// Discount percentage.
    /// </summary>
    public double DiscountPercentage { get; set; }

    /// <summary>
    /// Discount absolute.
    /// </summary>
    public double DiscountAbsolute { get; set; }

    /// <summary>
    /// Discount amount.
    /// </summary>
    public double DiscountAmount { get; set; }

    /// <summary>
    /// Original amount.
    /// </summary>
    public double OriginalAmount { get; set; }

    /// <summary>
    /// Total amount.
    /// </summary>
    public double TotalAmount { get; set; }

    /// <summary>
    /// Number of purchases.
    /// </summary>
    public int PurchaseCount { get; set; }

    /// <summary>
    /// Number of charge points.
    /// </summary>
    public int ChargePoints { get; set; }

    /// <summary>
    /// The id of the customer.
    /// </summary>
    public long CustomerId { get; set; }

    [Required]
    public SubscriptionCustomerType CustomerType { get; set; }

    /// <summary>
    /// Plan id.
    /// </summary>
    public long PlanId { get; set; }

    public SubscriptionServiceConfig? ServiceConfig { get; set; }

    /// <summary>
    /// Subscription creation date.
    /// </summary>
    [Required]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Subscription update date.
    /// </summary>
    [Required]
    public DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    /// Indicates if the subscription can be cancelled.
    /// </summary>
    public bool CanCancel { get; set; }

    /// <summary>
    /// Subscription marked as deleted date.
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(State)}: ({State}), {nameof(NextPurchaseAt)}: ({NextPurchaseAt}), {nameof(CancelledAt)}: ({CancelledAt}), {nameof(EndAt)}: ({EndAt}), {nameof(DiscountPercentage)}: {DiscountPercentage}, {nameof(DiscountAbsolute)}: {DiscountAbsolute}, {nameof(DiscountAmount)}: {DiscountAmount}, {nameof(OriginalAmount)}: {OriginalAmount}, {nameof(TotalAmount)}: {TotalAmount}, {nameof(PurchaseCount)}: {PurchaseCount}, {nameof(ChargePoints)}: {ChargePoints}, {nameof(CustomerId)}: {CustomerId}, {nameof(CustomerType)}: ({CustomerType}), {nameof(PlanId)}: {PlanId}, {nameof(ServiceConfig)}: ({ServiceConfig}), {nameof(CreatedAt)}: ({CreatedAt}), {nameof(UpdatedAt)}: ({UpdatedAt}), {nameof(CanCancel)}: {CanCancel}, {nameof(DeletedAt)}: ({DeletedAt})";
}