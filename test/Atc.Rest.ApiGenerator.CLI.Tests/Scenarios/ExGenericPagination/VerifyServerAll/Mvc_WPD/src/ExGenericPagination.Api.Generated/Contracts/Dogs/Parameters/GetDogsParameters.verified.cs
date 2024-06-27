//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExGenericPagination.Api.Generated.Contracts.Dogs;

/// <summary>
/// Parameters for operation request.
/// Description: Find all dogs.
/// Operation: GetDogs.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetDogsParameters
{
    [FromQuery(Name = "pageSize")]
    [Required]
    public int PageSize { get; set; } = 10;

    [FromQuery(Name = "pageIndex")]
    [Required]
    public int PageIndex { get; set; } = 0;

    [FromQuery(Name = "queryString")]
    [Required]
    public string QueryString { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(PageSize)}: {PageSize}, {nameof(PageIndex)}: {PageIndex}, {nameof(QueryString)}: {QueryString}";
}
