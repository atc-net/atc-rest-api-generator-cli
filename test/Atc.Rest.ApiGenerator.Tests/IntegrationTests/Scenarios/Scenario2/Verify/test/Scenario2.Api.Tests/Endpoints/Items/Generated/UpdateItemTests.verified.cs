﻿using System.CodeDom.Compiler;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Scenario2.Api.Generated.Contracts.Items;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Items.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    [Collection("Sequential-Endpoints")]
    public class UpdateItemTests : WebApiControllerBaseTest
    {
        public UpdateItemTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/items/77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task UpdateItem_Ok(string relativeRef)
        {
            // Arrange
            var data = new UpdateItemRequest
            {
                Item = new Item
                {
                    Name = "Hallo1",
                },
            };

            // Act
            var response = await HttpClient.PutAsync(relativeRef, ToJson(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Theory]
        [InlineData("/api/v1/items/x77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task UpdateItem_BadRequest_InPath(string relativeRef)
        {
            // Arrange
            var data = new UpdateItemRequest
            {
                Item = new Item
                {
                    Name = "Hallo1",
                },
            };

            // Act
            var response = await HttpClient.PutAsync(relativeRef, ToJson(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Theory]
        [InlineData("/api/v1/items/77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task UpdateItem_BadRequest_InBody_Item(string relativeRef)
        {
            // Arrange
            var sb = new StringBuilder();
            sb.AppendLine("{");
            sb.AppendLine("  \"Item\": null");
            sb.AppendLine("}");
            var data = sb.ToString();

            // Act
            var response = await HttpClient.PutAsync(relativeRef, Json(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}