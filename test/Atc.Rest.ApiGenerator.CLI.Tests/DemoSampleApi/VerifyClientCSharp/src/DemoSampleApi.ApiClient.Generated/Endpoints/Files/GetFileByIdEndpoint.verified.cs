﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSampleApi.ApiClient.Generated.Endpoints;

/// <summary>
/// Client Endpoint.
/// Description: Get File By Id.
/// Operation: GetFileById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetFileByIdEndpoint : IGetFileByIdEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public GetFileByIdEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<IGetFileByIdEndpointResult> ExecuteAsync(
        GetFileByIdParameters parameters,
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient("DemoSampleApi-ApiClient");

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/files/{id}");
        requestBuilder.WithPathParameter("id", parameters.Id);

        using var requestMessage = requestBuilder.Build(HttpMethod.Get);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<string>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ValidationProblemDetails>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse(HttpStatusCode.Unauthorized);
        responseBuilder.AddErrorResponse(HttpStatusCode.Forbidden);
        responseBuilder.AddErrorResponse(HttpStatusCode.NotFound);
        responseBuilder.AddErrorResponse<string>(HttpStatusCode.InternalServerError);

        return await responseBuilder.BuildResponseAsync(x => new GetFileByIdEndpointResult(x), cancellationToken);
    }
}