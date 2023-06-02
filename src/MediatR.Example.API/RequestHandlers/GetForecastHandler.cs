namespace MediatR.Example.API.RequestHandlers;

using Requests;
using Services;

public class GetForecastHandler : IRequestHandler<GetForecastRequest, WeatherForecast>
{
    private readonly IWeatherForecastService _forecastService;

    public GetForecastHandler(IWeatherForecastService forecastService) 
        => _forecastService = forecastService;

    public async Task<WeatherForecast> Handle(
        GetForecastRequest request, 
        CancellationToken cancellationToken)
    {
        var forecast = await _forecastService.GetWeatherForecast(request.Date);
        if(forecast != null) {
            return forecast;
        }
        throw new FileNotFoundException($"{request.Date}: there is no forecast for this date");
    }
}
