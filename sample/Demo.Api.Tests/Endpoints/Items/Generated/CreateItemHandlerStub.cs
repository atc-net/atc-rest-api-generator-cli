﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.124.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Items.Generated
{
    using Demo.Api.Generated.Contracts;
    using Demo.Api.Generated.Contracts.Items;

    [GeneratedCode("ApiGenerator", "1.1.124.0")]
    public class CreateItemHandlerStub : ICreateItemHandler
    {
        public Task<CreateItemResult> ExecuteAsync(CreateItemParameters parameters, CancellationToken cancellationToken = default)
        {
            return System.Threading.Tasks.Task.FromResult(CreateItemResult.Ok("Hallo world"));
        }
    }
}