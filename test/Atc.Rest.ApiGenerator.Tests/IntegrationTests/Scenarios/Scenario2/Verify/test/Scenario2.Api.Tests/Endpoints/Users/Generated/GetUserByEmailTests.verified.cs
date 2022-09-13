//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Users.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    [Collection("Sequential-Endpoints")]
    [Trait(Traits.Category, Traits.Categories.Integration)]
    public class GetUserByEmailTests : WebApiControllerBaseTest
    {
        public GetUserByEmailTests(WebApiStartupFactory fixture) : base(fixture) { }

        [Theory]
        [InlineData("/api/v1/users/email?email=john.doe@example.com")]
        public async Task GetUserByEmail_Ok(string relativeRef)
        {
            // Arrange

            // Act
            var response = await HttpClient.GetAsync(relativeRef);

            // Assert
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var responseData = await response.DeserializeAsync<User>(JsonSerializerOptions);
            responseData.Should().NotBeNull();
        }

        [Theory]
        [InlineData("/api/v1/users/email?email=john.doe_example.com")]
        public async Task GetUserByEmail_BadRequest_InQuery(string relativeRef)
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