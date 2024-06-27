//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExGenericPagination.Api.Generated.Contracts.Dogs;

/// <summary>
/// Results for operation request.
/// Description: Find all dogs.
/// Operation: GetDogs.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetDogsResult : ResultBase
{
    private GetDogsResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetDogsResult Ok(PaginatedResult<Dog> response)
        => new GetDogsResult(new OkObjectResult(response));

    /// <summary>
    /// Performs an implicit conversion from GetDogsResult to ActionResult.
    /// </summary>
    public static implicit operator GetDogsResult(PaginatedResult<Dog> response)
        => Ok(response);
}
