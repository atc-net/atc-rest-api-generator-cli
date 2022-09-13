//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario1.Api.Tests
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public abstract class WebApiControllerBaseTest : IClassFixture<WebApiStartupFactory>
    {
        protected readonly WebApiStartupFactory Factory;
        protected readonly HttpClient HttpClient;
        protected readonly IConfiguration Configuration;
        protected static JsonSerializerOptions JsonSerializerOptions;
        protected WebApiControllerBaseTest(WebApiStartupFactory fixture)
        {
            this.Factory = fixture;
            this.HttpClient = this.Factory.CreateClient();
            this.Configuration = new ConfigurationBuilder().Build();
            JsonSerializerOptions = new JsonSerializerOptions{PropertyNameCaseInsensitive = true, Converters = {new JsonStringEnumConverter()}, };
        }

        protected static StringContent ToJson(object data) => new StringContent(JsonSerializer.Serialize(data, JsonSerializerOptions), Encoding.UTF8, "application/json");
        protected static StringContent Json(string data) => new StringContent(data, Encoding.UTF8, "application/json");
        protected static IFormFile GetTestFile()
        {
            var bytes = Encoding.UTF8.GetBytes("Hello World");
            var stream = new MemoryStream(bytes);
            var formFile = new FormFile(stream, 0, stream.Length, null, "dummy.txt")
            {Headers = new HeaderDictionary(), ContentType = "application/octet-stream", };
            return formFile;
        }

        protected static List<IFormFile> GetTestFiles() => new List<IFormFile>{GetTestFile(), GetTestFile()};
    }
}