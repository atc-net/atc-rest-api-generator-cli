﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.405.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Orders.Generated
{
    [GeneratedCode("ApiGenerator", "1.1.405.0")]
    [Collection("Sequential-Endpoints")]
    [Trait(Traits.Category, Traits.Categories.Integration)]
    public class PatchOrdersIdTests : WebApiControllerBaseTest
    {
        public PatchOrdersIdTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/orders/77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task PatchOrdersId_Ok(string relativeRef)
        {
            // Arrange
            HttpClient.DefaultRequestHeaders.Add("myTestHeader", "Hallo");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderBool", "true");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderInt", "42");

            var data = new UpdateOrderRequest
            {
                MyEmail = "john.doe@example.com",
            };

            // Act
            var response = await HttpClient.PatchAsync(relativeRef, ToJson(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Theory]
        [InlineData("/api/v1/orders/x77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task PatchOrdersId_BadRequest_InPath(string relativeRef)
        {
            // Arrange
            HttpClient.DefaultRequestHeaders.Add("myTestHeader", "Hallo");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderBool", "true");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderInt", "42");

            var data = new UpdateOrderRequest
            {
                MyEmail = "john.doe@example.com",
            };

            // Act
            var response = await HttpClient.PatchAsync(relativeRef, ToJson(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Theory]
        [InlineData("/api/v1/orders/77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task PatchOrdersId_BadRequest_InHeader_MyTestHeaderBool(string relativeRef)
        {
            // Arrange
            HttpClient.DefaultRequestHeaders.Add("myTestHeader", "Hallo");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderBool", "@");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderInt", "42");

            var data = new UpdateOrderRequest
            {
                MyEmail = "john.doe@example.com",
            };

            // Act
            var response = await HttpClient.PatchAsync(relativeRef, ToJson(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Theory]
        [InlineData("/api/v1/orders/77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task PatchOrdersId_BadRequest_InHeader_MyTestHeaderInt(string relativeRef)
        {
            // Arrange
            HttpClient.DefaultRequestHeaders.Add("myTestHeader", "Hallo");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderBool", "true");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderInt", "@");

            var data = new UpdateOrderRequest
            {
                MyEmail = "john.doe@example.com",
            };

            // Act
            var response = await HttpClient.PatchAsync(relativeRef, ToJson(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Theory]
        [InlineData("/api/v1/orders/77a33260-0000-441f-ba60-b0a833803fab")]
        public async Task PatchOrdersId_BadRequest_InBody_MyEmail(string relativeRef)
        {
            // Arrange
            HttpClient.DefaultRequestHeaders.Add("myTestHeader", "Hallo");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderBool", "true");
            HttpClient.DefaultRequestHeaders.Add("myTestHeaderInt", "42");

            var sb = new StringBuilder();
            sb.AppendLine("{");
            sb.AppendLine("  \"MyEmail\": \"john.doe_example.com\"");
            sb.AppendLine("}");
            var data = sb.ToString();

            // Act
            var response = await HttpClient.PatchAsync(relativeRef, Json(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}