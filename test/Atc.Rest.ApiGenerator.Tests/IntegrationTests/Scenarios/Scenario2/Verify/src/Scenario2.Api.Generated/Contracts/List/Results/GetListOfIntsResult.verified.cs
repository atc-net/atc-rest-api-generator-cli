//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.List
{
    /// <summary>
    /// Results for operation request.
    /// Description: Your GET endpoint.
    /// Operation: GetListOfInts.
    /// Area: List.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class GetListOfIntsResult : ResultBase
    {
        private GetListOfIntsResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static GetListOfIntsResult Ok(IEnumerable<int> response) => new GetListOfIntsResult(new OkObjectResult(response ?? Enumerable.Empty<int>()));

        /// <summary>
        /// Performs an implicit conversion from GetListOfIntsResult to ActionResult.
        /// </summary>
        public static implicit operator GetListOfIntsResult(List<int> response) => Ok(response);
    }
}