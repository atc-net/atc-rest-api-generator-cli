﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Contracts;

/// <summary>
/// CreateItemRequest.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreateItemRequest
{
    /// <summary>
    /// Item.
    /// </summary>
    [Required]
    public Item Item { get; set; }

    /// <summary>
    /// A list of Item.
    /// </summary>
    [Required]
    public List<Item> MyItems { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Item)}: ({Item}), {nameof(MyItems)}.Count: {MyItems?.Count ?? 0}";
}