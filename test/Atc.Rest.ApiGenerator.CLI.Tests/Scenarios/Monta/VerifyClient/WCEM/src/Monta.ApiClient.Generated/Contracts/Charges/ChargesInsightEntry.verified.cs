﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Charges;

/// <summary>
/// ChargesInsightEntry.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class ChargesInsightEntry
{
    [Required]
    public ChargesInsightEntryTypeDto Type { get; set; }

    [Required]
    public ChargesInsightSummary Summary { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Type)}: ({Type}), {nameof(Summary)}: ({Summary})";
}