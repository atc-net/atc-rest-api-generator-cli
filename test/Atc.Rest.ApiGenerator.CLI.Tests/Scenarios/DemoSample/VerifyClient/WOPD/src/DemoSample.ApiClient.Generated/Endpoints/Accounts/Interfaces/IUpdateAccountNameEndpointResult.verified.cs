//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.Accounts.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Update name of account.
/// Operation: UpdateAccountName.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IUpdateAccountNameEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    string? OkContent { get; }

    string? BadRequestContent { get; }

    string? UnauthorizedContent { get; }
}
