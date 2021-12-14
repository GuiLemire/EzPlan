using EzPlan.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Parsers
{
    public class TacheParser
    {
        internal static Tache ParseFromJSON(string tacheJSON)
        {
            try
            {
                return JsonConvert.DeserializeObject<Tache>(tacheJSON);
            }
            catch (JsonReaderException e)
            {
                throw new JsonReaderException(e.Message);
            }
        }
    }
}
