﻿namespace Structure1.Api.Tests.Orders.MyEndpoints;

[Collection("Sequential-Endpoints")]
[Trait(Traits.Category, Traits.Categories.Integration)]
public class GetOrderByIdTests : WebApiControllerBaseTest
{
    public GetOrderByIdTests(WebApiStartupFactory fixture)
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