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


    }
}
