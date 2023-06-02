using Microsoft.AspNetCore.Mvc;

namespace MediatR.Example.API.Controllers;
using Requests;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger _logger;

    public WeatherForecastController(
        IMediator mediator, 
        ILogger<WeatherForecastController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await _mediator.Send(new GetAllForecastRequest());
    }

    [HttpGet("{date}")]
    public async Task<WeatherForecast> Get(string date)
    {
        return await _mediator.Send(new GetForecastRequest(date));
    }
}
