﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts;

/// <summary>
/// Pageable.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Pageable
{
    /// <summary>
    /// A list of Pageable.
    /// </summary>
    public List<Pageable> PageableList { get; set; } = new List<Pageable>();

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(PageableList)}.Count: {PageableList?.Count ?? 0}";
}