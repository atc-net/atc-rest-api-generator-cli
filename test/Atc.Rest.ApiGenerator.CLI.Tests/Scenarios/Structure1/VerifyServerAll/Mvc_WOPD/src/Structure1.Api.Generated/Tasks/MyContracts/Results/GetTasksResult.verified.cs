﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Tasks.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Returns tasks.
/// Operation: GetTasks.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetTasksResult : ResultBase
{
    private GetTasksResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetTasksResult Ok(IEnumerable<Task> response)
        => new GetTasksResult(new OkObjectResult(response ?? Enumerable.Empty<Task>()));

    /// <summary>
    /// Performs an implicit conversion from GetTasksResult to ActionResult.
    /// </summary>
    public static implicit operator GetTasksResult(List<Task> response)
        => Ok(response);
}