using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APITemperatura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversorTemperaturasController : ControllerBase
    {
        private readonly ILogger<ConversorTemperaturasController> _logger;

        public ConversorTemperaturasController(
            ILogger<ConversorTemperaturasController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Fahrenheit/{temperatura}")]
        public Temperatura GetConversaoFahrenheit(double temperatura)
        {
            _logger.LogInformation(
                $"Recebida temperatura para conversão: {temperatura}");

            return new Temperatura(temperatura);
        }
    }
}