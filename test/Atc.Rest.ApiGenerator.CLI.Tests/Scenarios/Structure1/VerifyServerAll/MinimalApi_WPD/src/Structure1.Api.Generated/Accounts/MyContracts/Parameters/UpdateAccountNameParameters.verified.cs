﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Accounts.MyContracts;

/// <summary>
/// Parameters for operation request.
/// Description: Update name of account.
/// Operation: UpdateAccountName.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public record UpdateAccountNameParameters(
    [property: FromRoute, Required] Guid AccountId,
    [property: FromHeader] string? Name);