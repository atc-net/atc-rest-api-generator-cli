//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Files
{
    /// <summary>
    /// Results for operation request.
    /// Description: Upload files as FormData.
    /// Operation: UploadSingleObjectWithFilesAsFormData.
    /// Area: Files.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class UploadSingleObjectWithFilesAsFormDataResult : ResultBase
    {
        private UploadSingleObjectWithFilesAsFormDataResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static UploadSingleObjectWithFilesAsFormDataResult Ok(string? message = null) => new UploadSingleObjectWithFilesAsFormDataResult(new OkObjectResult(message));

        /// <summary>
        /// 400 - BadRequest response.
        /// </summary>
        public static UploadSingleObjectWithFilesAsFormDataResult BadRequest(string message) => new UploadSingleObjectWithFilesAsFormDataResult(new BadRequestObjectResult(message));

        /// <summary>
        /// Performs an implicit conversion from UploadSingleObjectWithFilesAsFormDataResult to ActionResult.
        /// </summary>
        public static implicit operator UploadSingleObjectWithFilesAsFormDataResult(string response) => Ok(response);
    }
}