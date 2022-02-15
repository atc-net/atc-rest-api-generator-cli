// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace Atc.Rest.ApiGenerator.Models.OptionsFile;

public class ApiOptionsGenerator
{
    public bool UseAuthorization { get; set; }

    public bool UseRestExtended { get; set; } = true;

    public ApiOptionsGeneratorRequest Request { get; set; } = new ();

    public ApiOptionsGeneratorResponse Response { get; set; } = new ();
}