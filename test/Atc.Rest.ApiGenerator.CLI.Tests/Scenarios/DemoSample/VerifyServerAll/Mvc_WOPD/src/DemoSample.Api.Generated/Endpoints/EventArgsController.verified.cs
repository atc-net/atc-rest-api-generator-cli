﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.Api.Generated.Endpoints;

/// <summary>
/// Endpoint definitions.
/// </summary>
[ApiController]
[Route("/api/v1/eventArgs")]
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public sealed class EventArgsController : ControllerBase
{
    /// <summary>
    /// Description: Get EventArgs List.
    /// Operation: GetEventArgs.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Contracts.EventArgs.EventArgs>), StatusCodes.Status200OK)]
    public async Task<ActionResult> GetEventArgs(
        [FromServices] IGetEventArgsHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(cancellationToken);

    /// <summary>
    /// Description: Get EventArgs By Id.
    /// Operation: GetEventArgById.
    /// </summary>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Contracts.EventArgs.EventArgs), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<ActionResult> GetEventArgById(
        GetEventArgByIdParameters parameters,
        [FromServices] IGetEventArgByIdHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);
}