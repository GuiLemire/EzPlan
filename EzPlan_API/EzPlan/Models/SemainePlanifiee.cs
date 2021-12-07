using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class SemainePlanifiee
    {
        public int SemainePlanifieeID { get; set; }
        public DateTime DateDebut { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public List<TachePlanifiee> TachesPlanifiees {get;set;}
        public List<JourneePlanifiee> JourneesPlanifiees { get; set; }

        public SemainePlanifiee()
        {
        }

        public SemainePlanifiee(Utilisateur utilisateur, DateTime dateDebut)
        {
            Utilisateur = utilisateur;
            DateDebut = dateDebut;
        }
    }
}
