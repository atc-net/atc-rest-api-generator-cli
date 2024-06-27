//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.Tasks.Interfaces;

/// <summary>
/// Interface for Client Endpoint.
/// Description: Returns tasks.
/// Operation: GetTasks.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IGetTasksEndpoint
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="httpClientName">The http client name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<GetTasksEndpointResult> ExecuteAsync(
        string httpClientName = "DemoSample-ApiClient",
        CancellationToken cancellationToken = default);
}
