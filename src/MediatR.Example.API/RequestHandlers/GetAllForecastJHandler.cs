namespace MediatR.Example.API.RequestHandlers;
using Requests;
using Services;

public class GetAllForecastJHandler : IRequestHandler<GetAllForecastRequest, IEnumerable<WeatherForecast>>
{
    private readonly IWeatherForecastService _forecastService;

    public GetAllForecastJHandler(IWeatherForecastService forecastService) 
        => _forecastService = forecastService;

    public async Task<IEnumerable<WeatherForecast>> Handle(GetAllForecastRequest request, CancellationToken cancellationToken) 
        => await _forecastService.GetWeatherForecast();
}
