//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.259.29354.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.EventArgs.Generated
{
    [GeneratedCode("ApiGenerator", "2.0.259.29354")]
    [Collection("Sequential-Endpoints")]
    [Trait(Traits.Category, Traits.Categories.Integration)]
    public class GetEventArgByIdTests : WebApiControllerBaseTest
    {
        public GetEventArgByIdTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/eventArgs/27")]
        public async Task GetEventArgById_Ok(string relativeRef)
        {
            // Act
            var response = await HttpClient.GetAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var responseData = await response.DeserializeAsync<Demo.Api.Generated.Contracts.EventArgs.EventArgs>(JsonSerializerOptions);
            responseData.Should().NotBeNull();
        }
    }
}