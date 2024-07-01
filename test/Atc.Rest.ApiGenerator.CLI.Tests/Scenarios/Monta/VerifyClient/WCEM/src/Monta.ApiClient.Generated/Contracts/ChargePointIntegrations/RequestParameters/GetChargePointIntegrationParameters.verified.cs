﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.ChargePointIntegrations;

/// <summary>
/// Parameters for operation request.
/// Description: Retrieve a single charge point integration.
/// Operation: GetChargePointIntegration.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetChargePointIntegrationParameters
{
    [Required]
    public long ChargePointIntegrationId { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ChargePointIntegrationId)}: {ChargePointIntegrationId}";
}