using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
   public class ParcialDb : DbContext
    {
        public ParcialDb(): base("ConStr")
        {

        }

        public DbSet<TiposEmail> TiposEmailDb { get; set; }
        public DbSet<Retenciones> RetencionesDb { get; set; }
        public DbSet<EmpleadosEmails> EmpleadosEmailsDb { get; set; }
      public DbSet<Entidades.EmpleadosRetenciones> EmpleadosDecuentosDb { get; set; }
       public DbSet<Empleados> EmpleadoDb { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Retenciones>()
             .HasMany(mat => mat.EmpleadoList)
             .WithMany(est => est.RetencionesList)
             .Map(mapa =>

             {
                 mapa.MapLeftKey("EmpleadoId");
                 mapa.MapRightKey("RetencionId");
                 mapa.ToTable("EmpleadosRetenciones");
             });
        }


    }
}
