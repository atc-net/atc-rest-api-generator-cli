﻿//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.405.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Orders
{
    /// <summary>
    /// Results for operation request.
    /// Description: Get orders.
    /// Operation: GetOrders.
    /// Area: Orders.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.405.0")]
    public class GetOrdersResult : ResultBase
    {
        private GetOrdersResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static GetOrdersResult Ok(Pagination<Order> response) => new GetOrdersResult(new OkObjectResult(response));

        /// <summary>
        /// 404 - NotFound response.
        /// </summary>
        public static GetOrdersResult NotFound(string? message = null) => new GetOrdersResult(new NotFoundObjectResult(message));

        /// <summary>
        /// Performs an implicit conversion from GetOrdersResult to ActionResult.
        /// </summary>
        public static implicit operator GetOrdersResult(Pagination<Order> response) => Ok(response);
    }
}