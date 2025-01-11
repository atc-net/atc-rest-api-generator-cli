﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.ApiClient.Generated.Users.MyEndpoints;

/// <summary>
/// Client Endpoint result.
/// Description: Create a new user.
/// Operation: PostUser.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PostUserEndpointResult : EndpointResponse, IPostUserEndpointResult
{
    public PostUserEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsCreated
        => StatusCode == HttpStatusCode.Created;

    public bool IsBadRequest
        => StatusCode == HttpStatusCode.BadRequest;

    public bool IsConflict
        => StatusCode == HttpStatusCode.Conflict;

    public string? CreatedContent
        => IsCreated && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsCreated property first.");

    public string? BadRequestContent
        => IsBadRequest && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsBadRequest property first.");

    public string? ConflictContent
        => IsConflict && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsConflict property first.");
}