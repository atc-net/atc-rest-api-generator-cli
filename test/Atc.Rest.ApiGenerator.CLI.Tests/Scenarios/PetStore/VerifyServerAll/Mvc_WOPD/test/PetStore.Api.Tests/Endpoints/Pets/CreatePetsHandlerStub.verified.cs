//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace PetStore.Api.Tests.Endpoints.Pets;

[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class CreatePetsHandlerStub : ICreatePetsHandler
{
    public Task<CreatePetsResult> ExecuteAsync(
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(CreatePetsResult.Created());
    }
}
