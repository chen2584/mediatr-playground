using MediatR;
using MyApi.Application.Requests;

namespace MyApi.Application.Events;

public class PingEventHandler : INotificationHandler<PingEvent>
{
    readonly ILogger<PingEventHandler> _logger;
    public PingEventHandler(ILogger<PingEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(PingEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Ping Event Notification.");
        return Task.CompletedTask;
    }
}