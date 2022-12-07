//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.239.2173.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Addresses;

/// <summary>
/// Results for operation request.
/// Description: Get addresses by postal code.
/// Operation: GetAddressesByPostalCodes.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.239.2173")]
public class GetAddressesByPostalCodesResult : ResultBase
{
    private GetAddressesByPostalCodesResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
// TODO: Implement this WithProblemDetails OK.

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static GetAddressesByPostalCodesResult NotFound(string? message = null)
        => new GetAddressesByPostalCodesResult(ResultFactory.CreateContentResultWithProblemDetails(HttpStatusCode.NotFound, message));
}