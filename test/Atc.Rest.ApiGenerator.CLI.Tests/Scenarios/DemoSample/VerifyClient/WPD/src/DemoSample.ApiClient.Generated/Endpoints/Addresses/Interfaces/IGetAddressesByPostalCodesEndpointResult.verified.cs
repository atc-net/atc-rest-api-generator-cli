//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.Addresses.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Get addresses by postal code.
/// Operation: GetAddressesByPostalCodes.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetAddressesByPostalCodesEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsBadRequest { get; }

    bool IsUnauthorized { get; }

    bool IsNotFound { get; }

    IEnumerable<Address> OkContent { get; }

    ValidationProblemDetails BadRequestContent { get; }

    ProblemDetails UnauthorizedContent { get; }

    ProblemDetails NotFoundContent { get; }
}
