﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Tasks.MyContracts;

/// <summary>
/// Contains a list of Tasks.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Tasks
{
    /// <summary>
    /// A list of Task.
    /// </summary>
    public List<Task> TaskList { get; set; } = new List<Task>();

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(TaskList)}.Count: {TaskList?.Count ?? 0}";
}