﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.MyContracts;

/// <summary>
/// Address.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public record Address(
    [property: StringLength(255)] string StreetName,
    string StreetNumber,
    string PostalCode,
    string CityName,
    Country MyCountry);