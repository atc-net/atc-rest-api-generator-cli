﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestUnit.Task.NamespaceApi.Api.Generated.Contracts.TestUnits;

/// <summary>
/// Domain Interface for RequestHandler.
/// Description: List test units.
/// Operation: ListTestUnits.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IListTestUnitsHandler
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<ListTestUnitsResult> ExecuteAsync(
        ListTestUnitsParameters parameters,
        CancellationToken cancellationToken = default);
}