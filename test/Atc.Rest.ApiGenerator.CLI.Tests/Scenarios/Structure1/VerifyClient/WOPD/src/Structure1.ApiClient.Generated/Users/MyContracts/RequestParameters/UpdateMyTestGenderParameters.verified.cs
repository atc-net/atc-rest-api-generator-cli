﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.ApiClient.Generated.Users.MyContracts;

/// <summary>
/// Parameters for operation request.
/// Description: Update gender on a user.
/// Operation: UpdateMyTestGender.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateMyTestGenderParameters
{
    /// <summary>
    /// Id of the user.
    /// </summary>
    [Required]
    public Guid Id { get; set; }

    /// <summary>
    /// The gender to set on the user.
    /// </summary>
    public GenderType? GenderParam { get; set; }

    /// <summary>
    /// Update test-gender Request.
    /// </summary>
    [Required]
    public UpdateTestGenderRequest Request { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(GenderParam)}: {GenderParam}, {nameof(Request)}: ({Request})";
}