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
namespace Demo.Api.Generated.Contracts.Orders
{
    /// <summary>
    /// Results for operation request.
    /// Description: Update part of order by id.
    /// Operation: PatchOrdersId.
    /// Area: Orders.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.87.0")]
    public class PatchOrdersIdResult : ResultBase
    {
        private PatchOrdersIdResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static PatchOrdersIdResult Ok(string? message = null) => new PatchOrdersIdResult(ResultFactory.CreateContentResult(HttpStatusCode.OK, message));

        /// <summary>
        /// 404 - NotFound response.
        /// </summary>
        public static PatchOrdersIdResult NotFound(string? message = null) => new PatchOrdersIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.NotFound, message));

        /// <summary>
        /// 409 - Conflict response.
        /// </summary>
        public static PatchOrdersIdResult Conflict(string? error = null) => new PatchOrdersIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.Conflict, error));

        /// <summary>
        /// 502 - BadGateway response.
        /// </summary>
        public static PatchOrdersIdResult BadGateway(string? message = null) => new PatchOrdersIdResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.BadGateway, message));

        /// <summary>
        /// Performs an implicit conversion from PatchOrdersIdResult to ActionResult.
        /// </summary>
        public static implicit operator PatchOrdersIdResult(string x) => Ok(x);
    }
}