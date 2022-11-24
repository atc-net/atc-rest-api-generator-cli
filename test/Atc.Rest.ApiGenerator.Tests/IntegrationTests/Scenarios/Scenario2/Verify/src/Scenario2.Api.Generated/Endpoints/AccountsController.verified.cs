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
[Route("/api/v1/accounts")]
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class AccountsController : ControllerBase
{
    /// <summary>
    /// Description: Update name of account.
    /// Operation: UpdateAccountName.
    /// </summary>
    [HttpPut("{accountId}/name")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateAccountName(
        UpdateAccountNameParameters parameters,
        [FromServices] IUpdateAccountNameHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);

    /// <summary>
    /// Description: Set name of account.
    /// Operation: SetAccountName.
    /// </summary>
    [HttpPost("{accountId}/name")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> SetAccountName(
        SetAccountNameParameters parameters,
        [FromServices] ISetAccountNameHandler handler,
        CancellationToken cancellationToken)
        => await handler.ExecuteAsync(parameters, cancellationToken);
}