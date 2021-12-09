using EzPlan.Models;
using EzPlan.Parsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EzPlanApiController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EzPlanApiController> _logger;

        public EzPlanApiController(ILogger<EzPlanApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            Disponibilite dispo = new("Mardi", 1234, 1235);
            return DisponibiliteParser.ParseToJSON(dispo);

        }
        //https://localhost:44339/weatherforecast/33
        [HttpGet("{temp}")]
        public IEnumerable<object> JsonArray(string temp)
        {
            List<object> liste = new();
            var jack = new
            {
                temp = temp,
                wind = "fort"
            };
            liste.Add(jack);

            var mike = new
            {
                temp = temp,
                wind = " très fort"
            };

            liste.Add(mike);

            return liste;
        }

    }
}
