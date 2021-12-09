using EzPlan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EzPlan.Parsers
{
    public class DisponibiliteParser
    {
        public static Disponibilite ParseFromJSON(string disponibiliteJSON)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Disponibilite>(disponibiliteJSON);
        }
        public static JsonResult ParseToJSON(Disponibilite disponibilite)
        {
            var retour = new
            {
                disponibilite.DisponibiliteID,
                disponibilite.Journee,
                disponibilite.HeureDebut,
                disponibilite.HeureFin
            };
            return new JsonResult(retour);
        }
}
}
