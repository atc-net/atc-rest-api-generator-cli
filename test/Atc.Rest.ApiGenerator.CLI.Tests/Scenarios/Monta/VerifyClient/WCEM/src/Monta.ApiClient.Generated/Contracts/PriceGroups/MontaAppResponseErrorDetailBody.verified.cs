﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.PriceGroups;

/// <summary>
/// MontaAppResponseErrorDetailBody.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class MontaAppResponseErrorDetailBody
{
    [Required]
    public string Message { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Message)}: {Message}";
}