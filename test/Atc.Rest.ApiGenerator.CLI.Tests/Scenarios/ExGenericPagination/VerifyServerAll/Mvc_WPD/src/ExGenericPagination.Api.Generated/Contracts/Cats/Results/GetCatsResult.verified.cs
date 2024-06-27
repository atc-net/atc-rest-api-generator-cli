//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExGenericPagination.Api.Generated.Contracts.Cats;

/// <summary>
/// Results for operation request.
/// Description: Find all cats.
/// Operation: GetCats.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetCatsResult : ResultBase
{
    private GetCatsResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetCatsResult Ok(PaginatedResult<Cat> response)
        => new GetCatsResult(new OkObjectResult(response));

    /// <summary>
    /// Performs an implicit conversion from GetCatsResult to ActionResult.
    /// </summary>
    public static implicit operator GetCatsResult(PaginatedResult<Cat> response)
        => Ok(response);
}
