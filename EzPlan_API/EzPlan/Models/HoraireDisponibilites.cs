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
        public HoraireDisponibilites()
        {
        }

        public HoraireDisponibilites(string nom)
        {
            Nom = nom;
        }

        public string AjouterDisponibilite(Disponibilite disponibilite)
        {
            if (Disponibilites == null)
            {
                Disponibilites = new();
            }
            if (!Disponibilites.Contains(disponibilite))
            {
                Disponibilites.Add(disponibilite);
                return "Disponibilité ajouté avec succès.";
            }
            return "Cette disponibilite existe déjà.";
        }
    }
}
