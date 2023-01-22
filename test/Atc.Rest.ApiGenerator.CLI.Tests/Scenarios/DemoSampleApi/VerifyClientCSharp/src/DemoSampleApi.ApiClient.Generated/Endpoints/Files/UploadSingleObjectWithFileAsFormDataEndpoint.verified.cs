﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Endpoints;

/// <summary>
/// Client Endpoint.
/// Description: Upload a file as FormData.
/// Operation: UploadSingleObjectWithFileAsFormData.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UploadSingleObjectWithFileAsFormDataEndpoint : IUploadSingleObjectWithFileAsFormDataEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public UploadSingleObjectWithFileAsFormDataEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<IUploadSingleObjectWithFileAsFormDataEndpointResult> ExecuteAsync(
        UploadSingleObjectWithFileAsFormDataParameters parameters,
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient("DemoSampleApi-ApiClient");

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/files/form-data/singleObject");
        // TODO: Imp. With-Form

        using var requestMessage = requestBuilder.Build(HttpMethod.Post);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<string>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ValidationProblemDetails>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse(HttpStatusCode.Forbidden);
        responseBuilder.AddErrorResponse<string>(HttpStatusCode.InternalServerError);

        return await responseBuilder.BuildResponseAsync(x => new UploadSingleObjectWithFileAsFormDataEndpointResult(x), cancellationToken);
    }
}