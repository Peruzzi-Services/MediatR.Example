﻿var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var startup = new MediatR.Example.API.Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
