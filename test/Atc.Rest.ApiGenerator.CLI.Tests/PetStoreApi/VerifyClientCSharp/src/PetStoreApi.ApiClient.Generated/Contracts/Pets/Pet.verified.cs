//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace PetStoreApi.ApiClient.Generated.Contracts.Pets;

/// <summary>
/// Pet.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Pet
{
    [Required]
    public long Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Tag { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Tag)}: {Tag}";
}