﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts;

/// <summary>
/// Enumeration: WalletTransactionGroup.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WalletTransactionGroup
{
    [EnumMember(Value = "deposit")]
    Deposit,

    [EnumMember(Value = "withdraw")]
    Withdraw,

    [EnumMember(Value = "charge")]
    Charge,

    [EnumMember(Value = "other")]
    Other,
}