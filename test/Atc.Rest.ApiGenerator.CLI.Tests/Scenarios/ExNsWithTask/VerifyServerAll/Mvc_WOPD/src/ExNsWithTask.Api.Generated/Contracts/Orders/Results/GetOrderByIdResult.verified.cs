//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExNsWithTask.Api.Generated.Contracts.Orders;

/// <summary>
/// Results for operation request.
/// Description: Get order by id.
/// Operation: GetOrderById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetOrderByIdResult : ResultBase
{
    private GetOrderByIdResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetOrderByIdResult Ok(Order response)
        => new GetOrderByIdResult(new OkObjectResult(response));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static GetOrderByIdResult NotFound(string? message = null)
        => new GetOrderByIdResult(new NotFoundObjectResult(message));

    /// <summary>
    /// Performs an implicit conversion from GetOrderByIdResult to ActionResult.
    /// </summary>
    public static implicit operator GetOrderByIdResult(Order response)
        => Ok(response);
}
