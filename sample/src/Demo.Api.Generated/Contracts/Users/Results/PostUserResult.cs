﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.238.14777.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users;

/// <summary>
/// Results for operation request.
/// Description: Create a new user.
/// Operation: PostUser.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.238.14777")]
public class PostUserResult : ResultBase
{
    private PostUserResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 201 - Created response.
    /// </summary>
    public static PostUserResult Created() => new PostUserResult(ResultFactory.CreateContentResult(HttpStatusCode.Created, null));

    /// <summary>
    /// 400 - BadRequest response.
    /// </summary>
// TODO: Implement this WithProblemDetails BadRequest.

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
// TODO: Implement this WithProblemDetails Conflict.
}