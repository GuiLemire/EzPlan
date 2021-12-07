using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class JourneePlanifiee
    {
        public DateTime Date { get; set; }
        public List<PartieDeTachePlanifiee> PartiesDeTachesPlanifiees { get; set; }
        public SemainePlanifiee SemainePlanifiee { get; set; }
    }
}
