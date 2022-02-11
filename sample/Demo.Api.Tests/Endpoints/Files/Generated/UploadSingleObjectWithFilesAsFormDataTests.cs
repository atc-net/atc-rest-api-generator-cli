﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts.Files;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.0.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Files.Generated
{
    [GeneratedCode("ApiGenerator", "2.0.0.0")]
    [Collection("Sequential-Endpoints")]
    public class UploadSingleObjectWithFilesAsFormDataTests : WebApiControllerBaseTest
    {
        public UploadSingleObjectWithFilesAsFormDataTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/files/form-data/singleObjectMultiFile")]
        public async Task UploadSingleObjectWithFilesAsFormData_Ok(string relativeRef)
        {
            // Arrange
            var data = new FilesAsFormDataRequest
            {
                Files = GetTestFiles(),
            };

            // Act
            var response = await HttpClient.PostAsync(relativeRef, await GetMultipartFormDataContentFromFilesAsFormDataRequest(data));

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        private async Task<MultipartFormDataContent> GetMultipartFormDataContentFromFilesAsFormDataRequest(FilesAsFormDataRequest request)
        {
            var formDataContent = new MultipartFormDataContent();
            if (request.Files is not null)
            {
                foreach (var item in request.Files)
                {
                    var bytesContent = new ByteArrayContent(await item.GetBytes());
                    formDataContent.Add(bytesContent, "Request.Files", item.FileName);
                }
            }

            return formDataContent;
        }
    }
}