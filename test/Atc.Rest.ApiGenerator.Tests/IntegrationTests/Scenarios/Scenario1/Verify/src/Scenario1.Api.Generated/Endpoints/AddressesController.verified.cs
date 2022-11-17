//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario1.Api.Generated.Endpoints;

/// <summary>
/// Endpoint definitions.
/// Area: Addresses.
/// </summary>
[ApiController]
[Route("/api/v1/addresses")]
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class AddressesController : ControllerBase
{
    /// <summary>
    /// Description: Get addresses by postal code.
    /// Operation: GetAddressesByPostalCodes.
    /// Area: Addresses.
    /// </summary>
    [HttpGet("{postalCode}")]
    [ProducesResponseType(typeof(List<Address>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<ActionResult> GetAddressesByPostalCodes(
        GetAddressesByPostalCodesParameters parameters,
        [FromServices] IGetAddressesByPostalCodesHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);
}