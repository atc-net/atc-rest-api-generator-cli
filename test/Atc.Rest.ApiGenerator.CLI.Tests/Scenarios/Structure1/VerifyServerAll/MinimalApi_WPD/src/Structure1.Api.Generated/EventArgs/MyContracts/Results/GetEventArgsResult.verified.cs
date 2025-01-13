﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.EventArgs.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Get EventArgs List.
/// Operation: GetEventArgs.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetEventArgsResult
{
    private GetEventArgsResult(IResult result)
    {
        Result = result;
    }

    public IResult Result { get; }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static GetEventArgsResult Ok(List<EventArgs> result)
        => new(TypedResults.Ok(result));

    /// <summary>
    /// Performs an implicit conversion from GetEventArgsResult to IResult.
    /// </summary>
    public static IResult ToIResult(GetEventArgsResult result)
        => result.Result;
}