﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts;

/// <summary>
/// Enumeration: SubscriptionPurchaseTypeDto.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SubscriptionPurchaseTypeDto
{
    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "diff")]
    Diff,

    [EnumMember(Value = "unknown")]
    Unknown,
}