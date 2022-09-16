//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Pagination;

/// <summary>
/// Results for operation request.
/// Description: Your GET endpoint.
/// Operation: GetPaginatedListOfStrings.
/// Area: Pagination.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetPaginatedListOfStringsResult : ResultBase
{
    private GetPaginatedListOfStringsResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetPaginatedListOfStringsResult Ok(Pagination<string> response) => new GetPaginatedListOfStringsResult(new OkObjectResult(response));

    /// <summary>
    /// Performs an implicit conversion from GetPaginatedListOfStringsResult to ActionResult.
    /// </summary>
    public static implicit operator GetPaginatedListOfStringsResult(Pagination<string> response) => Ok(response);
}