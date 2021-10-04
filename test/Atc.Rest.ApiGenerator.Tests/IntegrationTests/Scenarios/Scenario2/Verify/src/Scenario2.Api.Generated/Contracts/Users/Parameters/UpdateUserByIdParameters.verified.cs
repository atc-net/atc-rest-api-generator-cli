﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Users
{
    /// <summary>
    /// Parameters for operation request.
    /// Description: Update user by id.
    /// Operation: UpdateUserById.
    /// Area: Users.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class UpdateUserByIdParameters
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        [FromRoute(Name = "id")]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Request to update a user.
        /// </summary>
        [FromBody]
        [Required]
        public UpdateUserRequest Request { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Request)}: ({Request})";
        }
    }
}