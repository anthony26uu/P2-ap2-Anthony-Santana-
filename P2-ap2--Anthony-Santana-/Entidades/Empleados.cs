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
        public virtual List<Entidades.Retenciones> RetencionesList { get; set; }

        public Empleados()
        {
            this.RetencionesList = new List<Retenciones>();
        }
        public Empleados(int empleadoId)
        {
            this.EmpleadoId = empleadoId;
        }

    }
}
