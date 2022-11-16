using Purspot.Personalkollen.Core.Api.Startup;

/// <summary>
/// Initializes a new instance of the <see cref="$Program" /> class.
/// </summary>
var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddConfig(builder.Configuration)
    .RegisterServices();

var app = builder.Build();

app.ConfigureSwagger().ConfigureMiddeleware();

app.Run();
