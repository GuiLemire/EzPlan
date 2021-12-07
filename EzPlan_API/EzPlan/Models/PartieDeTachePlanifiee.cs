using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.Models
{
    public class PartieDeTachePlanifiee
    {
        public int PartieDeTachePlanifieeID { get; set; }
        public DateTime Date { get; set; }
        public double Duree { get; set; }
        public TachePlanifiee TachePlanifiee { get; set; }  
        public JourneePlanifiee JourneePlanifiee { get; set; }
    }
}
