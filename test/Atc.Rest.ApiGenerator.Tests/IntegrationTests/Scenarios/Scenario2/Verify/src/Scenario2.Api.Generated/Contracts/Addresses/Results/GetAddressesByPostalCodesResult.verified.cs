//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Addresses
{
    /// <summary>
    /// Results for operation request.
    /// Description: Get addresses by postal code.
    /// Operation: GetAddressesByPostalCodes.
    /// Area: Addresses.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class GetAddressesByPostalCodesResult : ResultBase
    {
        private GetAddressesByPostalCodesResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static GetAddressesByPostalCodesResult Ok(IEnumerable<Address> response) => new GetAddressesByPostalCodesResult(new OkObjectResult(response ?? Enumerable.Empty<Address>()));

        /// <summary>
        /// 404 - NotFound response.
        /// </summary>
        public static GetAddressesByPostalCodesResult NotFound(string? message = null) => new GetAddressesByPostalCodesResult(new NotFoundObjectResult(message));

        /// <summary>
        /// Performs an implicit conversion from GetAddressesByPostalCodesResult to ActionResult.
        /// </summary>
        public static implicit operator GetAddressesByPostalCodesResult(List<Address> response) => Ok(response);
    }
}