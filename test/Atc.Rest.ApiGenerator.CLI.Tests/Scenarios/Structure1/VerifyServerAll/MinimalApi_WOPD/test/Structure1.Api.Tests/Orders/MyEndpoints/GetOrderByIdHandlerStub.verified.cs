﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Tests.Orders.MyEndpoints;

[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetOrderByIdHandlerStub : IGetOrderByIdHandler
{
    public Task<GetOrderByIdResult> ExecuteAsync(
        GetOrderByIdParameters parameters,
        CancellationToken cancellationToken = default)
    {
        var data = new Fixture().Create<Order>();

        return Task.FromResult(GetOrderByIdResult.Ok(data));
    }
}