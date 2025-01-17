global using System.ComponentModel.DataAnnotations;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.Net;
global using System.Net.Mime;
global using System.Text;

global using Atc.CodeDocumentation.CodeComment;
global using Atc.CodeGeneration.CSharp.Extensions;
global using Atc.Data.Models;
global using Atc.Rest.ApiGenerator.Contracts;
global using Atc.Rest.ApiGenerator.Contracts.ContentGeneratorsParameters.Server;
global using Atc.Rest.ApiGenerator.Contracts.Models;
global using Atc.Rest.ApiGenerator.Contracts.Options;
global using Atc.Rest.ApiGenerator.OpenApi.Extensions;
global using Atc.Rest.ApiGenerator.OpenApi.Extractors;
global using Atc.Rest.ApiGenerator.OpenApi.Factories;
global using Atc.Rest.ApiGenerator.OpenApi.Models;

global using Microsoft.Extensions.Logging;
global using Microsoft.OpenApi;
global using Microsoft.OpenApi.Any;
global using Microsoft.OpenApi.Interfaces;
global using Microsoft.OpenApi.Models;
global using Microsoft.OpenApi.Readers;