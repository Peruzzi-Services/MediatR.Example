﻿namespace MediatR.Example.API;
using MediatR.Example.API.Services;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Add services to the container
    /// </summary>
    /// <param name="services"></param>
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Startup>());
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
    {
        // Configure the HTTP request pipeline.
        if (environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
