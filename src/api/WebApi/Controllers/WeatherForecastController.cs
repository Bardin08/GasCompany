using System.Linq;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models.EmailService;
using Application.WeatherForecasts.Queries.GetForecastById;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApi.Controllers
{
    public class WeatherForecastController : ApiController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<WeatherForecastByIdDto>> GetById(int id)
        {
            return await Mediator.Send(new GetForecastByIdQuery { ForecastId = id });
        }
    }
}
