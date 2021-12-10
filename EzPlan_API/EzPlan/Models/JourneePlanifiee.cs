using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class JourneePlanifiee
    {
        public int JourneePlanifieeID { get; set; }
        public DateTime Date { get; set; }
        public List<PartieDeTachePlanifiee> PartiesDeTachesPlanifiees { get; set; }

        public JourneePlanifiee() { }

        public JourneePlanifiee(DateTime date)
        {
            Date = date;
        }

        public string AjouterUnePartieDeTachePlanifiee(PartieDeTachePlanifiee partieDeTache)
        {
            if (PartiesDeTachesPlanifiees == null)
            {
                PartiesDeTachesPlanifiees = new();
            }
            if (!PartiesDeTachesPlanifiees.Contains(partieDeTache))
            {
                PartiesDeTachesPlanifiees.Add(partieDeTache);
                return "Partie de tâche ajoutée avec succès.";
            }
            return "Cette partie de tâche existe déjà.";
        }
    }
}
