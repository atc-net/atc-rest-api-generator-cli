﻿using System.CodeDom.Compiler;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Atc.Rest.Results;
using FluentAssertions;
using Scenario2.Api.Generated.Contracts.Orders;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Orders.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    [Collection("Sequential-Endpoints")]
    public class GetOrdersTests : WebApiControllerBaseTest
    {
        public GetOrdersTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/orders?pageSize=42")]
        [InlineData("/api/v1/orders?pageSize=42&pageIndex=42")]
        [InlineData("/api/v1/orders?pageSize=42&queryString=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&pageIndex=42&queryString=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&queryStringArray=Hallo&queryStringArray=Hallo1&queryStringArray=Hallo2")]
        [InlineData("/api/v1/orders?pageSize=42&pageIndex=42&queryStringArray=Hallo&queryStringArray=Hallo1&queryStringArray=Hallo2")]
        [InlineData("/api/v1/orders?pageSize=42&queryString=Hallo&queryStringArray=Hallo&queryStringArray=Hallo1&queryStringArray=Hallo2")]
        [InlineData("/api/v1/orders?pageSize=42&pageIndex=42&queryString=Hallo&queryStringArray=Hallo&queryStringArray=Hallo1&queryStringArray=Hallo2")]
        [InlineData("/api/v1/orders?pageSize=42&continuationToken=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&pageIndex=42&continuationToken=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&queryString=Hallo&continuationToken=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&pageIndex=42&queryString=Hallo&continuationToken=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&queryStringArray=Hallo&queryStringArray=Hallo1&queryStringArray=Hallo2&continuationToken=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&pageIndex=42&queryStringArray=Hallo&queryStringArray=Hallo1&queryStringArray=Hallo2&continuationToken=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&queryString=Hallo&queryStringArray=Hallo&queryStringArray=Hallo1&queryStringArray=Hallo2&continuationToken=Hallo")]
        [InlineData("/api/v1/orders?pageSize=42&pageIndex=42&queryString=Hallo&queryStringArray=Hallo&queryStringArray=Hallo1&queryStringArray=Hallo2&continuationToken=Hallo")]
        public async Task GetOrders_Ok(string relativeRef)
        {
            // Arrange

            // Act
            var response = await HttpClient.GetAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var responseData = await response.DeserializeAsync<Pagination<Order>>(JsonSerializerOptions);
            responseData.Should().NotBeNull();
        }

        [Theory]
        [InlineData("/api/v1/orders?pageSize=@")]
        public async Task GetOrders_BadRequest_InQuery(string relativeRef)
        {
            // Arrange

            // Act
            var response = await HttpClient.GetAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}