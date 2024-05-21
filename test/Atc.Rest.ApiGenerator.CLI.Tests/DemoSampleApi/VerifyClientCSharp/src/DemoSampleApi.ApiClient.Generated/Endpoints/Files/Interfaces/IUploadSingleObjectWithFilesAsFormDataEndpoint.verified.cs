//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Endpoints.Files.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Upload files as FormData.
/// Operation: UploadSingleObjectWithFilesAsFormData.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IUploadSingleObjectWithFilesAsFormDataEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<IUploadSingleObjectWithFilesAsFormDataEndpointResult> ExecuteAsync(
        UploadSingleObjectWithFilesAsFormDataParameters parameters,
        string httpClientName = "DemoSampleApi-ApiClient",
        CancellationToken cancellationToken = default);
}