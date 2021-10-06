﻿using System.CodeDom.Compiler;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Scenario2.Api.Generated.Contracts.Accounts;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Accounts.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    [Collection("Sequential-Endpoints")]
    public class SetAccountNameTests : WebApiControllerBaseTest
    {
        public SetAccountNameTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/accounts/77a33260-0000-441f-ba60-b0a833803fab/name")]
        public async Task SetAccountName_Ok(string relativeRef)
        {
            // Arrange
            var data = new UpdateAccountRequest
            {
                Name = "Hallo1",
            };

            // Act
            var response = await HttpClient.PostAsync(relativeRef, ToJson(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Theory]
        [InlineData("/api/v1/accounts/x77a33260-0000-441f-ba60-b0a833803fab/name")]
        public async Task SetAccountName_BadRequest_InPath(string relativeRef)
        {
            // Arrange
            var data = new UpdateAccountRequest
            {
                Name = "Hallo1",
            };

            // Act
            var response = await HttpClient.PostAsync(relativeRef, ToJson(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}