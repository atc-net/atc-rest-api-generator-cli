using System.CodeDom.Compiler;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestProject.AtcTest.Contracts.Test
{
    /// <summary>
    /// Parameters for operation request.
    /// Description: Get.
    /// Operation: Get.
    /// Area: Test.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class GetParameters
    {
        [FromHeader(Name = "fooBar")]
        public string FooBar { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(FooBar)}: {FooBar}";
        }
    }
}