//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Endpoints;

/// <summary>
/// Endpoint definitions.
/// Area: Orders.
/// </summary>
[ApiController]
[Route("/api/v1/orders")]
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class OrdersController : ControllerBase
{
    /// <summary>
    /// Description: Get orders.
    /// Operation: GetOrders.
    /// Area: Orders.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(Pagination<Order>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<ActionResult> GetOrders(
        GetOrdersParameters parameters,
        [FromServices] IGetOrdersHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);

    /// <summary>
    /// Description: Get order by id.
    /// Operation: GetOrderById.
    /// Area: Orders.
    /// </summary>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Order), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<ActionResult> GetOrderById(
        GetOrderByIdParameters parameters,
        [FromServices] IGetOrderByIdHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);

    /// <summary>
    /// Description: Update part of order by id.
    /// Operation: PatchOrdersId.
    /// Area: Orders.
    /// </summary>
    [HttpPatch("{id}")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(string), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status502BadGateway)]
    public async Task<ActionResult> PatchOrdersId(
        PatchOrdersIdParameters parameters,
        [FromServices] IPatchOrdersIdHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);
}