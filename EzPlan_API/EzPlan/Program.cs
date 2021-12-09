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
            EzPlanContext ezContext = new EzPlanContext();

            ezContext.Utilisateurs.Add(new Utilisateur());
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
