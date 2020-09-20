using System.Threading;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.WeatherForecasts.Queries.GetForecastById
{
    public class GetForecastByIdQuery : IRequest<WeatherForecastByIdDto>
    {
        public int ForecastId { get; set; }
    }

    //public class GetForecastByIdQueryHandler : IRequestHandler<GetForecastByIdQuery, WeatherForecastByIdDto>
    //{
    //    //private readonly IRepository<WeatherForecast> _repository;
    //    //private readonly IMapper _mapper;

    //    //public GetForecastByIdQueryHandler(IRepository<WeatherForecast> repository, IMapper mapper)
    //    //{
    //    //    _repository = repository;
    //    //    _mapper = mapper;
    //    //}

    //    //public async Task<WeatherForecastByIdDto> Handle(GetForecastByIdQuery request,
    //    //    CancellationToken cancellationToken)
    //    //{
    //    //    var entity = await _repository.GetById(request.ForecastId);

    //    //    if (entity == null)
    //    //    {
    //    //        throw new NotFoundException(nameof(WeatherForecast), request.ForecastId);
    //    //    }

    //    //    return _mapper.Map<WeatherForecastByIdDto>(entity);
    //    //}
    //}
}