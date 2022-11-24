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
[Route("/api/v1/tasks")]
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class TasksController : ControllerBase
{
    /// <summary>
    /// Description: Returns tasks.
    /// Operation: GetTasks.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(List<Scenario2.Api.Generated.Contracts.Tasks.Task>), StatusCodes.Status200OK)]
    public async Task<ActionResult> GetTasks(
        [FromServices] IGetTasksHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(cancellationToken);
}