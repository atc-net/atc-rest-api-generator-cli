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
    /// Description: Update gender on a user.
    /// Operation: UpdateMyTestGender.
    /// Area: Users.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.405.0")]
    public class UpdateMyTestGenderParameters
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        [FromRoute(Name = "id")]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// The gender to set on the user.
        /// </summary>
        [FromQuery(Name = "genderParam")]
        public GenderType? GenderParam { get; set; }

        [FromBody]
        [Required]
        public UpdateTestGenderRequest Request { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(GenderParam)}: ({GenderParam}), {nameof(Request)}: ({Request})";
        }
    }
}