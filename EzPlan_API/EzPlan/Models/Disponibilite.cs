using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class Disponibilite
    {
        public int DisponibiliteID { get; set; }
        public string Journee { get; set; }
        public double HeureDebut { get; set; }
        public double HeureFin { get; set; }
        public HoraireDisponibilites HoraireDisponibilites { get; set; }

        public Disponibilite()
        {
        }

        public Disponibilite(HoraireDisponibilites horaireDisponibilites, string journee, double heureDebut, double heureFin)
        {
            HoraireDisponibilites = horaireDisponibilites;
            Journee = journee;
            HeureDebut = heureDebut;
            HeureFin = heureFin;
        }
    }
}
