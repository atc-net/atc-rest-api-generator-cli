﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace DemoSample.ApiClient.Generated.Endpoints.Users;

/// <summary>
/// Client Endpoint.
/// Description: Update gender on a user.
/// Operation: UpdateMyTestGender.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateMyTestGenderEndpoint : IUpdateMyTestGenderEndpoint
{
    private readonly IHttpClientFactory factory;
    private readonly IHttpMessageFactory httpMessageFactory;

    public UpdateMyTestGenderEndpoint(
        IHttpClientFactory factory,
        IHttpMessageFactory httpMessageFactory)
    {
        this.factory = factory;
        this.httpMessageFactory = httpMessageFactory;
    }

    public async Task<UpdateMyTestGenderEndpointResult> ExecuteAsync(
        UpdateMyTestGenderParameters parameters,
        string httpClientName = "DemoSample-ApiClient",
        CancellationToken cancellationToken = default)
    {
        var client = factory.CreateClient(httpClientName);

        var requestBuilder = httpMessageFactory.FromTemplate("/api/v1/users/{id}/gender");
        requestBuilder.WithPathParameter("id", parameters.Id);
        requestBuilder.WithQueryParameter("genderParam", parameters.GenderParam);
        requestBuilder.WithBody(parameters.Request);

        using var requestMessage = requestBuilder.Build(HttpMethod.Put);
        using var response = await client.SendAsync(requestMessage, cancellationToken);

        var responseBuilder = httpMessageFactory.FromResponse(response);
        responseBuilder.AddSuccessResponse<string?>(HttpStatusCode.OK);
        responseBuilder.AddErrorResponse<ValidationProblemDetails>(HttpStatusCode.BadRequest);
        responseBuilder.AddErrorResponse<string?>(HttpStatusCode.NotFound);
        responseBuilder.AddErrorResponse<ProblemDetails>(HttpStatusCode.Conflict);
        return await responseBuilder.BuildResponseAsync(x => new UpdateMyTestGenderEndpointResult(x), cancellationToken);
    }
}