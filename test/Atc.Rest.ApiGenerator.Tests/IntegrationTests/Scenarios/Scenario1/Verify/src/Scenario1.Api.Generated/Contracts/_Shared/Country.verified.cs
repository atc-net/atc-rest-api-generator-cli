//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario1.Api.Generated.Contracts;

/// <summary>
/// Country.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class Country
{
    [Required]
    public string Name { get; set; }

    [Required]
    [MinLength(2)]
    [MaxLength(2)]
    [RegularExpression("^[A-Za-z]{2}$")]
    public string Alpha2Code { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(3)]
    [RegularExpression("^[A-Za-z]{3}$")]
    public string Alpha3Code { get; set; }

    /// <summary>
    /// Converts to string.
    /// </summary>
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Alpha2Code)}: {Alpha2Code}, {nameof(Alpha3Code)}: {Alpha3Code}";
    }
}