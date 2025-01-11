﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Structure1.Api.Generated.Accounts.MyContracts;

/// <summary>
/// Domain Interface for RequestHandler.
/// Description: Update name of account.
/// Operation: UpdateAccountName.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public interface IUpdateAccountNameHandler
{
    /// <summary>
    /// Execute method.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    Task<UpdateAccountNameResult> ExecuteAsync(
        UpdateAccountNameParameters parameters,
        CancellationToken cancellationToken = default);
}