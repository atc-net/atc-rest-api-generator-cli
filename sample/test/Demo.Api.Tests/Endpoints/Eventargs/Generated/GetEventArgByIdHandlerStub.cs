﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.405.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Eventargs.Generated
{
    [GeneratedCode("ApiGenerator", "1.1.405.0")]
    public class GetEventArgByIdHandlerStub : IGetEventArgByIdHandler
    {
        public Task<GetEventArgByIdResult> ExecuteAsync(GetEventArgByIdParameters parameters, CancellationToken cancellationToken = default)
        {
            var data = new Demo.Api.Generated.Contracts.Eventargs.EventArgs
            {
                Id = Guid.Parse("77a33260-0000-441f-ba60-b0a833803fab"),
                EventName = "Hallo1",
            };

            return Task.FromResult(GetEventArgByIdResult.Ok(data));
        }
    }
}