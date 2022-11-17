﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.197.51239.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Files;

/// <summary>
/// Parameters for operation request.
/// Description: Upload multi files as form data.
/// Operation: UploadMultiFilesAsFormData.
/// Area: Files.
/// </summary>
[GeneratedCode("ApiGenerator", "2.0.197.51239")]
public class UploadMultiFilesAsFormDataParameters
{
    [FromForm]
    [Required]
    public List<IFormFile> Request { get; set; } = new List<IFormFile>();

    /// <summary>
    /// Converts to string.
    /// </summary>
    public override string ToString()
    {
        return $"{nameof(Request)}.Count: {Request?.Count ?? 0}";
    }
}