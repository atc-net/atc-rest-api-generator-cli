//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Users
{
    /// <summary>
    /// Update test-gender Request.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class UpdateTestGenderRequest
    {
        /// <summary>
        /// GenderType.
        /// </summary>
        public GenderType Gender { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Gender)}: ({Gender})";
        }
    }
}