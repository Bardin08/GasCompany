using FluentValidation;

namespace Application.WeatherForecasts.Commands.CreateForecast
{
    public class CreateForecastCommandValidator : AbstractValidator<CreateForecastCommand>
    {
        public CreateForecastCommandValidator()
        {
            RuleFor(c => c.TemperatureC)
                .InclusiveBetween(-100, 100);
        }
    }
}