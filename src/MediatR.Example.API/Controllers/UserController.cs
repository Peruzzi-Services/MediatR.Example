using MediatR.Example.API.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Example.API.Controllers;

[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] User user)
    {
        var command = new CreateUserCommand(user);
        var newUser = await _mediator.Send(command);
        return Created($"api/users/{newUser.Id}", newUser);
    }
}
