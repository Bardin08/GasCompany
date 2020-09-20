using System;
using System.Linq;
using System.Threading.Tasks;
using Application.WeatherForecasts.Queries.GetForecastById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class WeatherForecastController : ApiController
    {
        [Route("identity")]
        [HttpGet]
        public IActionResult GetClaims()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }

        [HttpGet]
        public ActionResult<WeatherForecastByIdDto> Get()
        {
            return Ok(new WeatherForecastByIdDto() { Date = DateTime.Now, Summary = "", TemperatureC = 111 });
        }
    }
}
