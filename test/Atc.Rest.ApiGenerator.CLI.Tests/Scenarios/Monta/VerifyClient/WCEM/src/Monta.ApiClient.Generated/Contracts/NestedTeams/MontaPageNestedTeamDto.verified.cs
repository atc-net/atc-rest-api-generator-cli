﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.NestedTeams;

/// <summary>
/// MontaPageNestedTeamDto.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class MontaPageNestedTeamDto
{
    [Required]
    public List<NestedTeam> Data { get; set; }

    [Required]
    public MontaPageMeta Meta { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Data)}.Count: {Data?.Count ?? 0}, {nameof(Meta)}: ({Meta})";
}