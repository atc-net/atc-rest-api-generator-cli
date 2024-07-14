﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.ChargePointIntegrations;

/// <summary>
/// Parameters for operation request.
/// Description: Create or update a charge point integration.
/// Operation: PostOrPutChargePointIntegration.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PostOrPutChargePointIntegrationParameters
{
    [Required]
    public CreateOrUpdateChargePointIntegration Request { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Request)}: ({Request})";
}