﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.324.48157.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Files;

[GeneratedCode("ApiGenerator", "2.0.324.48157")]
public class UploadMultiFilesAsFormDataHandlerStub : IUploadMultiFilesAsFormDataHandler
{
    public Task<UploadMultiFilesAsFormDataResult> ExecuteAsync(
        UploadMultiFilesAsFormDataParameters parameters,
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(UploadMultiFilesAsFormDataResult.Ok("Hallo world"));
    }
}