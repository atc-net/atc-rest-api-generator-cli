﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExNsWithTask.ApiClient.Generated.Endpoints.Tasks.Interfaces;

/// <summary>
/// Interface for Client Endpoint Result.
/// Description: Returns tasks.
/// Operation: GetTasks.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetTasksEndpointResult : IEndpointResponse
{

    bool IsOk { get; }

    bool IsUnauthorized { get; }

    IEnumerable<ExNsWithTask.ApiClient.Generated.Contracts.Tasks.Task> OkContent { get; }

    ProblemDetails UnauthorizedContent { get; }
}