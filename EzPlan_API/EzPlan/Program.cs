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

namespace EzPlan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utilisateur user = new Utilisateur("test@testing.com", "password");
           
            HoraireDisponibilites monHoraire = new HoraireDisponibilites("Mon horaire");
            Disponibilite dispo = new Disponibilite("Jeudi", 12, 14.5);
            monHoraire.AjouterDisponibilite(dispo);
            

            Tache tache = new Tache("Ma tache", 2.5, 1.3, 0);

            EzPlanContext ezContext = new EzPlanContext();

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
