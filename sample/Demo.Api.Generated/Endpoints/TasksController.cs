﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.154.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Endpoints
{
    /// <summary>
    /// Endpoint definitions.
    /// Area: Tasks.
    /// </summary>
    [ApiController]
    [Route("/api/v1/tasks")]
    [GeneratedCode("ApiGenerator", "1.1.154.0")]
    public class TasksController : ControllerBase
    {
        /// <summary>
        /// Description: Returns tasks.
        /// Operation: GetTasks.
        /// Area: Tasks.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(List<Demo.Api.Generated.Contracts.Tasks.Task>), StatusCodes.Status200OK)]
        public Task<ActionResult> GetTasksAsync([FromServices] IGetTasksHandler handler, CancellationToken cancellationToken)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return InvokeGetTasksAsync(handler, cancellationToken);
        }

        private static async Task<ActionResult> InvokeGetTasksAsync([FromServices] IGetTasksHandler handler, CancellationToken cancellationToken)
        {
            return await handler.ExecuteAsync(cancellationToken);
        }
    }
}