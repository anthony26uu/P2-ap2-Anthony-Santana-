﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
  public  class Retenciones
    {
        [Key]
        public int RetencionId { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public virtual List<Empleados> EmpleadoList { get; set; }

        public Retenciones()
        {
       
            this.EmpleadoList = new List<Entidades.Empleados>();
        }

    }
}



