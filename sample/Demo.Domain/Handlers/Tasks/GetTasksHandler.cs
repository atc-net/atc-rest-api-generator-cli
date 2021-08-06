﻿using System.Threading;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts.Tasks;

namespace Demo.Domain.Handlers.Tasks
{
    /// <summary>
    /// Handler for operation request.
    /// Description: Returns tasks.
    /// Operation: GetTasks.
    /// Area: Tasks.
    /// </summary>
    public class GetTasksHandler : IGetTasksHandler
    {
        public Task<GetTasksResult> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}