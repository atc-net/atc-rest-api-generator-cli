//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Files.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class UploadSingleObjectWithFileAsFormDataHandlerStub : IUploadSingleObjectWithFileAsFormDataHandler
    {
        public Task<UploadSingleObjectWithFileAsFormDataResult> ExecuteAsync(UploadSingleObjectWithFileAsFormDataParameters parameters, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(UploadSingleObjectWithFileAsFormDataResult.Ok("Hallo world"));
        }
    }
}