global using System.Net;
global using System.Text;

global using Atc.CodeDocumentation.CodeComment;
global using Atc.CodeGeneration.CSharp.Content;
global using Atc.CodeGeneration.CSharp.Content.Factories;
global using Atc.CodeGeneration.CSharp.Content.Generators;
global using Atc.CodeGeneration.CSharp.Extensions;
global using Atc.Rest.ApiGenerator.Contracts;
global using Atc.Rest.ApiGenerator.Contracts.ContentGeneratorsParameters;
global using Atc.Rest.ApiGenerator.Contracts.ContentGeneratorsParameters.Server;
global using Atc.Rest.ApiGenerator.Contracts.Extensions;
global using Atc.Rest.ApiGenerator.Contracts.Models;
global using Atc.Rest.ApiGenerator.Framework.ContentGenerators;
global using Atc.Rest.ApiGenerator.Framework.ContentGeneratorsParameters.Server;
global using Atc.Rest.ApiGenerator.Framework.Factories.Parameters.Server;
global using Atc.Rest.ApiGenerator.Framework.Factories.Parameters.ServerClient;
global using Atc.Rest.ApiGenerator.Framework.Factories.Server;
global using Atc.Rest.ApiGenerator.Framework.Helpers;
global using Atc.Rest.ApiGenerator.Framework.Minimal.Factories.Parameters.Server;
global using Atc.Rest.ApiGenerator.Framework.ProjectGenerator;
global using Atc.Rest.ApiGenerator.Framework.Providers;
global using Atc.Rest.ApiGenerator.Framework.Writers;
global using Atc.Rest.ApiGenerator.OpenApi.Extensions;

global using Microsoft.Extensions.Logging;
global using Microsoft.OpenApi.Models;