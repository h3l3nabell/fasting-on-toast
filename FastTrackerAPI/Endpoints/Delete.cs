using FastTrackerAPI.Interfaces;

namespace FastTrackerAPI.Endpoints;

public class Delete : IEndpoint
{        
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("delete", () => "Delete endpoint");
    }
}
