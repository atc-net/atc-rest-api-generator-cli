//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Pagination;

[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetPaginatedListOfIntsHandlerStub : IGetPaginatedListOfIntsHandler
{
    public Task<GetPaginatedListOfIntsResult> ExecuteAsync(
        CancellationToken cancellationToken = default)
    {
        var data = new Fixture().Create<List<int>>();

        var paginationData = new Pagination<int>(
            data,
            pageSize: 10,
            queryString: null,
            continuationToken: null);

        return Task.FromResult(GetPaginatedListOfIntsResult.Ok(paginationData));
    }
}