﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestUnit.Task.NamespaceApi.Api.Generated.Endpoints;

/// <summary>
/// Endpoint definitions.
/// </summary>
[Authorize]
[ApiController]
[Route("/api/v1/test-units")]
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class TestUnitsController : ControllerBase
{
    /// <summary>
    /// Description: List test units.
    /// Operation: ListTestUnits.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(PaginationResult<TestUnit.Task.NamespaceApi.Api.Generated.Contracts.TestUnits.TestUnit>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<ActionResult> ListTestUnits(
        ListTestUnitsParameters parameters,
        [FromServices] IListTestUnitsHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);
}