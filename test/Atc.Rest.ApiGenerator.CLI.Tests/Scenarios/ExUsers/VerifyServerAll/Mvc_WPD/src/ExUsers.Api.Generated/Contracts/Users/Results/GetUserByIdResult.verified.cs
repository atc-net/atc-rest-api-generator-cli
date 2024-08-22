﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExUsers.Api.Generated.Contracts.Users;

/// <summary>
/// Results for operation request.
/// Description: Get user by id.
/// Operation: GetUserById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetUserByIdResult : ResultBase
{
    private GetUserByIdResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetUserByIdResult Ok(User response)
        => new GetUserByIdResult(new OkObjectResult(response));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static GetUserByIdResult NotFound(string? message = null)
        => new GetUserByIdResult(new NotFoundObjectResult(message));

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
    public static GetUserByIdResult Conflict(string? message = null)
        => new GetUserByIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.Conflict, message));

    /// <summary>
    /// Performs an implicit conversion from GetUserByIdResult to ActionResult.
    /// </summary>
    public static implicit operator GetUserByIdResult(User response)
        => Ok(response);
}