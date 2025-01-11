﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.ApiClient.Generated.Users.MyEndpoints;

/// <summary>
/// Client Endpoint result.
/// Description: Get all users.
/// Operation: GetUsers.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetUsersEndpointResult : EndpointResponse, IGetUsersEndpointResult
{
    public GetUsersEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsOk
        => StatusCode == HttpStatusCode.OK;

    public bool IsConflict
        => StatusCode == HttpStatusCode.Conflict;

    public IEnumerable<User> OkContent
        => IsOk && ContentObject is IEnumerable<User> result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsOk property first.");

    public string? ConflictContent
        => IsConflict && ContentObject is string result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsConflict property first.");
}