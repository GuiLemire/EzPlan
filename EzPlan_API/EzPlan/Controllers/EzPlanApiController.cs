using EzPlan.DAL;
using EzPlan.Models;
using EzPlan.Parsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
        private readonly ILogger<EzPlanApiController> _logger;
        private EzPlanContext DbContext { get; set; }

        public EzPlanApiController(ILogger<EzPlanApiController> logger)
        {
            _logger = logger;
            DbContext = new() ;
        }

        /*Méthodes de L'API*/
        [HttpGet("creerHoraireDisponibilites/{utilisateurID}/{horaireDisponibilitesJSON}")]
        public IActionResult CreerHoraireDisponibilites(int utilisateurID, string horaireDisponibilitesJSON)
        {
            string message = "L'horaire n'a pas été ajouté";
            Utilisateur utilisateur = DbContext.Utilisateurs.Find(utilisateurID);
            if (utilisateur != null)
            {
                HoraireDisponibilites nouvelHoraireDisponibilites = HoraireDisponibilitesParser.ParseFromJSON(horaireDisponibilitesJSON);
                message = utilisateur.ajouterUnHoraire(nouvelHoraireDisponibilites);
                DbContext.SaveChanges();
            }
            return new JsonResult(message);
        }

        public IActionResult CreerTache(int utilisateurID, string tacheJSON)
        {
            string message = "La tache n'a pas été ajoutée";
            Utilisateur utilisateur = DbContext.Utilisateurs.Find(utilisateurID);
            if (utilisateur != null)
            {
                try
                {
                    Tache tache = TacheParser.ParseFromJSON(tacheJSON);
                    message = utilisateur.ajouterUneTache(tache);
                    DbContext.SaveChanges();
                } 
                catch (JsonReaderException)
                {
                    message = "Une erreur est survenue. " + message;
                }
            }
            return new JsonResult(message);
        }

        public IActionResult PlanifierSemaine(int utilisateurID, string semainePourPlanifierJSON, string tachesPourPlanifier)
        {
            string message = "La semaine n'a pas été planifiée";
            Utilisateur utilisateur = DbContext.Utilisateurs.Find(utilisateurID);
            if (utilisateur != null)
            {
                try
                {

                }
                catch (JsonReaderException)
                {
                    message = ConstruireMessageErreur(message); 
                }
            }
            return new JsonResult(message);
        }

        private string ConstruireMessageErreur(string message)
        {
            throw new NotImplementedException();
        }




        /*Méthodes de tests*/
        [HttpGet]
        public IActionResult Get()
        {
            HoraireDisponibilites monHoraire = new HoraireDisponibilites("Mon horaire");
            Disponibilite dispo = new Disponibilite("Jeudi", 12, 14.5);
            monHoraire.AjouterDisponibilite(dispo);
            return new JsonResult(monHoraire);
        }
        [HttpGet("json/{json}")]
        public void GetDispoFromJson(string json)
        {
            Disponibilite result = DisponibiliteParser.ParseFromJSON(json);
            DbContext.Disponibilites.Add(result);
            DbContext.SaveChanges();
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
