using System;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.WeatherForecasts.Queries.GetForecastById
{
    public class WeatherForecastByIdDto : IMapFrom<WeatherForecast>
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}