using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts.Files;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.124.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Files.Generated
{
    [GeneratedCode("ApiGenerator", "1.1.124.0")]
    [Collection("Sequential-Endpoints")]
    public class UploadFileAsFormDataTests : WebApiControllerBaseTest
    {
        public UploadFileAsFormDataTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/files/form-data/single")]
        public async Task UploadFileAsFormData_Ok(string relativeRef)
        {
            // Arrange
            var data = new FileAsFormDataRequest
            {
                ItemName = "Hallo1",
                File = GetTestFile(),
                Items = new List<string>() { "1", "2" },
            };

            // Act
            var fileBytes = await data.File.GetBytes();
            var multipartFormDataContentFromRequest = await GetMultipartFormDataContentFromRequest(data, "test.html");
            var response = await HttpClient.PostAsync(relativeRef, multipartFormDataContentFromRequest);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        private async Task<MultipartFormDataContent> GetMultipartFormDataContentFromRequest(
            FileAsFormDataRequest request,
            string fileName)
        {
            var formDataContent = new MultipartFormDataContent();
            if (request.File is not null)
            {
                var bytesContent = new ByteArrayContent(await request.File.GetBytes());
                formDataContent.Add(bytesContent, "Request.File", fileName);
            }

            formDataContent.Add(new StringContent(request.ItemName), "Request.ItemName");

            if (request.Items.Any())
            {
                foreach (var item in request.Items)
                {
                    formDataContent.Add(new StringContent(item), "Request.Items");
                }
            }

            return formDataContent;
        }
    }
}