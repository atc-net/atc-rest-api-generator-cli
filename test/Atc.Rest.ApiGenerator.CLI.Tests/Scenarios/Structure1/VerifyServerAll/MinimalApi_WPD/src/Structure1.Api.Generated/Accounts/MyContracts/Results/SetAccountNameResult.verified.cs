﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Accounts.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Set name of account.
/// Operation: SetAccountName.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class SetAccountNameResult
{
    private SetAccountNameResult(IResult result)
    {
        Result = result;
    }

    public IResult Result { get; }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static SetAccountNameResult Ok(string? message = null)
        => new(TypedResults.Ok(message));

    /// <summary>
    /// Performs an implicit conversion from SetAccountNameResult to IResult.
    /// </summary>
    public static IResult ToIResult(SetAccountNameResult result)
        => result.Result;
}