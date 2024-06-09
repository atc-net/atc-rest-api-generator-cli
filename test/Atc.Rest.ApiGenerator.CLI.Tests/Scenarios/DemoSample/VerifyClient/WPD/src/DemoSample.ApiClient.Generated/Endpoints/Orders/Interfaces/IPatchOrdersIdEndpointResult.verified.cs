//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.Orders.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Update part of order by id.
/// Operation: PatchOrdersId.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IPatchOrdersIdEndpointResult : IEndpointResponse
{
    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    bool IsForbidden { get; }

    bool IsNotFound { get; }

    bool IsConflict { get; }

    bool IsInternalServerError { get; }

    bool IsBadGateway { get; }

    string OkContent { get; }

    ValidationProblemDetails BadRequestContent { get; }

    string NotFoundContent { get; }

    string ConflictContent { get; }

    string InternalServerErrorContent { get; }

    string BadGatewayContent { get; }
}