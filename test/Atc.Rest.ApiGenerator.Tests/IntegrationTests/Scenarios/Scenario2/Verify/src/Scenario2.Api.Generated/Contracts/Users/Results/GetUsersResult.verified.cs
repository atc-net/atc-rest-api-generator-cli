//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Generated.Contracts.Users
{
    /// <summary>
    /// Results for operation request.
    /// Description: Get all users.
    /// Operation: GetUsers.
    /// Area: Users.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class GetUsersResult : ResultBase
    {
        private GetUsersResult(ActionResult result) : base(result) { }

        /// <summary>
        /// 200 - Ok response.
        /// </summary>
        public static GetUsersResult Ok(IEnumerable<User> response) => new GetUsersResult(new OkObjectResult(response ?? Enumerable.Empty<User>()));

        /// <summary>
        /// 409 - Conflict response.
        /// </summary>
        public static GetUsersResult Conflict(string? error = null) => new GetUsersResult(new ConflictObjectResult(error));

        /// <summary>
        /// Performs an implicit conversion from GetUsersResult to ActionResult.
        /// </summary>
        public static implicit operator GetUsersResult(List<User> response) => Ok(response);
    }
}