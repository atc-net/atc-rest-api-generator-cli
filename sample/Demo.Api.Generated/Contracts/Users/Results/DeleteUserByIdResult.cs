﻿using System.CodeDom.Compiler;
using System.Net;
using Atc.Rest.Results;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.87.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users
{
    /// <summary>
    /// Results for operation request.
    /// Description: Delete user by id.
    /// Operation: DeleteUserById.
    /// Area: Users.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.87.0")]
    public class DeleteUserByIdResult : ResultBase
    {
        private DeleteUserByIdResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static DeleteUserByIdResult Ok(string? message = null) => new DeleteUserByIdResult(ResultFactory.CreateContentResult(HttpStatusCode.OK, message));

        /// <summary>
        /// 404 - NotFound response.
        /// </summary>
        public static DeleteUserByIdResult NotFound(string? message = null) => new DeleteUserByIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.NotFound, message));

        /// <summary>
        /// 409 - Conflict response.
        /// </summary>
        public static DeleteUserByIdResult Conflict(string? error = null) => new DeleteUserByIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.Conflict, error));

        /// <summary>
        /// Performs an implicit conversion from DeleteUserByIdResult to ActionResult.
        /// </summary>
        public static implicit operator DeleteUserByIdResult(string response) => Ok(response);
    }
}