﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestUnit.Task.NamespaceApi.Api.Tests.Endpoints.EventArgs;

[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetEventArgsHandlerStub : IGetEventArgsHandler
{
    public Task<GetEventArgsResult> ExecuteAsync(
        CancellationToken cancellationToken = default)
    {
        var data = new Fixture().Create<List<TestUnit.Task.NamespaceApi.Api.Generated.Contracts.EventArgs.EventArgs>>();

        return System.Threading.Tasks.Task.FromResult(GetEventArgsResult.Ok(data));
    }
}