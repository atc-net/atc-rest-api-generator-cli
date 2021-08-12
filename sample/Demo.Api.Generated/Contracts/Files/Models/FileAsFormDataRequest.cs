using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.124.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Files
{
    /// <summary>
    /// FileAsFormDataRequest.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.124.0")]
    public class FileAsFormDataRequest
    {
        [Required]
        public string ItemName { get; set; }

        public IFormFile? File { get; set; }

        [Required]
        public List<string> Items { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(ItemName)}: {ItemName}, {nameof(File)}: {File}, {nameof(Items)}.Count: {Items?.Count ?? 0}";
        }
    }
}