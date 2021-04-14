﻿using System;
using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.87.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Endpoints
{
    /// <summary>
    /// Endpoint definitions.
    /// Area: Accounts.
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("/api/v1/accounts")]
    [GeneratedCode("ApiGenerator", "1.1.87.0")]
    public class AccountsController : ControllerBase
    {
        /// <summary>
        /// Description: Update name of account.
        /// Operation: UpdateAccountName.
        /// Area: Accounts.
        /// </summary>
        [HttpPut("{accountId}/name")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public Task<ActionResult> UpdateAccountNameAsync(UpdateAccountNameParameters parameters, [FromServices] IUpdateAccountNameHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeUpdateAccountNameAsync(parameters, handler, cancellationToken);
        }

        /// <summary>
        /// Description: Set name of account.
        /// Operation: SetAccountName.
        /// Area: Accounts.
        /// </summary>
        [HttpPost("{accountId}/name")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public Task<ActionResult> SetAccountNameAsync(SetAccountNameParameters parameters, [FromServices] ISetAccountNameHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeSetAccountNameAsync(parameters, handler, cancellationToken);
        }

        private static async Task<ActionResult> InvokeUpdateAccountNameAsync(UpdateAccountNameParameters parameters, IUpdateAccountNameHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(parameters, cancellationToken);
        }

        private static async Task<ActionResult> InvokeSetAccountNameAsync(SetAccountNameParameters parameters, ISetAccountNameHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(parameters, cancellationToken);
        }
    }
}