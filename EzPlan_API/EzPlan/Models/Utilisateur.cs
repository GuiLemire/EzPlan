using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class Utilisateur
    {
        public int UtilisateurID { get; set; }
        public string AdresseCourriel { get; set; }
        public string MotDePasse { get; set; }
        public List<HoraireDisponibilites> HorairesDisponibilites { get; set; }
        public List<Tache> Taches { get; set; }
        public List<SemainePlanifiee> SemainesPlanifiees { get; set; }

        public Utilisateur()
        {
        }

        public Utilisateur(string adresseCourriel, string motDePasse)
        {
            AdresseCourriel = adresseCourriel;
            MotDePasse = motDePasse;
        }

        public string ajouterUnHoraire(HoraireDisponibilites horaire)
        {
            if (HorairesDisponibilites == null)
            {
                HorairesDisponibilites = new();
            }
            if (!HorairesDisponibilites.Contains(horaire))
            {
                HorairesDisponibilites.Add(horaire);
                return "L'horaire '" + horaire.Nom + "' a été ajouté avec succès.";
            }
            return "Cet horaire existe déjà.";
        }

        public string ajouterUneTache(Tache tache)
        {
            if (Taches == null)
            {
                Taches = new();
            }
            if (!Taches.Contains(tache))
            {
                Taches.Add(tache);
                return "La tâche '" + tache.Nom + "' a été ajoutée avec succès.";
            }
            return "Cette tâche existe déjà.";
        }

        public string ajouterUneSemainePlanifiee(SemainePlanifiee semainePlanifiee)
        {
            if (SemainesPlanifiees == null)
            {
                SemainesPlanifiees = new();
            }
            if (!SemainesPlanifiees.Contains(semainePlanifiee))
            {
                SemainesPlanifiees.Add(semainePlanifiee);
                return "Semaine planifiée créée avec succès.";
            }
            return "Cette semaine planifiée existe déjà.";
        }
    }
}
