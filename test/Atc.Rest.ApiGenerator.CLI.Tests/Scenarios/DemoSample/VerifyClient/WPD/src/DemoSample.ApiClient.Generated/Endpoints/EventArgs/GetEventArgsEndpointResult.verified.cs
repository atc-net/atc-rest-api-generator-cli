//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.EventArgs;

/// <summary>
/// Client Endpoint result.
/// Description: Get EventArgs List.
/// Operation: GetEventArgs.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetEventArgsEndpointResult : EndpointResponse, IGetEventArgsEndpointResult
{
    public GetEventArgsEndpointResult(EndpointResponse response)
        : base(response)
    {
    }

    public bool IsOk
        => StatusCode == HttpStatusCode.OK;

    public bool IsUnauthorized
        => StatusCode == HttpStatusCode.Unauthorized;

    public IEnumerable<EventArgs> OkContent
        => IsOk && ContentObject is IEnumerable<EventArgs> result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsOk property first.");

    public ProblemDetails UnauthorizedContent
        => IsUnauthorized && ContentObject is ProblemDetails result
            ? result
            : throw new InvalidOperationException("Content is not the expected type - please use the IsUnauthorized property first.");
}
