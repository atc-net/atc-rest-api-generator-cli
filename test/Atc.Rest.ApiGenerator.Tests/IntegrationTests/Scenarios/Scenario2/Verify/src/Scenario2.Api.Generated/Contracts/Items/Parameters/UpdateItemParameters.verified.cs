//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Items;

/// <summary>
/// Parameters for operation request.
/// Description: Updates an item.
/// Operation: UpdateItem.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class UpdateItemParameters
{
    /// <summary>
    /// The id of the order.
    /// </summary>
    [FromRoute(Name = "id")]
    [Required]
    public Guid Id { get; set; }

    [FromBody]
    [Required]
    public UpdateItemRequest Request { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}, {nameof(Request)}: ({Request})";
}