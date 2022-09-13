//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Endpoints
{
    /// <summary>
    /// Endpoint definitions.
    /// Area: Files.
    /// </summary>
    [ApiController]
    [Route("/api/v1/files")]
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class FilesController : ControllerBase
    {
        /// <summary>
        /// Description: Get File By Id.
        /// Operation: GetFileById.
        /// Area: Files.
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public Task<ActionResult> GetFileByIdAsync(GetFileByIdParameters parameters, [FromServices] IGetFileByIdHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeGetFileByIdAsync(parameters, handler, cancellationToken);
        }

        /// <summary>
        /// Description: Upload multi files as form data.
        /// Operation: UploadMultiFilesAsFormData.
        /// Area: Files.
        /// </summary>
        [HttpPost("form-data/multiFile")]
        [RequestFormLimits(MultipartBodyLengthLimit = long.MaxValue)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<ActionResult> UploadMultiFilesAsFormDataAsync(UploadMultiFilesAsFormDataParameters parameters, [FromServices] IUploadMultiFilesAsFormDataHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeUploadMultiFilesAsFormDataAsync(parameters, handler, cancellationToken);
        }

        /// <summary>
        /// Description: Upload a file as OctetStream.
        /// Operation: UploadSingleFileAsFormData.
        /// Area: Files.
        /// </summary>
        [HttpPost("form-data/singleFile")]
        [RequestFormLimits(MultipartBodyLengthLimit = long.MaxValue)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<ActionResult> UploadSingleFileAsFormDataAsync(UploadSingleFileAsFormDataParameters parameters, [FromServices] IUploadSingleFileAsFormDataHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeUploadSingleFileAsFormDataAsync(parameters, handler, cancellationToken);
        }

        /// <summary>
        /// Description: Upload a file as FormData.
        /// Operation: UploadSingleObjectWithFileAsFormData.
        /// Area: Files.
        /// </summary>
        [HttpPost("form-data/singleObject")]
        [RequestFormLimits(MultipartBodyLengthLimit = long.MaxValue)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<ActionResult> UploadSingleObjectWithFileAsFormDataAsync(UploadSingleObjectWithFileAsFormDataParameters parameters, [FromServices] IUploadSingleObjectWithFileAsFormDataHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeUploadSingleObjectWithFileAsFormDataAsync(parameters, handler, cancellationToken);
        }

        /// <summary>
        /// Description: Upload files as FormData.
        /// Operation: UploadSingleObjectWithFilesAsFormData.
        /// Area: Files.
        /// </summary>
        [HttpPost("form-data/singleObjectMultiFile")]
        [RequestFormLimits(MultipartBodyLengthLimit = long.MaxValue)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<ActionResult> UploadSingleObjectWithFilesAsFormDataAsync(UploadSingleObjectWithFilesAsFormDataParameters parameters, [FromServices] IUploadSingleObjectWithFilesAsFormDataHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeUploadSingleObjectWithFilesAsFormDataAsync(parameters, handler, cancellationToken);
        }

        private static async Task<ActionResult> InvokeGetFileByIdAsync(GetFileByIdParameters parameters, IGetFileByIdHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(parameters, cancellationToken);
        }

        private static async Task<ActionResult> InvokeUploadMultiFilesAsFormDataAsync(UploadMultiFilesAsFormDataParameters parameters, IUploadMultiFilesAsFormDataHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(parameters, cancellationToken);
        }

        private static async Task<ActionResult> InvokeUploadSingleFileAsFormDataAsync(UploadSingleFileAsFormDataParameters parameters, IUploadSingleFileAsFormDataHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(parameters, cancellationToken);
        }

        private static async Task<ActionResult> InvokeUploadSingleObjectWithFileAsFormDataAsync(UploadSingleObjectWithFileAsFormDataParameters parameters, IUploadSingleObjectWithFileAsFormDataHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(parameters, cancellationToken);
        }

        private static async Task<ActionResult> InvokeUploadSingleObjectWithFilesAsFormDataAsync(UploadSingleObjectWithFilesAsFormDataParameters parameters, IUploadSingleObjectWithFilesAsFormDataHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(parameters, cancellationToken);
        }
    }
}