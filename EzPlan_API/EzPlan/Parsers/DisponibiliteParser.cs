using EzPlan.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            return JsonConvert.DeserializeObject<Disponibilite>(disponibiliteJSON);
        }
    }
}
