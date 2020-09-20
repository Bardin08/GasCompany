using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.WeatherForecasts.Commands.CreateForecast
{
    public class CreateForecastCommand : IRequest
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
        public string PublishedBy { get; set; }
    }
    //public class CreateForecastCommandHandler : IRequestHandler<CreateForecastCommand>
    //{
    //    private readonly IRepository<WeatherForecast> _repository;

    //    public CreateForecastCommandHandler(IRepository<WeatherForecast> repository)
    //    {
    //        _repository = repository;
    //    }

    //    public async Task<Unit> Handle(CreateForecastCommand request, CancellationToken cancellationToken)
    //    {
    //        var entity = new WeatherForecast
    //        {
    //            Date = request.Date,
    //            TemperatureC = request.TemperatureC,
    //            Summary = request.Summary,
    //            PublishedBy = request.PublishedBy
    //        };

    //        await _repository.Create(entity);

    //        await _repository.SaveChangesAsync();

    //        return Unit.Value;
    //    }
    //}
}