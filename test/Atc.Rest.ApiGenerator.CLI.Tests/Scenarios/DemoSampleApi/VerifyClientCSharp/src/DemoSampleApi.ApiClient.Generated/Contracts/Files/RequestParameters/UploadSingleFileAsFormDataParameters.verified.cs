﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Contracts;

/// <summary>
/// Parameters for operation request.
/// Description: Upload a file as OctetStream.
/// Operation: UploadSingleFileAsFormData.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UploadSingleFileAsFormDataParameters
{
    [Required]
    public IFormFile Request { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Request)}: ({Request})";
}