﻿using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.RouteWithDash
{
    /// <summary>
    /// Domain Interface for RequestHandler.
    /// Description: Your GET endpoint.
    /// Operation: GetRouteWithDash.
    /// Area: RouteWithDash.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public interface IGetRouteWithDashHandler
    {
        /// <summary>
        /// Execute method.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        Task<GetRouteWithDashResult> ExecuteAsync(CancellationToken cancellationToken = default);
    }
}