namespace MediatR.Example.API.Requests;

public record GetAllForecastRequest : IRequest<IEnumerable<WeatherForecast>>
{
}
