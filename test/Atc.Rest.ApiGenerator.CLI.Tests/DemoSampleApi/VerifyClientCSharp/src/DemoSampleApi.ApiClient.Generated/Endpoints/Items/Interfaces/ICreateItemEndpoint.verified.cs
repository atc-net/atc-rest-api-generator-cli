//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Endpoints;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Create a new item.
/// Operation: CreateItem.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface ICreateItemEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<ICreateItemEndpointResult> ExecuteAsync(
        CreateItemParameters parameters,
        string httpClientName = "DemoSampleApi-ApiClient",
        CancellationToken cancellationToken = default);
}