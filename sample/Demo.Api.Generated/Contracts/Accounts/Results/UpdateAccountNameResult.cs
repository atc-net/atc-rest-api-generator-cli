﻿using System;
using System.CodeDom.Compiler;
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
namespace Demo.Api.Generated.Contracts.Accounts
{
    /// <summary>
    /// Results for operation request.
    /// Description: Update name of account.
    /// Operation: UpdateAccountName.
    /// Area: Accounts.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.33.0")]
    public class UpdateAccountNameResult : ResultBase
    {
        private UpdateAccountNameResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static UpdateAccountNameResult Ok(string? message = null) => new UpdateAccountNameResult(ResultFactory.CreateContentResult(HttpStatusCode.OK, message));

        /// <summary>
        /// Performs an implicit conversion from UpdateAccountNameResult to ActionResult.
        /// </summary>
        public static implicit operator UpdateAccountNameResult(string x) => Ok(x);
    }
}