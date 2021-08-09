﻿using System.CodeDom.Compiler;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts;
using Demo.Api.Generated.Contracts.Users;
using FluentAssertions;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.124.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Users.Generated
{
    [GeneratedCode("ApiGenerator", "1.1.124.0")]
    [Collection("Sequential-Endpoints")]
    public class GetUserByIdTests : WebApiControllerBaseTest
    {
        public GetUserByIdTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/users/77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task GetUserById_Ok(string relativeRef)
        {
            // Act
            var response = await HttpClient.GetAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var responseData = await response.DeserializeAsync<User>(JsonSerializerOptions);
            responseData.Should().NotBeNull();
        }

        [Theory]
        [InlineData("/api/v1/users/x77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task GetUserById_BadRequest_InPath(string relativeRef)
        {
            // Act
            var response = await HttpClient.GetAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}