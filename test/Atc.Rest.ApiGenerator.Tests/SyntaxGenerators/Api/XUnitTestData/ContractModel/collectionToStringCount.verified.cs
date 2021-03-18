using System.CodeDom.Compiler;
using System.Collections.Generic;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestProject.AtcTest.Contracts.Test
{
    /// <summary>
    /// Test component description.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class TestComponent
    {
        public List<string> Foos { get; set; } = new List<string>();

        public List<string> NullableFoos { get; set; } = new List<string>();

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Foos)}.Count: {Foos?.Count ?? 0}, {nameof(NullableFoos)}.Count: {NullableFoos?.Count ?? 0}";
        }
    }
}