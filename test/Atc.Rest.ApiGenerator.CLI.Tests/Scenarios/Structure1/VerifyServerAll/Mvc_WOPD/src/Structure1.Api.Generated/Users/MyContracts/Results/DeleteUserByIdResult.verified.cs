﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Users.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Delete user by id.
/// Operation: DeleteUserById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class DeleteUserByIdResult : ResultBase
{
    private DeleteUserByIdResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static DeleteUserByIdResult Ok(string? message = null)
        => new DeleteUserByIdResult(new OkObjectResult(message));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static DeleteUserByIdResult NotFound(string? message = null)
        => new DeleteUserByIdResult(new NotFoundObjectResult(message));

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
    public static DeleteUserByIdResult Conflict(string? message = null)
        => new DeleteUserByIdResult(new ConflictObjectResult(message));

    /// <summary>
    /// Performs an implicit conversion from DeleteUserByIdResult to ActionResult.
    /// </summary>
    public static implicit operator DeleteUserByIdResult(string response)
        => Ok(response);
}