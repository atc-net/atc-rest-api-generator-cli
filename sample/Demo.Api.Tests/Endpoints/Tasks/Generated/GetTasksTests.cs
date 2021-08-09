﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts.Tasks;
using FluentAssertions;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.124.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Tasks.Generated
{
    [GeneratedCode("ApiGenerator", "1.1.124.0")]
    [Collection("Sequential-Endpoints")]
    public class GetTasksTests : WebApiControllerBaseTest
    {
        public GetTasksTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/tasks")]
        public async System.Threading.Tasks.Task GetTasks_Ok(string relativeRef)
        {
            // Act
            var response = await HttpClient.GetAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var responseData = await response.DeserializeAsync<List<Demo.Api.Generated.Contracts.Tasks.Task>>(JsonSerializerOptions);
            responseData.Should().NotBeNull();
        }
    }
}