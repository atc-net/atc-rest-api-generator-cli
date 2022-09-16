//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Files;

/// <summary>
/// Domain Interface for RequestHandler.
/// Description: Upload a file as OctetStream.
/// Operation: UploadSingleFileAsFormData.
/// Area: Files.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IUploadSingleFileAsFormDataHandler
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<UploadSingleFileAsFormDataResult> ExecuteAsync(UploadSingleFileAsFormDataParameters parameters, CancellationToken cancellationToken = default);
}