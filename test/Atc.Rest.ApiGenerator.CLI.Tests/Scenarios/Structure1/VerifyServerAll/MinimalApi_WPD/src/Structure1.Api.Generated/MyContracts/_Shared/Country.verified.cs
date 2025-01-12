﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.MyContracts;

/// <summary>
/// Country.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public record Country(
    [property: Required] string Name,
    [property: Required, MinLength(2), MaxLength(2), RegularExpression("^[A-Za-z]{2}$")] string Alpha2code,
    [property: Required, MinLength(3), MaxLength(3), RegularExpression("^[A-Za-z]{3}$")] string Alpha3code);