﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Contracts;

/// <summary>
/// UpdateAccountRequest.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateAccountRequest
{
    public string Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}";
}