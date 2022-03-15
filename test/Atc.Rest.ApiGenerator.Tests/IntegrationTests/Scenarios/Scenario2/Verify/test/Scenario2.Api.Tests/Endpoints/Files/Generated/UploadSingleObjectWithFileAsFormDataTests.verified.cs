using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Atc.XUnit;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Scenario2.Api.Generated.Contracts.Files;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Files.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    [Collection("Sequential-Endpoints")]
    [Trait(Traits.Category, Traits.Categories.Integration)]
    public class UploadSingleObjectWithFileAsFormDataTests : WebApiControllerBaseTest
    {
        public UploadSingleObjectWithFileAsFormDataTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/files/form-data/singleObject")]
        public async Task UploadSingleObjectWithFileAsFormData_Ok(string relativeRef)
        {
            // Arrange
            var data = new FileAsFormDataRequest
            {
                ItemName = "Hallo1",
                File = GetTestFile(),
                Items = new List<string>() { "Hallo", "World" },
            };

            // Act
            var response = await HttpClient.PostAsync(relativeRef, await GetMultipartFormDataContentFromFileAsFormDataRequest(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        private async Task<MultipartFormDataContent> GetMultipartFormDataContentFromFileAsFormDataRequest(FileAsFormDataRequest request)
        {
            var formDataContent = new MultipartFormDataContent();
            formDataContent.Add(new StringContent(request.ItemName), "Request.ItemName");
            if (request.File is not null)
            {
                var bytesContent = new ByteArrayContent(await request.File.GetBytes());
                formDataContent.Add(bytesContent, "Request.File", request.File.FileName);
            }

            if (request.Items is not null && request.Items.Count > 0)
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