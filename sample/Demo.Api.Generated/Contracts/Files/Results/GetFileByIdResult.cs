﻿using System.CodeDom.Compiler;
using System.Net;
using Atc.Rest.Results;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.124.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Files
{
    /// <summary>
    /// Results for operation request.
    /// Description: Get File By Id.
    /// Operation: GetFileById.
    /// Area: Files.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.124.0")]
    public class GetFileByIdResult : ResultBase
    {
        private GetFileByIdResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static GetFileByIdResult Ok(string? message = null) => new GetFileByIdResult(ResultFactory.CreateContentResult(HttpStatusCode.OK, message));

        /// <summary>
        /// 404 - NotFound response.
        /// </summary>
        public static GetFileByIdResult NotFound(string? message = null) => new GetFileByIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.NotFound, message));

        /// <summary>
        /// Performs an implicit conversion from GetFileByIdResult to ActionResult.
        /// </summary>
        public static implicit operator GetFileByIdResult(string response) => Ok(response);
    }
}