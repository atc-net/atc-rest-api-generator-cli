﻿using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Items
{
    /// <summary>
    /// UpdateItemRequest.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class UpdateItemRequest
    {
        /// <summary>
        /// Item.
        /// </summary>
        [Required]
        public Item Item { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Item)}: ({Item})";
        }
    }
}