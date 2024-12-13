﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Prices;

/// <summary>
/// Currency17.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Currency17
{
    /// <summary>
    /// Currency identifier, e.g. dkk.
    /// </summary>
    [Required]
    public string Identifier { get; set; }

    /// <summary>
    /// Readable name of currency.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Number of decimals for this currency.
    /// </summary>
    public int Decimals { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Identifier)}: {Identifier}, {nameof(Name)}: {Name}, {nameof(Decimals)}: {Decimals}";
}