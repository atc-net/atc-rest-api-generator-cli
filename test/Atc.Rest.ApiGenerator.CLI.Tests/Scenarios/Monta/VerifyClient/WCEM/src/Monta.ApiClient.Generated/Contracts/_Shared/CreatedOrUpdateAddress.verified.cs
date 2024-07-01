﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts;

/// <summary>
/// CreatedOrUpdateAddress.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreatedOrUpdateAddress
{
    /// <summary>
    /// First line of address.
    /// </summary>
    [Required]
    [MinLength(1)]
    public string Address1 { get; set; }

    /// <summary>
    /// Second line of address.
    /// </summary>
    [MinLength(1)]
    public string? Address2 { get; set; }

    /// <summary>
    /// Third line of address.
    /// </summary>
    [MinLength(1)]
    public string? Address3 { get; set; }

    /// <summary>
    /// The city name.
    /// </summary>
    [Required]
    [MinLength(1)]
    public string City { get; set; }

    /// <summary>
    /// The address zip code.
    /// </summary>
    [Required]
    [MinLength(1)]
    public string ZipCode { get; set; }

    /// <summary>
    /// The country id, Note.
    /// </summary>
    [Required]
    [Range(0, 2147483647)]
    public long CountryId { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Address1)}: {Address1}, {nameof(Address2)}: {Address2}, {nameof(Address3)}: {Address3}, {nameof(City)}: {City}, {nameof(ZipCode)}: {ZipCode}, {nameof(CountryId)}: {CountryId}";
}