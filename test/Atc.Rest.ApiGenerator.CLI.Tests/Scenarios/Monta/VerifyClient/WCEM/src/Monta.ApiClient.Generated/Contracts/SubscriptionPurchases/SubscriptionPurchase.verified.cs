﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.SubscriptionPurchases;

/// <summary>
/// SubscriptionPurchase.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class SubscriptionPurchase
{
    /// <summary>
    /// Id of the subscription purchase.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Note for this subscription purchase.
    /// </summary>
    public string? Note { get; set; }

    [Required]
    public SubscriptionPurchaseTypeDto Type { get; set; }

    /// <summary>
    /// The discount percentage applied to this purchase.
    /// </summary>
    public double DiscountPercentage { get; set; }

    /// <summary>
    /// The absolute discount applied to this purchase.
    /// </summary>
    public double DiscountAbsolute { get; set; }

    /// <summary>
    /// The original amount of this purchase.
    /// </summary>
    public double OriginalAmount { get; set; }

    /// <summary>
    /// The discounted amount of this purchase.
    /// </summary>
    public double DiscountAmount { get; set; }

    /// <summary>
    /// The total amount of this purchase.
    /// </summary>
    public double TotalAmount { get; set; }

    [Required]
    public Currency Currency { get; set; }

    [Required]
    public Subscription Subscription { get; set; }

    /// <summary>
    /// Creation date of this subscription purchase.
    /// </summary>
    [Required]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Update date of this subscription purchase.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// Deleted date of this subscription purchase.
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(Note)}: {Note}, {nameof(Type)}: ({Type}), {nameof(DiscountPercentage)}: {DiscountPercentage}, {nameof(DiscountAbsolute)}: {DiscountAbsolute}, {nameof(OriginalAmount)}: {OriginalAmount}, {nameof(DiscountAmount)}: {DiscountAmount}, {nameof(TotalAmount)}: {TotalAmount}, {nameof(Currency)}: ({Currency}), {nameof(Subscription)}: ({Subscription}), {nameof(CreatedAt)}: ({CreatedAt}), {nameof(UpdatedAt)}: ({UpdatedAt}), {nameof(DeletedAt)}: ({DeletedAt})";
}