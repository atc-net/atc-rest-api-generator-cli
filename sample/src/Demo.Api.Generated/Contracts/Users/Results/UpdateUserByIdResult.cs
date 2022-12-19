﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.241.32395.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users;

/// <summary>
/// Results for operation request.
/// Description: Update user by id.
/// Operation: UpdateUserById.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.241.32395")]
public class UpdateUserByIdResult : ResultBase
{
    private UpdateUserByIdResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static UpdateUserByIdResult Ok(string? message = null)
        => new UpdateUserByIdResult(new OkObjectResult(message));

    /// <summary>
    /// 400 - BadRequest response.
    /// </summary>
    public static UpdateUserByIdResult BadRequest(string message)
        => new UpdateUserByIdResult(ResultFactory.CreateContentResultWithValidationProblemDetails(HttpStatusCode.BadRequest, message));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static UpdateUserByIdResult NotFound(string? message = null)
        => new UpdateUserByIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.NotFound, message));

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
    public static UpdateUserByIdResult Conflict(object? error = null)
        => new UpdateUserByIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.Conflict, error));

    /// <summary>
    /// Performs an implicit conversion from UpdateUserByIdResult to ActionResult.
    /// </summary>
    public static implicit operator UpdateUserByIdResult(string response)
        => Ok(response);
}