// <copyright file="WeatherForecast.cs" company="Mario Smolcic">
//
// Copyright (C) Mario Smolcic.
// You are permitted to fork, copy, or use this content in any other form you can imagine.
//
// </copyright>

namespace Dotnet.TestOverflow;

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}