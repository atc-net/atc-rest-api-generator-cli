﻿using System;
using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts;
using Demo.Api.Generated.Contracts.Orders;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.124.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Orders.Generated
{
    [GeneratedCode("ApiGenerator", "1.1.124.0")]
    public class PatchOrdersIdHandlerStub : IPatchOrdersIdHandler
    {
        public Task<PatchOrdersIdResult> ExecuteAsync(PatchOrdersIdParameters parameters, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(PatchOrdersIdResult.Ok("Hallo world"));
        }
    }
}