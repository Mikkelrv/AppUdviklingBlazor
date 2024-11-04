using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace WeatherApi.Controllers
{
    [ApiController]
	[Route("api/weather")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};


		string[] locations = new string[]
		{
	"Tokyo",
	"Washington, D.C.",
	"London",
	"Paris",
	"Berlin",
	"Ottawa",
	"Canberra",
	"Beijing",
	"New Delhi",
	"Moscow",
	"Brasília",
	"Rome",
	"Madrid",
	"Athens",
	"Cairo",
	"Seoul",
	"Mexico City",
	"Jakarta",
	"Ankara",
	"Buenos Aires"
};


		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		[Route("getforecasts")]
		public IEnumerable<WeatherForecast> Get(int count = 20)
		{
			return Enumerable.Range(1, count).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)],
				Location = locations[Random.Shared.Next(locations.Length)]
			})
			.ToArray();
		}
	}
}
