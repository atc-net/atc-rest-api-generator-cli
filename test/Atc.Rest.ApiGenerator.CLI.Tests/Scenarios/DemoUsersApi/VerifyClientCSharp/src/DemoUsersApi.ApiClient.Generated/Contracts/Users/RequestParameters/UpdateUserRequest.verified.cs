﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoUsersApi.ApiClient.Generated.Contracts;

/// <summary>
/// Request to update a user.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateUserRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    /// <summary>
    /// Undefined description.
    /// </summary>
    /// <remarks>
    /// Email validation being enforced.
    /// </remarks>
    [EmailAddress]
    public string Email { get; set; }

    /// <summary>
    /// GenderType.
    /// </summary>
    public GenderType Gender { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Email)}: {Email}, {nameof(Gender)}: {Gender}";
}