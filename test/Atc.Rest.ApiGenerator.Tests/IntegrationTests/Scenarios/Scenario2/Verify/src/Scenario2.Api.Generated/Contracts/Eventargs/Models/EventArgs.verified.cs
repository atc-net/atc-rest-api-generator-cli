//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Eventargs
{
    /// <summary>
    /// EventArgs.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class EventArgs
    {
        public Guid Id { get; set; }

        public string EventName { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(EventName)}: {EventName}";
        }
    }
}