using EzPlan.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EzPlan.DAL
{
    public class EzPlanContext : DbContext
    {
        public DbSet<Disponibilite> Disponibilites { get; set; }
        public DbSet<HoraireDisponibilites> HorairesDisponibilites { get; set; }
        public DbSet<JourneePlanifiee> JourneesPlanifiees { get; set; }
        public DbSet<PartieDeTachePlanifiee> PartiesDeTachesPlanifiees { get; set; }
        public DbSet<SemainePlanifiee> SemainesPlanifiees { get; set; }
        public DbSet<Tache> Taches { get; set; }
        public DbSet<TachePlanifiee> TachesPlanifiees { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        //Se fait seul et utilise le nom des DbSet, mais permet d'éviter les "s" dans le nom des tables
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disponibilite>().ToTable("Disponibilite");
            modelBuilder.Entity<HoraireDisponibilites>().ToTable("HoraireDisponibilites");
            modelBuilder.Entity<JourneePlanifiee>().ToTable("JourneePlanifiee");
            modelBuilder.Entity<PartieDeTachePlanifiee>().ToTable("PartieDeTachePlanifiee");
            modelBuilder.Entity<SemainePlanifiee>().ToTable("SemainePlanifiee");
            modelBuilder.Entity<Tache>().ToTable("Tache");
            modelBuilder.Entity<TachePlanifiee>().ToTable("TachePlanifiee");
            modelBuilder.Entity<Utilisateur>().ToTable("Utilisateur");
        }
    }
}
