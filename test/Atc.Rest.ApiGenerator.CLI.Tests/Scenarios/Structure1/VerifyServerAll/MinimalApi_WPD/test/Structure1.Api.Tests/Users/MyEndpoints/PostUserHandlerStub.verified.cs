﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Tests.Users.MyEndpoints;

[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PostUserHandlerStub : IPostUserHandler
{
    public Task<PostUserResult> ExecuteAsync(
        PostUserParameters parameters,
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(PostUserResult.Created());
    }
}