using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
 public   class EmpleadosRetenciones
    {
        [Key]
        public int Id   { get; set; }
        public int EmpleadoId { get; set; }
        public int RetencionId { get; set; }

        public EmpleadosRetenciones()
        {
        }

        public EmpleadosRetenciones(int id, int empleadoId, int retencionId)
        {
            this.Id = id;
            this.EmpleadoId = empleadoId;
            this.RetencionId = retencionId;
        }

    }
}
