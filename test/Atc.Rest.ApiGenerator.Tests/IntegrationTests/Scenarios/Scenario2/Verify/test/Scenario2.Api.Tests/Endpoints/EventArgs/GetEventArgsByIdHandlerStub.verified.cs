//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.EventArgs;

[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetEventArgsByIdHandlerStub : IGetEventArgsByIdHandler
{
    public Task<GetEventArgsByIdResult> ExecuteAsync(
        GetEventArgsByIdParameters parameters,
        CancellationToken cancellationToken = default)
    {
        var data = new Fixture().Create<Scenario2.Api.Generated.Contracts.EventArgs.EventArgs>();

        return Task.FromResult(GetEventArgsByIdResult.Ok(data));
    }
}