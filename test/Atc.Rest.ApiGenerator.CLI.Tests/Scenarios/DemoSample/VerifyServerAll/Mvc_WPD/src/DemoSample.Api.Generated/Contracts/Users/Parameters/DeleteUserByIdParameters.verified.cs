﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.Api.Generated.Contracts.Users;

/// <summary>
/// Parameters for operation request.
/// Description: Delete user by id.
/// Operation: DeleteUserById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class DeleteUserByIdParameters
{
    /// <summary>
    /// Id of the user.
    /// </summary>
    [FromRoute]
    [Required]
    public Guid Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}";
}