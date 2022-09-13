﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.405.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Files
{
    /// <summary>
    /// Parameters for operation request.
    /// Description: Upload a file as FormData.
    /// Operation: UploadSingleObjectWithFileAsFormData.
    /// Area: Files.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.405.0")]
    public class UploadSingleObjectWithFileAsFormDataParameters
    {
        [FromForm]
        [Required]
        public FileAsFormDataRequest Request { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Request)}: ({Request})";
        }
    }
}