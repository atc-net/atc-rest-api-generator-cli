﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Orders.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Update part of order by id.
/// Operation: PatchOrdersId.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class PatchOrdersIdResult
{
    private PatchOrdersIdResult(IResult result)
    {
        Result = result;
    }

    public IResult Result { get; }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static PatchOrdersIdResult Ok(string? message = null)
        => new(TypedResults.Ok(message));

    /// <summary>
    /// 404 - NotFound response.
    /// </summary>
    public static PatchOrdersIdResult NotFound(string? message = null)
        => new(TypedResults.NotFound(message));

    /// <summary>
    /// 409 - Conflict response.
    /// </summary>
    public static PatchOrdersIdResult Conflict(string? message = null)
        => new(Results.Problem(message, null, StatusCodes.Status409Conflict));

    /// <summary>
    /// 502 - BadGateway response.
    /// </summary>
    public static PatchOrdersIdResult BadGateway()
        => new(Results.Problem(null, null, StatusCodes.Status502BadGateway));

    /// <summary>
    /// Performs an implicit conversion from PatchOrdersIdResult to IResult.
    /// </summary>
    public static IResult ToIResult(PatchOrdersIdResult result)
        => result.Result;
}