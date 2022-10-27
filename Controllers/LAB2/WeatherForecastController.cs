using Microsoft.AspNetCore.Mvc;
using WebApplication1.Serwices;
using WebApplication1.Serwices.LAB2;

namespace WebApplication1.Controllers.LAB2
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public int Get()
        {
            var calculateInstance = new Calculate(23);
            calculateInstance.Increase(46);
            return calculateInstance.GetValue();
        }
    }
}