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
        public HoraireDisponibilites HoraireDisponibilites { get; set; }
        public List<TachePlanifiee> TachesPlanifiees { get; set; }
        public List<JourneePlanifiee> JourneesPlanifiees { get; set; }

        public SemainePlanifiee() { }

        public SemainePlanifiee(DateTime dateDebut, HoraireDisponibilites horaireDisponibilites)
        {
            DateDebut = dateDebut;
            HoraireDisponibilites = horaireDisponibilites;
        }

        public string AjouterUneJourneePlanifiee(JourneePlanifiee journeePlanifiee)
        {
            if (JourneesPlanifiees == null)
            {
                JourneesPlanifiees = new();
            }
            if (!JourneesPlanifiees.Contains(journeePlanifiee))
            {
                JourneesPlanifiees.Add(journeePlanifiee);
                return "Journée planifiée ajoutée avec succès.";
            }
            return "Cette journée planifiée existe déjà.";
        }

        public string AjouterUneTachePlanifiee(TachePlanifiee tachePlanifiee)
        {
            if (TachesPlanifiees == null)
            {
                TachesPlanifiees = new();
            }
            if (!TachesPlanifiees.Contains(tachePlanifiee))
            {
                TachesPlanifiees.Add(tachePlanifiee);
                return "La tâche planifiée '" + tachePlanifiee.Tache.Nom + "' a été ajoutée avec succès.";
            }
            return "Cette tâche planifiée existe déjà.";
        }
    }
}
