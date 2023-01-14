//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.259.29354.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.EventArgs;

/// <summary>
/// Results for operation request.
/// Description: Get EventArgs List.
/// Operation: GetEventArgs.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.259.29354")]
public class GetEventArgsResult : ResultBase
{
    private GetEventArgsResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetEventArgsResult Ok(IEnumerable<EventArgs> response)
        => new GetEventArgsResult(new OkObjectResult(response ?? Enumerable.Empty<EventArgs>()));

    /// <summary>
    /// Performs an implicit conversion from GetEventArgsResult to ActionResult.
    /// </summary>
    public static implicit operator GetEventArgsResult(List<EventArgs> response)
        => Ok(response);
}