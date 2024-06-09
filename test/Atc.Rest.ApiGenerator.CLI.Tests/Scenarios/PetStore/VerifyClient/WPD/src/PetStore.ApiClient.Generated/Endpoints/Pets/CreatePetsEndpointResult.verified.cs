//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace PetStore.ApiClient.Generated.Endpoints.Pets;

/// <summary>
/// Client Endpoint result.
/// Description: Create a pet.
/// Operation: CreatePets.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreatePetsEndpointResult : EndpointResponse, ICreatePetsEndpointResult
{
    public CreatePetsEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsOk
        => StatusCode == HttpStatusCode.OK;

    public bool IsUnauthorized
        => StatusCode == HttpStatusCode.Unauthorized;

    public bool IsForbidden
        => StatusCode == HttpStatusCode.Forbidden;

    public bool IsInternalServerError
        => StatusCode == HttpStatusCode.InternalServerError;

    public string OkContent
        => IsOk && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsOk property first.");

    public string InternalServerErrorContent
        => IsInternalServerError && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsInternalServerError property first.");
}