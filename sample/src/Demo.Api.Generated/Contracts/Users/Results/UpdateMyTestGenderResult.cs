﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.239.2173.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users;

/// <summary>
/// Results for operation request.
/// Description: Update gender on a user.
/// Operation: UpdateMyTestGender.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.239.2173")]
public class UpdateMyTestGenderResult : ResultBase
{
    private UpdateMyTestGenderResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
// TODO: Implement this WithProblemDetails OK.

    /// <summary>
    /// 400 - BadRequest response.
    /// </summary>
    public static UpdateMyTestGenderResult BadRequest(string? message = null)
        => new UpdateMyTestGenderResult(ResultFactory.CreateContentResultWithValidationProblemDetails(HttpStatusCode.BadRequest, message));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static UpdateMyTestGenderResult NotFound(string? message = null)
        => new UpdateMyTestGenderResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.NotFound, message));

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
    public static UpdateMyTestGenderResult Conflict(object? error = null)
        => new UpdateMyTestGenderResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.Conflict, error));
}