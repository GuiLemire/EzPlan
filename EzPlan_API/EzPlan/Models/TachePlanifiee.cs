using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class TachePlanifiee : Tache
    {
        public int TachePlanifieeID { get; set; }
        public DateTime DateEcheance { get; set; }
        public SemainePlanifiee SemainePlanifiee { get; set; }
        public List<PartieDeTachePlanifiee> PartiesDeTachesPlanifiees { get; set; }

        public TachePlanifiee()
        {
        }

    }
}
