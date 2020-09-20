using System.Linq;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models.EmailService;
using Application.WeatherForecasts.Queries.GetForecastById;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/api/email")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IEmailNotifier _emailNotifier;
        private readonly IConfiguration _config;

        public WeatherForecastController(IEmailNotifier emailNotifier, IConfiguration config)
        {
            _emailNotifier = emailNotifier;
            _config = config;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var email = new Email
            {
                Sender = new Sender
                {
                    ApiKey = _config["SendGrid:ApiKey"],
                    Email = _config["SendGrid:Email"],
                    Name = _config["sendGrid:Name"]
                },
                Recipients = new[] { "vbardin810@gmail.com", "asdasfb326@gmail.com" },
                PlainText = "This test letter was send from WeatherForecastController.cs",
                Subject = "Test message"
            };

            _emailNotifier.SendEmailAsync(email);

            return Ok($"Letters were sent to {email.Recipients.Length} user(s).");

            //return await Mediator.Send(new GetForecastByIdQuery { ForecastId = id });
        }
    }
}
