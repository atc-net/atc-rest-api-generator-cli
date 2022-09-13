﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.405.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Accounts
{
    /// <summary>
    /// Parameters for operation request.
    /// Description: Update name of account.
    /// Operation: UpdateAccountName.
    /// Area: Accounts.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.405.0")]
    public class UpdateAccountNameParameters
    {
        /// <summary>
        /// The accountId.
        /// </summary>
        [FromRoute(Name = "accountId")]
        [Required]
        public Guid AccountId { get; set; }

        /// <summary>
        /// The account name.
        /// </summary>
        [FromHeader(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(AccountId)}: {AccountId}, {nameof(Name)}: {Name}";
        }
    }
}