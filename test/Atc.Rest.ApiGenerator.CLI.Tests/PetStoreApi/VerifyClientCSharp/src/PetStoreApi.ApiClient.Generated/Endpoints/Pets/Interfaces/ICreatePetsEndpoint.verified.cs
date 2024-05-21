//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace PetStoreApi.ApiClient.Generated.Endpoints.Pets.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Create a pet.
/// Operation: CreatePets.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface ICreatePetsEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<ICreatePetsEndpointResult> ExecuteAsync(
        string httpClientName = "PetStoreApi-ApiClient",
        CancellationToken cancellationToken = default);
}