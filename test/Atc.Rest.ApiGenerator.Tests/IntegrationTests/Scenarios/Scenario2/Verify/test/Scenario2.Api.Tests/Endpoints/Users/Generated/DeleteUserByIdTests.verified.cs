﻿using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Users.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    [Collection("Sequential-Endpoints")]
    public class DeleteUserByIdTests : WebApiControllerBaseTest
    {
        public DeleteUserByIdTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/users/77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task DeleteUserById_Ok(string relativeRef)
        {
            // Act
            var response = await HttpClient.DeleteAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Theory]
        [InlineData("/api/v1/users/x77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task DeleteUserById_BadRequest_InPath(string relativeRef)
        {
            // Act
            var response = await HttpClient.DeleteAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}