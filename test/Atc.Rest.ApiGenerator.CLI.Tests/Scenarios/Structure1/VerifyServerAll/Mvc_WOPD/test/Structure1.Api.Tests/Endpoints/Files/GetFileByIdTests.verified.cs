﻿namespace Structure1.Api.Tests.Files.MyEndpoints;

[Collection("Sequential-Endpoints")]
[Trait(Traits.Category, Traits.Categories.Integration)]
public class GetFileByIdTests : WebApiControllerBaseTest
{
    public GetFileByIdTests(WebApiStartupFactory fixture)
        : base(fixture)
    {
    }

    [Fact(Skip = "Change this to a real integration-test")]
    public void Sample()
    {
        // Arrange

        // Act

        // Assert
    }
}