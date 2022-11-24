//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Endpoints;

/// <summary>
/// Endpoint definitions.
/// </summary>
[ApiController]
[Route("/api/v1/items")]
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class ItemsController : ControllerBase
{
    /// <summary>
    /// Description: Create a new item.
    /// Operation: CreateItem.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> CreateItem(
        CreateItemParameters parameters,
        [FromServices] ICreateItemHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);

    /// <summary>
    /// Description: Updates an item.
    /// Operation: UpdateItem.
    /// </summary>
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateItem(
        UpdateItemParameters parameters,
        [FromServices] IUpdateItemHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);
}