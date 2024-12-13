﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts;

/// <summary>
/// SimCard.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class SimCard
{
    /// <summary>
    /// imsi (International Mobile Subscriber Identity) for the SIM card.
    /// </summary>
    public string? Imsi { get; set; }

    /// <summary>
    /// iccid (Integrated Circuit Card Identifier) for the SIM card.
    /// </summary>
    public string? Iccid { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Imsi)}: {Imsi}, {nameof(Iccid)}: {Iccid}";
}