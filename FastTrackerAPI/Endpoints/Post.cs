using FastTrackerAPI.Interfaces;

namespace FastTrackerAPI.Endpoints;

public class Post : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("post", () => "Post endpoint");
    }
}
