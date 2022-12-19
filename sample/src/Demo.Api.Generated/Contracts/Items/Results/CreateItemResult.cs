﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.241.32395.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Items;

/// <summary>
/// Results for operation request.
/// Description: Create a new item.
/// Operation: CreateItem.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.241.32395")]
public class CreateItemResult : ResultBase
{
    private CreateItemResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static CreateItemResult Ok(string? message = null)
        => new CreateItemResult(new OkObjectResult(message));

    /// <summary>
    /// Performs an implicit conversion from CreateItemResult to ActionResult.
    /// </summary>
    public static implicit operator CreateItemResult(string response)
        => Ok(response);
}