//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Eventargs.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class GetEventArgsHandlerStub : IGetEventArgsHandler
    {
        public Task<GetEventArgsResult> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var data = new List<Scenario2.Api.Generated.Contracts.Eventargs.EventArgs>
            {
                new Scenario2.Api.Generated.Contracts.Eventargs.EventArgs
                {
                    Id = Guid.Parse("77a33260-0001-441f-ba60-b0a833803fab"),
                    EventName = "Hallo11",
                },
                new Scenario2.Api.Generated.Contracts.Eventargs.EventArgs
                {
                    Id = Guid.Parse("77a33260-0002-441f-ba60-b0a833803fab"),
                    EventName = "Hallo21",
                },
                new Scenario2.Api.Generated.Contracts.Eventargs.EventArgs
                {
                    Id = Guid.Parse("77a33260-0003-441f-ba60-b0a833803fab"),
                    EventName = "Hallo31",
                },
            };

            return Task.FromResult(GetEventArgsResult.Ok(data));
        }
    }
}