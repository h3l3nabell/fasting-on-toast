using FastTrackerAPI.Interfaces;

namespace FastTrackerAPI.Endpoints;

public class HelloWorld : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/", () => "Hello World!");
    }
}
