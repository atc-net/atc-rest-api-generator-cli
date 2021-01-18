﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Atc.Rest.Results;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.33.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users
{
    /// <summary>
    /// Results for operation request.
    /// Description: Get all users.
    /// Operation: GetUsers.
    /// Area: Users.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.33.0")]
    public class GetUsersResult : ResultBase
    {
        private GetUsersResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static GetUsersResult Ok(List<User> response) => new GetUsersResult(new OkObjectResult(response));

        /// <summary>
        /// 409 - Conflict response.
        /// </summary>
        public static GetUsersResult Conflict(string? error = null) => new GetUsersResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.Conflict, error));

        /// <summary>
        /// Performs an implicit conversion from GetUsersResult to ActionResult.
        /// </summary>
        public static implicit operator GetUsersResult(List<User> x) => Ok(x);
    }
}