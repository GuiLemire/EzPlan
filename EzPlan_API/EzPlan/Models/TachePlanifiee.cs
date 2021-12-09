using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class TachePlanifiee
    {
        public int TachePlanifieeID { get; set; }
        public DateTime DateEcheance { get; set; }
        public SemainePlanifiee SemainePlanifiee { get; set; }
        public List<PartieDeTachePlanifiee> PartiesDeTachesPlanifiees { get; set; }
        public Tache Tache { get; set; }

        public TachePlanifiee()
        {
        }

        public TachePlanifiee(int tachePlanifieeID, DateTime dateEcheance, SemainePlanifiee semainePlanifiee, List<PartieDeTachePlanifiee> partiesDeTachesPlanifiees, Tache tache)
        {
            TachePlanifieeID = tachePlanifieeID;
            DateEcheance = dateEcheance;
            SemainePlanifiee = semainePlanifiee;
            Tache = tache;
            PartiesDeTachesPlanifiees = partiesDeTachesPlanifiees;
        }
    }
}
