﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExGenericPagination.ApiClient.Generated.Endpoints.Dogs;

/// <summary>
/// Client Endpoint result.
/// Description: Find all dogs.
/// Operation: GetDogs.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetDogsEndpointResult : EndpointResponse, IGetDogsEndpointResult
{
    public GetDogsEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsOk
        => StatusCode == HttpStatusCode.OK;

    public bool IsBadRequest
        => StatusCode == HttpStatusCode.BadRequest;

    public PaginatedResult<Dog> OkContent
        => IsOk && ContentObject is PaginatedResult<Dog> result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsOk property first.");

    public ValidationProblemDetails BadRequestContent
        => IsBadRequest && ContentObject is ValidationProblemDetails result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsBadRequest property first.");
}