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
        public Tache Tache { get; set; }
        public List<PartieDeTachePlanifiee> PartiesDeTachesPlanifiees { get; set; }
        
        public TachePlanifiee() { }
        
        public TachePlanifiee(DateTime dateEcheance, Tache tache)
        {
            DateEcheance = dateEcheance;
            Tache = tache;
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
