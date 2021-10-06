﻿using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Orders
{
    /// <summary>
    /// Request to update an order.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class UpdateOrderRequest
    {
        /// <summary>
        /// Undefined description.
        /// </summary>
        /// <remarks>
        /// Email validation being enforced.
        /// </remarks>
        [Required]
        [EmailAddress]
        public string MyEmail { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(MyEmail)}: {MyEmail}";
        }
    }
}