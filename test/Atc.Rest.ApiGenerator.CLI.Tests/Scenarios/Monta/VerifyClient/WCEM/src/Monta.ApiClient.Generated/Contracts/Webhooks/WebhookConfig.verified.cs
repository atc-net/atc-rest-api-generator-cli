﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Webhooks;

/// <summary>
/// WebhookConfig.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class WebhookConfig
{
    /// <summary>
    /// A HTTPS URL to send the webhook payload to when an event occurs.
    /// </summary>
    [Required]
    [StringLength(191)]
    [RegularExpression("https://(?!(.*monta\\.com?)).*")]
    public string WebhookUrl { get; set; }

    /// <summary>
    /// A cryptoghrapic secret used to sign the webhook payload.
    /// </summary>
    [Required]
    [MinLength(16)]
    [MaxLength(191)]
    public string WebhookSecret { get; set; }

    /// <summary>
    /// A list of event types to subscribe to.
    /// </summary>
    [Required]
    public List<WebhookEntryEventType> EventTypes { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(WebhookUrl)}: {WebhookUrl}, {nameof(WebhookSecret)}: {WebhookSecret}, {nameof(EventTypes)}.Count: {EventTypes?.Count ?? 0}";
}