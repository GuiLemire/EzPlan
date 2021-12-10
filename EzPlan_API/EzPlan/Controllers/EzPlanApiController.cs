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
            Utilisateur user = new("test@testing.com", "password");

            HoraireDisponibilites monHoraire = new("Mon horaire");
            Disponibilite dispo = new("Jeudi", 12, 14.5);
            monHoraire.AjouterDisponibilite(dispo);
            user.ajouterUnHoraire(monHoraire);

            Tache tache = new("Ma tache", 2.5, 1.3, 0);
            user.ajouterUneTache(tache);

            SemainePlanifiee semainePlanifiee = new(DateTime.Now, monHoraire);
            JourneePlanifiee journeePlanifiee = new(DateTime.Now);
            TachePlanifiee tachePlanifiee = new(DateTime.Now, tache);
            PartieDeTachePlanifiee partieDeTache = new(DateTime.Now, 1.5);
            tachePlanifiee.AjouterUnePartieDeTachePlanifiee(partieDeTache);
            journeePlanifiee.AjouterUnePartieDeTachePlanifiee(partieDeTache);
            semainePlanifiee.AjouterUneJourneePlanifiee(journeePlanifiee);
            semainePlanifiee.AjouterUneTachePlanifiee(tachePlanifiee);
            user.ajouterUneSemainePlanifiee(semainePlanifiee);

            return new JsonResult(user);
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
