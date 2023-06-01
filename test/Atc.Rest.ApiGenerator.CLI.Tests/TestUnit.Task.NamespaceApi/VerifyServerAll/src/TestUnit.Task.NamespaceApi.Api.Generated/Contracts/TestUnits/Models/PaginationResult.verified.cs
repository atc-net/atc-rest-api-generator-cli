﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestUnit.Task.NamespaceApi.Api.Generated.Contracts.TestUnits;

/// <summary>
/// An item result subset of a data query.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PaginationResult<T>
{
    public int PageSize { get; set; }

    /// <summary>
    /// Token to indicate next result set.
    /// </summary>
    public string? ContinuationToken { get; set; }

    public List<T> Results { get; set; } = new List<T>();

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(PageSize)}: {PageSize}, {nameof(ContinuationToken)}: {ContinuationToken}, {nameof(Results)}.Count: {Results?.Count ?? 0}";
}