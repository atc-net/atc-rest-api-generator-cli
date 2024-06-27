//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExUsers.ApiClient.Generated.Endpoints.Users.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Delete user by id.
/// Operation: DeleteUserById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IDeleteUserByIdEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    bool IsNotFound { get; }

    bool IsConflict { get; }

    string? OkContent { get; }

    ValidationProblemDetails BadRequestContent { get; }

    ProblemDetails UnauthorizedContent { get; }

    ProblemDetails NotFoundContent { get; }

    ProblemDetails ConflictContent { get; }
}
