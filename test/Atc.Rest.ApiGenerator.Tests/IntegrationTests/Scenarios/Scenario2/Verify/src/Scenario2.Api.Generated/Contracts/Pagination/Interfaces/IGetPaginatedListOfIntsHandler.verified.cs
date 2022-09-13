//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Pagination
{
    /// <summary>
    /// Domain Interface for RequestHandler.
    /// Description: Your GET endpoint.
    /// Operation: GetPaginatedListOfInts.
    /// Area: Pagination.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public interface IGetPaginatedListOfIntsHandler
    {
        /// <summary>
        /// Execute method.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        Task<GetPaginatedListOfIntsResult> ExecuteAsync(CancellationToken cancellationToken = default);
    }
}