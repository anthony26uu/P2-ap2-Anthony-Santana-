using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
 public   class EmpleadosEmails
    {

        [Key]
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public int TipoId { get; set; }
        public string Email { get; set; }

        public EmpleadosEmails()
        {

        }

        public EmpleadosEmails(int empleadoId, int tipoId, string email)
        {
            this.Email = email;
            this.EmpleadoId = empleadoId;
            this.TipoId = tipoId;

        }
    }
}
