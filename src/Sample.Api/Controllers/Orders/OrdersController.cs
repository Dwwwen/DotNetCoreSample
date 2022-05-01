using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sample.Application.Orders.Commands;

namespace Sample.Api.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : Controller
{
    private readonly IMediator _mediator;

    public OrdersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateOrderRequest request)
    {
        var id = await _mediator.Send(new CreateOrderCommand(request.UserId));
        return Ok(id);
    }
}
