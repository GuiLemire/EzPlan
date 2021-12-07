using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class Tache
    {
        public int TacheID { get; set; }
        public string Nom { get; set; }
        public double DureeApproximative { get; set; }
        public double DureeMaxConsecutive { get; set; }
        public int NiveauDeStress { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public Tache(){}

        public Tache(string nom, double dureeApproximative, double dureeMaxConsecutive, int niveauDeStress)
        {
            Nom = nom;
            DureeApproximative = dureeApproximative;
            DureeMaxConsecutive = dureeMaxConsecutive;
            NiveauDeStress = niveauDeStress;
        }
    }


}
