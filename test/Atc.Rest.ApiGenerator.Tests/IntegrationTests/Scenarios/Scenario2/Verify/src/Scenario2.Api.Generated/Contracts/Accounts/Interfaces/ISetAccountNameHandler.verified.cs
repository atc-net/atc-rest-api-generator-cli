//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Accounts;

/// <summary>
/// Domain Interface for RequestHandler.
/// Description: Set name of account.
/// Operation: SetAccountName.
/// Area: Accounts.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface ISetAccountNameHandler
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<SetAccountNameResult> ExecuteAsync(SetAccountNameParameters parameters, CancellationToken cancellationToken = default);
}