﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.235.44759.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Tasks;

/// <summary>
/// Domain Interface for RequestHandler.
/// Description: Returns tasks.
/// Operation: GetTasks.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.235.44759")]
public interface IGetTasksHandler
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<GetTasksResult> ExecuteAsync(
        CancellationToken cancellationToken = default);
}