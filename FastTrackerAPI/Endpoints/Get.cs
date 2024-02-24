using FastTrackerAPI.Interfaces;

namespace FastTrackerAPI.Endpoints;

public class Get : IEndpoint
{        public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("get", () => "Get endpoint");
    }
}
