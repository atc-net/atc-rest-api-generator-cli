﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.WalletTransactions;

/// <summary>
/// TeamOrOperator.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class TeamOrOperator
{
    /// <summary>
    /// A list of TeamOrOperator.
    /// </summary>
    public List<TeamOrOperator> TeamOrOperatorList { get; set; } = new List<TeamOrOperator>();

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(TeamOrOperatorList)}.Count: {TeamOrOperatorList?.Count ?? 0}";
}