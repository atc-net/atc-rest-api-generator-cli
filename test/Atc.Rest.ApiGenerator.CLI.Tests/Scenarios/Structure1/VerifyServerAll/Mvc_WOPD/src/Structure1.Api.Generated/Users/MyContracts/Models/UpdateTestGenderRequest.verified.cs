﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Users.MyContracts;

/// <summary>
/// Update test-gender Request.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateTestGenderRequest
{
    /// <summary>
    /// GenderType.
    /// </summary>
    public GenderType Gender { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Gender)}: {Gender}";
}