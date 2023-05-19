using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamContext:DbContext
    {
        //les dbsets
        public DbSet<Exemple> Exemples { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Fournissuer> Fournissuers { get; set; }
        public DbSet<Chimique> Chimiques { get; set; }
        public DbSet<Biologique> Biologiques { get; set; }
        public DbSet<Catagorie> Catagories { get; set; }
        public DbSet<Facture> Factures { get; set; }

        //....................
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                          Initial Catalog=BouhajjaAlaeddineProduit;
                                          Integrated Security=true;
                                          MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies(); //activer lazy loading
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExempleConfiguration());
            //fluent API
            modelBuilder.ApplyConfiguration(new FactureConfiguration());
            modelBuilder.ApplyConfiguration(new ProduitConfiguration());
            //...................
            //tpt 
            //tph => config
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(50);
        }
    }
}
