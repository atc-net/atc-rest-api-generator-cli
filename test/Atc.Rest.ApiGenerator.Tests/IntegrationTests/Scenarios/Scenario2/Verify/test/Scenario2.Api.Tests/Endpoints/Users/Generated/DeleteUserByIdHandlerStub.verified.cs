﻿using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;
using Scenario2.Api.Generated.Contracts.Users;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Users.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class DeleteUserByIdHandlerStub : IDeleteUserByIdHandler
    {
        public Task<DeleteUserByIdResult> ExecuteAsync(DeleteUserByIdParameters parameters, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(DeleteUserByIdResult.Ok("Hallo world"));
        }
    }
}