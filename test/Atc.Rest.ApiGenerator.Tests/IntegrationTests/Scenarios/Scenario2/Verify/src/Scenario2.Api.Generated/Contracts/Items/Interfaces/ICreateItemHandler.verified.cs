//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Items;

/// <summary>
/// Domain Interface for RequestHandler.
/// Description: Create a new item.
/// Operation: CreateItem.
/// Area: Items.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface ICreateItemHandler
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<CreateItemResult> ExecuteAsync(CreateItemParameters parameters, CancellationToken cancellationToken = default);
}