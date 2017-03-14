using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
  public  class TiposEmail
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Empleados> EmpleadoLis { get; set; }
        public virtual ICollection<EmpleadosEmails> LisRelacion { get; set; }

     
        public TiposEmail()
        {
            this.EmpleadoLis = new List<Entidades.Empleados>();
            this.LisRelacion = new HashSet<EmpleadosEmails>();
        }
       

    }
}



