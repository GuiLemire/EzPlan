using EzPlan.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzPlan.Models;
// spaghetti dans diagram class (relations utiles ou inutiles? copier data ou référence)

namespace EzPlan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utilisateur user = new("test@testing.com", "password");

            HoraireDisponibilites monHoraire = new("Mon horaire");
            Disponibilite dispo = new("Jeudi", 12, 14.5);
            monHoraire.AjouterDisponibilite(dispo);
            user.ajouterUnHoraire(monHoraire);

            Tache tache = new("Ma tache", 2.5, 1.3, 0);
            user.ajouterUneTache(tache);

            SemainePlanifiee semainePlanifiee = new(DateTime.Now, monHoraire);
            JourneePlanifiee journeePlanifiee = new(DateTime.Now);
            TachePlanifiee tachePlanifiee = new(DateTime.Now, tache);
            PartieDeTachePlanifiee partieDeTache = new(DateTime.Now, 1.5);
            tachePlanifiee.AjouterUnePartieDeTachePlanifiee(partieDeTache);
            journeePlanifiee.AjouterUnePartieDeTachePlanifiee(partieDeTache);
            semainePlanifiee.AjouterUneJourneePlanifiee(journeePlanifiee);
            semainePlanifiee.AjouterUneTachePlanifiee(tachePlanifiee);
            user.ajouterUneSemainePlanifiee(semainePlanifiee);

            EzPlanContext ezContext = new();

            ezContext.Utilisateurs.Add(user);
            ezContext.SaveChanges();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
