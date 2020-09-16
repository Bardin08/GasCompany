using System.Threading.Tasks;
using Application.WeatherForecasts.Queries.GetForecastById;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class WeatherForecastController : ApiController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<WeatherForecastByIdDto>> GetById(int id)
        {
            return await Mediator.Send(new GetForecastByIdQuery {ForecastId = id});
        }
    }
}
