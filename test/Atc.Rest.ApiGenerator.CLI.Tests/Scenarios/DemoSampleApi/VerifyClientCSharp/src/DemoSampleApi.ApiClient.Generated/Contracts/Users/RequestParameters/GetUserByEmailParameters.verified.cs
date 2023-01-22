﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Contracts;

/// <summary>
/// Parameters for operation request.
/// Description: Get user by email.
/// Operation: GetUserByEmail.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetUserByEmailParameters
{
    /// <summary>
    /// The email of the user to retrieve.
    /// </summary>
    /// <remarks>
    /// Email validation being enforced.
    /// </remarks>
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Email)}: {Email}";
}