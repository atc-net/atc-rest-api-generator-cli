//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace GenericPaginationApi.ApiClient.Generated.Endpoints.Dogs.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Find all dogs.
/// Operation: GetDogs.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetDogsEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<IGetDogsEndpointResult> ExecuteAsync(
        GetDogsParameters parameters,
        string httpClientName = "GenericPaginationApi-ApiClient",
        CancellationToken cancellationToken = default);
}