﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Monta.ApiClient.Generated.Contracts.ChargePoints;

/// <summary>
/// MapResult.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class MapResult
{
    [Required]
    public List<MapResultChargePoint> ChargePoints { get; set; }

    [Required]
    public List<MapResultSite> Sites { get; set; }

    [Required]
    public List<MapResultCluster> Cluster { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ChargePoints)}.Count: {ChargePoints?.Count ?? 0}, {nameof(Sites)}.Count: {Sites?.Count ?? 0}, {nameof(Cluster)}.Count: {Cluster?.Count ?? 0}";
}