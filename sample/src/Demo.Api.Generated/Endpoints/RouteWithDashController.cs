﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.197.51239.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Endpoints;

/// <summary>
/// Endpoint definitions.
/// Area: RouteWithDash.
/// </summary>
[ApiController]
[Route("/api/v1/route-with-dash")]
[GeneratedCode("ApiGenerator", "2.0.197.51239")]
public class RouteWithDashController : ControllerBase
{
    /// <summary>
    /// Description: Your GET endpoint.
    /// Operation: GetRouteWithDash.
    /// Area: RouteWithDash.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<ActionResult> GetRouteWithDash(
        [FromServices] IGetRouteWithDashHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(cancellationToken);
}