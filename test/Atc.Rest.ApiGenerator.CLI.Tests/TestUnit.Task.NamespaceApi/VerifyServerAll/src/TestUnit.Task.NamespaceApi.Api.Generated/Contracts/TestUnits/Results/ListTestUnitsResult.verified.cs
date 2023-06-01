﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestUnit.Task.NamespaceApi.Api.Generated.Contracts.TestUnits;

/// <summary>
/// Results for operation request.
/// Description: List test units.
/// Operation: ListTestUnits.
/// </summary>
[GeneratedCode("ApiGenerator", "x.x.x.x")]
public class ListTestUnitsResult : ResultBase
{
    private ListTestUnitsResult(ActionResult result) : base(result) { }

    /// <summary>
    /// 200 - Ok response.
    /// </summary>
    public static ListTestUnitsResult Ok(PaginationResult<TestUnit> response)
        => new ListTestUnitsResult(new OkObjectResult(response));

    /// <summary>
    /// Performs an implicit conversion from ListTestUnitsResult to ActionResult.
    /// </summary>
    public static implicit operator ListTestUnitsResult(PaginationResult<TestUnit> response)
        => Ok(response);
}