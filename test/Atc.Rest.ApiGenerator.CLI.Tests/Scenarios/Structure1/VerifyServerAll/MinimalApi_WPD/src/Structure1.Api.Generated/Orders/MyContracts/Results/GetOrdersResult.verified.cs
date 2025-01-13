﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Orders.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Get orders.
/// Operation: GetOrders.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetOrdersResult
{
    private GetOrdersResult(IResult result)
    {
        Result = result;
    }

    public IResult Result { get; }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetOrdersResult Ok(Pagination<Order> result)
        => new(TypedResults.Ok(result));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static GetOrdersResult NotFound(string? message = null)
        => new(TypedResults.NotFound(message));

    /// <summary>
    /// Performs an implicit conversion from GetOrdersResult to IResult.
    /// </summary>
    public static IResult ToIResult(GetOrdersResult result)
        => result.Result;
}