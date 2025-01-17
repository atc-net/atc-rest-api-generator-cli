﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Files.MyContracts;

/// <summary>
/// Results for operation request.
/// Description: Upload files as FormData.
/// Operation: UploadSingleObjectWithFilesAsFormData.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UploadSingleObjectWithFilesAsFormDataResult
{
    private UploadSingleObjectWithFilesAsFormDataResult(IResult result)
    {
        Result = result;
    }

    public IResult Result { get; }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static UploadSingleObjectWithFilesAsFormDataResult Ok(string? message = null)
        => new(TypedResults.Ok(message));

    /// <summary>
    /// 400 - BadRequest response.
    /// </summary>
    public static UploadSingleObjectWithFilesAsFormDataResult BadRequest(string? message = null)
        => new(TypedResults.BadRequest(message));

    /// <summary>
    /// Performs an implicit conversion from UploadSingleObjectWithFilesAsFormDataResult to IResult.
    /// </summary>
    public static IResult ToIResult(UploadSingleObjectWithFilesAsFormDataResult result)
        => result.Result;
}