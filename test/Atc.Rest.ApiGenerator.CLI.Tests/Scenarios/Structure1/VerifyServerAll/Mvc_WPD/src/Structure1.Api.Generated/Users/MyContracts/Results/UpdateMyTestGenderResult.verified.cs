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
public class UpdateMyTestGenderResult : ResultBase
{
    private UpdateMyTestGenderResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static UpdateMyTestGenderResult Ok(string? message = null)
        => new UpdateMyTestGenderResult(new OkObjectResult(message));

    /// <summary>
    /// 400 - BadRequest response.
    /// </summary>
    public static UpdateMyTestGenderResult BadRequest(string? message = null)
        => new UpdateMyTestGenderResult(ResultFactory.CreateContentResultWithValidationProblemDetails(HttpStatusCode.BadRequest, message));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static UpdateMyTestGenderResult NotFound(string? message = null)
        => new UpdateMyTestGenderResult(new NotFoundObjectResult(message));

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
    public static UpdateMyTestGenderResult Conflict(string? message = null)
        => new UpdateMyTestGenderResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.Conflict, message));

    /// <summary>
    /// Performs an implicit conversion from UpdateMyTestGenderResult to ActionResult.
    /// </summary>
    public static implicit operator UpdateMyTestGenderResult(string response)
        => Ok(response);
}