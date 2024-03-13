namespace MinimalApis.Endpoints
{
    public class UserEndpoints : IEndpoint
    {
        public void MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/users", () => "list of users");
            endpoints.MapPost("/users", () => Results.Ok("User Created"));
        }
    }
}
