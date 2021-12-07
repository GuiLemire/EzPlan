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
        public List<HoraireDisponibilites> HoraireDisponibilites { get; set; }
        public List<Tache> Taches { get; set; }
        public List<TachePlanifiee> TachePlanifiees { get; set; }

        public Utilisateur()
        {
        }

        public Utilisateur(string adresseCourriel, string motDePasse)
        {
            AdresseCourriel = adresseCourriel;
            MotDePasse = motDePasse;
        }
    }
}
