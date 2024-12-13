﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Invoices;

/// <summary>
/// InvoiceDto.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class InvoiceDto
{
    /// <summary>
    /// Id of the invoice.
    /// </summary>
    [Required]
    public long Id { get; set; }

    /// <summary>
    /// Id of the wallet.
    /// </summary>
    [Required]
    public long WalletId { get; set; }

    /// <summary>
    /// Invoice from date.
    /// </summary>
    [Required]
    public DateTimeOffset From { get; set; }

    /// <summary>
    /// Invoice to date.
    /// </summary>
    [Required]
    public DateTimeOffset To { get; set; }

    /// <summary>
    /// The date it was approved.
    /// </summary>
    public DateTimeOffset? ApprovedAt { get; set; }

    /// <summary>
    /// Total statement.
    /// </summary>
    public double? TotalStatement { get; set; }

    /// <summary>
    /// Total payable balance.
    /// </summary>
    [Required]
    public double TotalPayableBalance { get; set; }

    /// <summary>
    /// Currency.
    /// </summary>
    [Required]
    public CurrencyDto Currency { get; set; }

    /// <summary>
    /// status of the invoice.
    /// </summary>
    [Required]
    public string Status { get; set; }

    /// <summary>
    /// Invoice creation date.
    /// </summary>
    [Required]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Invoice due date.
    /// </summary>
    [Required]
    public DateTimeOffset? DueAt { get; set; }

    /// <summary>
    /// URL to the invoice PDF.
    /// </summary>
    public string? PdfUrl { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(WalletId)}: {WalletId}, {nameof(From)}: ({From}), {nameof(To)}: ({To}), {nameof(ApprovedAt)}: ({ApprovedAt}), {nameof(TotalStatement)}: {TotalStatement}, {nameof(TotalPayableBalance)}: {TotalPayableBalance}, {nameof(Currency)}: ({Currency}), {nameof(Status)}: {Status}, {nameof(CreatedAt)}: ({CreatedAt}), {nameof(DueAt)}: ({DueAt}), {nameof(PdfUrl)}: {PdfUrl}";
}