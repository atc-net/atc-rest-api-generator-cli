﻿global using System.CodeDom.Compiler;
global using System.Reflection;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Serialization;

global using Atc.Rest.Options;
global using Atc.XUnit;

global using ExampleWithNsWithTask.Api.Generated;
global using ExampleWithNsWithTask.Api.Generated.Contracts;
global using ExampleWithNsWithTask.Api.Generated.Contracts.EventArgs;
global using ExampleWithNsWithTask.Api.Generated.Contracts.Orders;
global using ExampleWithNsWithTask.Api.Generated.Contracts.TestUnits;

global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc.Testing;
global using Microsoft.AspNetCore.TestHost;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;