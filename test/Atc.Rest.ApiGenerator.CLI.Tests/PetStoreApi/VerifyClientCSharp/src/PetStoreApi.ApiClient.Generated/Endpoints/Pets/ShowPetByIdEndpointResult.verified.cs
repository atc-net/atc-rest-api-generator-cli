﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace PetStoreApi.ApiClient.Generated.Endpoints;

/// <summary>
/// Client Endpoint result.
/// Description: Info for a specific pet.
/// Operation: ShowPetById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class ShowPetByIdEndpointResult : EndpointResponse, IShowPetByIdEndpointResult
{
    public ShowPetByIdEndpointResult(EndpointResponse response)
    : base(response)
    {
    }

    public bool IsOk
        => StatusCode == HttpStatusCode.OK;

    public bool IsBadRequest
        => StatusCode == HttpStatusCode.BadRequest;

    public bool IsUnauthorized
        => StatusCode == HttpStatusCode.Unauthorized;

    public bool IsForbidden
        => StatusCode == HttpStatusCode.Forbidden;

    public bool IsInternalServerError
        => StatusCode == HttpStatusCode.InternalServerError;

    public Pet OkContent
        => IsOk && ContentObject is Pet result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsOk property first.");

    public ValidationProblemDetails BadRequestContent
        => IsBadRequest && ContentObject is ValidationProblemDetails result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsBadRequest property first.");

    public string InternalServerErrorContent
        => IsInternalServerError && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsInternalServerError property first.");
}