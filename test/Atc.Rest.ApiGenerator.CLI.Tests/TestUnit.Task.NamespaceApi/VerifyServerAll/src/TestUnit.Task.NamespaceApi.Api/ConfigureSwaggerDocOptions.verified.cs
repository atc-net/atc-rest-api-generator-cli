﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestUnit.Task.NamespaceApi.Api;

[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class ConfigureSwaggerDocOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider provider;

    public ConfigureSwaggerDocOptions(
        IApiVersionDescriptionProvider provider)
        => this.provider = provider;

    public void Configure(
        SwaggerGenOptions options)
    {
        foreach (var version in provider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(
                version.GroupName,
                new OpenApiInfo
                {
                    Version = "1.0",
                    Title = "TestUnit Task Namespace Api",
                    Description = @"TestUnit Task Namespace Api - SingleFileVersion",
                    Contact = new OpenApiContact
                    {
                        Name = "atc-net A/S",
                    },
                });
        }

        options.IncludeXmlComments(Path.ChangeExtension(GetType().Assembly.Location, "xml"));
    }
}