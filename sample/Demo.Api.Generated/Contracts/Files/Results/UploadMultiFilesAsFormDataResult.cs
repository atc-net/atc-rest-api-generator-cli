﻿using System.CodeDom.Compiler;
using System.Net;
using Atc.Rest.Results;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.154.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Files
{
    /// <summary>
    /// Results for operation request.
    /// Description: Upload multi files as form data.
    /// Operation: UploadMultiFilesAsFormData.
    /// Area: Files.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.154.0")]
    public class UploadMultiFilesAsFormDataResult : ResultBase
    {
        private UploadMultiFilesAsFormDataResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static UploadMultiFilesAsFormDataResult Ok(string? message = null) => new UploadMultiFilesAsFormDataResult(ResultFactory.CreateContentResult(HttpStatusCode.OK, message));

        /// <summary>
        /// Performs an implicit conversion from UploadMultiFilesAsFormDataResult to ActionResult.
        /// </summary>
        public static implicit operator UploadMultiFilesAsFormDataResult(string response) => Ok(response);
    }
}