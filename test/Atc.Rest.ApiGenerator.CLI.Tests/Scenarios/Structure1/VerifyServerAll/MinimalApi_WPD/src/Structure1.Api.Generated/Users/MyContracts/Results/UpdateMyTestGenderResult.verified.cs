﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Users.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Update gender on a user.
/// Operation: UpdateMyTestGender.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateMyTestGenderResult
{
    private UpdateMyTestGenderResult(IResult result)
    {
        Result = result;
    }

    public IResult Result { get; }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static UpdateMyTestGenderResult Ok(string? message = null)
        => new(TypedResults.Ok(message));

    /// <summary>
    /// 400 - BadRequest response.
    /// </summary>
    public static UpdateMyTestGenderResult BadRequest(string? message = null, IDictionary<string, string[]>? errors = null)
        => new(Results.ValidationProblem(errors ?? new Dictionary<string, string[]>(), message, null, StatusCodes.Status400BadRequest));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static UpdateMyTestGenderResult NotFound(string? message = null)
        => new(TypedResults.NotFound(message));

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
    public static UpdateMyTestGenderResult Conflict(string? message = null)
        => new(Results.Problem(message, null, StatusCodes.Status409Conflict));

    /// <summary>
    /// Performs an implicit conversion from UpdateMyTestGenderResult to IResult.
    /// </summary>
    public static IResult ToIResult(UpdateMyTestGenderResult result)
        => result.Result;
}