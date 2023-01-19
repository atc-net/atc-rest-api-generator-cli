//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.EventArgs;

/// <summary>
/// Domain Interface for RequestHandler.
/// Description: Get EventArgs By Id.
/// Operation: GetEventArgsById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetEventArgsByIdHandler
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<GetEventArgsByIdResult> ExecuteAsync(
        GetEventArgsByIdParameters parameters,
        CancellationToken cancellationToken = default);
}