﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.Currencies;

/// <summary>
/// Parameters for operation request.
/// Description: Retrieve a list of currencies.
/// Operation: GetCurrencies.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetCurrenciesParameters
{
    /// <summary>
    /// page number to retrieve (starts with 0).
    /// </summary>
    public int Page { get; set; } = 0;

    /// <summary>
    /// number of items per page (between 1 and 100, default 10).
    /// </summary>
    public int PerPage { get; set; } = 10;

    public string? Identifier { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Page)}: {Page}, {nameof(PerPage)}: {PerPage}, {nameof(Identifier)}: {Identifier}";
}