﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.259.29354.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Tasks;

/// <summary>
/// Contains a list of Tasks.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.259.29354")]
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