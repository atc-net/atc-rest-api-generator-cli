﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using System.IO;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Scenario2.Api
{
    public class ConfigureSwaggerDocOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider provider;

        public ConfigureSwaggerDocOptions(IApiVersionDescriptionProvider provider)
            => this.provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var version in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    version.GroupName,
                    new OpenApiInfo
                    {
                        Version = "1.0",
                        Title = "Demo Api",
                        Description = @"Demo Api - SingleFileVersion",
                        Contact = new OpenApiContact
                        {
                            Name = "atc-net A/S",
                            Email = null,
                        },
                        License = new OpenApiLicense
                        {
                            Name = null,
                        },
                    });
            }

            options.IncludeXmlComments(Path.ChangeExtension(GetType().Assembly.Location, "xml"));
        }
    }
}