﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.ApiClient.Generated.Files.MyContracts;

/// <summary>
/// Parameters for operation request.
/// Description: Upload files as FormData.
/// Operation: UploadSingleObjectWithFilesAsFormData.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UploadSingleObjectWithFilesAsFormDataParameters
{
    /// <summary>
    /// FilesAsFormDataRequest.
    /// </summary>
    [Required]
    public FilesAsFormDataRequest Request { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Request)}: ({Request})";
}