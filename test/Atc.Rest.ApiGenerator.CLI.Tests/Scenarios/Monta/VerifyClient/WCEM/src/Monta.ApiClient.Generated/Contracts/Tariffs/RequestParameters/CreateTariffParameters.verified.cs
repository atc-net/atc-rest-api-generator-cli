﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Tariffs;

/// <summary>
/// Parameters for operation request.
/// Description: Create a new Tariff.
/// Operation: CreateTariff.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreateTariffParameters
{
    [Required]
    public CreateTariffRequest Request { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Request)}: ({Request})";
}