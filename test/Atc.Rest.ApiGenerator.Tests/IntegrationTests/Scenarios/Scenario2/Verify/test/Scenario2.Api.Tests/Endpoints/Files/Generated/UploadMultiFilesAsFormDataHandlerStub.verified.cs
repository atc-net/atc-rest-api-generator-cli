﻿using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;
using Scenario2.Api.Generated.Contracts.Files;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Files.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class UploadMultiFilesAsFormDataHandlerStub : IUploadMultiFilesAsFormDataHandler
    {
        public Task<UploadMultiFilesAsFormDataResult> ExecuteAsync(UploadMultiFilesAsFormDataParameters parameters, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(UploadMultiFilesAsFormDataResult.Ok("Hallo world"));
        }
    }
}