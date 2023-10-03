﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Endpoints;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Upload a file as OctetStream.
/// Operation: UploadSingleFileAsFormData.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IUploadSingleFileAsFormDataEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<IUploadSingleFileAsFormDataEndpointResult> ExecuteAsync(
        UploadSingleFileAsFormDataParameters parameters,
        CancellationToken cancellationToken = default);
}