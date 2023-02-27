using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Requests;

namespace MyApi.Controllers;

public class TestController : ControllerBase
{
    readonly IMediator _mediator;
    public TestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("ping/{totalPong}")]
    public Task<string> Ping([FromRoute] int totalPong)
    {
        return _mediator.Send(new PingRequest(totalPong));
    }
}