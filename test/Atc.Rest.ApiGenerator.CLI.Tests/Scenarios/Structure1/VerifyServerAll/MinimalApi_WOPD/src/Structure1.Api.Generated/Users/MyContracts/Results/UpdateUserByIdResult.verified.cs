﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Users.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Update user by id.
/// Operation: UpdateUserById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateUserByIdResult
{
    private UpdateUserByIdResult(IResult result)
    {
        Result = result;
    }

    public IResult Result { get; }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static UpdateUserByIdResult Ok(string? message = null)
        => new(TypedResults.Ok(message));

    /// <summary>
    /// 400 - BadRequest response.
    /// </summary>
    public static UpdateUserByIdResult BadRequest(string? message = null)
        => new(TypedResults.BadRequest(message));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static UpdateUserByIdResult NotFound(string? message = null)
        => new(TypedResults.NotFound(message));

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
    public static UpdateUserByIdResult Conflict(string? message = null)
        => new(TypedResults.Conflict(message));

    /// <summary>
    /// Performs an implicit conversion from UpdateUserByIdResult to IResult.
    /// </summary>
    public static IResult ToIResult(UpdateUserByIdResult result)
        => result.Result;
}