﻿namespace Structure1.Api.Tests.Addresses.MyEndpoints;

[Collection("Sequential-Endpoints")]
[Trait(Traits.Category, Traits.Categories.Integration)]
public class GetAddressesByPostalCodesTests : WebApiControllerBaseTest
{
    public GetAddressesByPostalCodesTests(WebApiStartupFactory fixture)
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