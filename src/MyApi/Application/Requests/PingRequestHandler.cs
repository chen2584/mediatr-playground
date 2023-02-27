using MediatR;
using MyApi.Application.Events;

namespace MyApi.Application.Requests;

public class PingRequestHandler : IRequestHandler<PingRequest, string>
{
    readonly IMediator _mediator;
    public PingRequestHandler(IMediator mediator, IConfiguration configuration)
    {
        _mediator = mediator;
    }

    public async Task<string> Handle(PingRequest request, CancellationToken cancellationToken)
    {
        var pongs = Enumerable.Range(0, request.TotalPong)
            .Select(s => "Pong")
            .ToList();

        await _mediator.Publish(new PingEvent());

        return String.Join(", ", pongs);
    }
}