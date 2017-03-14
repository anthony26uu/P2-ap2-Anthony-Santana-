using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
 public   class Empleados
    {
        [Key]
        public int  EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }
        public int RetencionId { get; set; }


        public virtual ICollection<EmpleadosEmails> EmailsList { get; set; }

        public virtual List<Entidades.TiposEmail> TipoList { get; set; }
        public virtual List<Entidades.Retenciones> RetencionesList { get; set; }

        public Empleados()
        {
            this.TipoList = new List<TiposEmail>();
            this.EmailsList = new HashSet<EmpleadosEmails>();
            this.RetencionesList = new List<Retenciones>();

        }

        public void AgregarDetalle(TiposEmail tipoEmail, string descrip)
        {
            this.EmailsList.Add(new EmpleadosEmails(tipoEmail.TipoId, descrip));
        }

     

    }
}
