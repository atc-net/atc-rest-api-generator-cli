﻿using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts.Items;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.117.17009.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Items.Generated
{
    [GeneratedCode("ApiGenerator", "2.0.117.17009")]
    public class UpdateItemHandlerStub : IUpdateItemHandler
    {
        public Task<UpdateItemResult> ExecuteAsync(UpdateItemParameters parameters, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(UpdateItemResult.Ok(System.Guid.NewGuid()));
        }
    }
}