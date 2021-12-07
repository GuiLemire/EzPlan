using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class HoraireDisponibilites
    {
        public int HoraireDisponibilitesID { get; set; }
        public string Nom { get; set; }
        public List<Disponibilite> Disponibilites { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public HoraireDisponibilites()
        {
        }

        public HoraireDisponibilites(string nom, Utilisateur utilisateur)
        {
            Utilisateur = utilisateur;
            Nom = nom;
        }

        private string AjouterDisponibilite(Disponibilite disponibilite)
        {
            if (!this.Disponibilites.Contains(disponibilite))
            {
                this.Disponibilites.Add(disponibilite);
                return "Ajouté avec succès.";
            }
            return "Cette disponibilite existe déjà.";
        }
    }
}
