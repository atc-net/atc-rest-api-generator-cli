//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace ExNsWithTask.Api.Tests.Endpoints.EventArgs;

[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetEventArgByIdHandlerStub : IGetEventArgByIdHandler
{
    public Task<GetEventArgByIdResult> ExecuteAsync(
        GetEventArgByIdParameters parameters,
        CancellationToken cancellationToken = default)
    {
        var data = new Fixture().Create<ExNsWithTask.Api.Generated.Contracts.EventArgs.EventArgs>();

        return Task.FromResult(GetEventArgByIdResult.Ok(data));
    }
}