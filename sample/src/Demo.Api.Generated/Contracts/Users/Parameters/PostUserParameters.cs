﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.197.51239.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users;

/// <summary>
/// Parameters for operation request.
/// Description: Create a new user.
/// Operation: PostUser.
/// Area: Users.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.197.51239")]
public class PostUserParameters
{
    /// <summary>
    /// Request to create a user.
    /// </summary>
    [FromBody]
    [Required]
    public CreateUserRequest Request { get; set; }

    /// <summary>
    /// Converts to string.
    /// </summary>
    public override string ToString()
    {
        return $"{nameof(Request)}: ({Request})";
    }
}