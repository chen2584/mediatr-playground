using MediatR;

namespace MyApi.Application.Requests;

public class PingRequest : IRequest<string>, INotification
{
    public int TotalPong { get; set; }
    public PingRequest(int totalPong)
    {
        this.TotalPong = totalPong;
    }
}