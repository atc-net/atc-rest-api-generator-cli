﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.405.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users
{
    /// <summary>
    /// Parameters for operation request.
    /// Description: Get user by id.
    /// Operation: GetUserById.
    /// Area: Users.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.405.0")]
    public class GetUserByIdParameters
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        [FromRoute(Name = "id")]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}";
        }
    }
}