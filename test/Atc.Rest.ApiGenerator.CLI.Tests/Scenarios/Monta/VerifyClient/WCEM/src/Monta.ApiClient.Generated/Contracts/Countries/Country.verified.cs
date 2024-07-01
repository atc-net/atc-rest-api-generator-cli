﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Countries;

/// <summary>
/// Country.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Country
{
    /// <summary>
    /// Id of the country.
    /// </summary>
    [Required]
    public long Id { get; set; }

    /// <summary>
    /// Name of the country.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Country code in Alpha-2 format, following ISO-3166.
    /// </summary>
    [Required]
    public string Alpha2Code { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Alpha2Code)}: {Alpha2Code}";
}