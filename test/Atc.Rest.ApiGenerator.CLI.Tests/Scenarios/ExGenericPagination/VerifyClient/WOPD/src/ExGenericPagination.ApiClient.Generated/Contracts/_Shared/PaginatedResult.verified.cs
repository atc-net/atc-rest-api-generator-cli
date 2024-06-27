//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExGenericPagination.ApiClient.Generated.Contracts;

/// <summary>
/// PaginatedResult.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PaginatedResult<T>
{
    public int PageSize { get; set; } = 10;

    public int PageIndex { get; set; }

    public string? QueryString { get; set; }

    public string? ContinuationToken { get; set; }

    public int Count { get; set; }

    public int TotalCount { get; set; }

    public List<T> Results { get; set; } = new List<T>();

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(PageSize)}: {PageSize}, {nameof(PageIndex)}: {PageIndex}, {nameof(QueryString)}: {QueryString}, {nameof(ContinuationToken)}: {ContinuationToken}, {nameof(Count)}: {Count}, {nameof(TotalCount)}: {TotalCount}, {nameof(Results)}.Count: {Results?.Count ?? 0}";
}
