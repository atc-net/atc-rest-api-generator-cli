﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Users.MyContracts;

/// <summary>
/// Request to update a user.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public record UpdateUserRequest(
    string FirstName,
    string LastName,
    [property: EmailAddress] string Email,
    GenderType Gender);