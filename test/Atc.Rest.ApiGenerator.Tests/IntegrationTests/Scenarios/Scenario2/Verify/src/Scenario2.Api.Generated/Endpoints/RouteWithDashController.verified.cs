//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Endpoints
{
    /// <summary>
    /// Endpoint definitions.
    /// Area: RouteWithDash.
    /// </summary>
    [ApiController]
    [Route("/api/v1/route-with-dash")]
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class RouteWithDashController : ControllerBase
    {
        /// <summary>
        /// Description: Your GET endpoint.
        /// Operation: GetRouteWithDash.
        /// Area: RouteWithDash.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public Task<ActionResult> GetRouteWithDashAsync([FromServices] IGetRouteWithDashHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeGetRouteWithDashAsync(handler, cancellationToken);
        }

        private static async Task<ActionResult> InvokeGetRouteWithDashAsync([FromServices] IGetRouteWithDashHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(cancellationToken);
        }
    }
}