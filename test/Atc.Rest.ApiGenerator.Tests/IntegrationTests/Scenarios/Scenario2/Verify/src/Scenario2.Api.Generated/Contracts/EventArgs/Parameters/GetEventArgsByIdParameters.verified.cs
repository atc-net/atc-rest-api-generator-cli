//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.EventArgs;

/// <summary>
/// Parameters for operation request.
/// Description: Get EventArgs By Id.
/// Operation: GetEventArgsById.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class GetEventArgsByIdParameters
{
    /// <summary>
    /// The id of the eventArgs.
    /// </summary>
    [FromRoute(Name = "id")]
    [Required]
    public string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Id)}: {Id}";
}