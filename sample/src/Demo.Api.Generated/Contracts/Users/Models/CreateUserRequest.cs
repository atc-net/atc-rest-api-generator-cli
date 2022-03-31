﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 2.0.121.412.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users
{
    /// <summary>
    /// Request to create a user.
    /// </summary>
    [GeneratedCode("ApiGenerator", "2.0.121.412")]
    public class CreateUserRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTimeOffset? MyNullableDateTime { get; set; }

        [Required]
        public DateTimeOffset MyDateTime { get; set; }

        /// <summary>
        /// Undefined description.
        /// </summary>
        /// <remarks>
        /// Email validation being enforced.
        /// </remarks>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Undefined description.
        /// </summary>
        /// <remarks>
        /// Url validation being enforced.
        /// </remarks>
        [Uri]
        public Uri Homepage { get; set; }

        /// <summary>
        /// GenderType.
        /// </summary>
        [Required]
        public GenderType Gender { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        public Address? MyNullableAddress { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(MyNullableDateTime)}: {MyNullableDateTime}, {nameof(MyDateTime)}: {MyDateTime}, {nameof(Email)}: {Email}, {nameof(Homepage)}: {Homepage}, {nameof(Gender)}: ({Gender}), {nameof(MyNullableAddress)}: ({MyNullableAddress})";
        }
    }
}