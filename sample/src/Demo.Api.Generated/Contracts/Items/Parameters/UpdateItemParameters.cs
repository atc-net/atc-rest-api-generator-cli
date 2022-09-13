﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.405.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Items
{
    /// <summary>
    /// Parameters for operation request.
    /// Description: Updates an item.
    /// Operation: UpdateItem.
    /// Area: Items.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.405.0")]
    public class UpdateItemParameters
    {
        /// <summary>
        /// The id of the order.
        /// </summary>
        [FromRoute(Name = "id")]
        [Required]
        public Guid Id { get; set; }

        [FromBody]
        [Required]
        public UpdateItemRequest Request { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Request)}: ({Request})";
        }
    }
}