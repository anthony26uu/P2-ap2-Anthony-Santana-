using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
 public   class RetencionesBLL
    {
       
        public static Retenciones Guardar(Retenciones nuevo)
        {
            Retenciones creado = null;
            using (var repositorio = new Repositorio<Retenciones>())
            {
                creado = repositorio.Guardar(nuevo);
            }

            return creado;

        }


        public static bool Mofidicar(Retenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Retenciones>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Retenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Retenciones>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static Retenciones Buscar(Expression<Func<Retenciones, bool>> retencion)
        {
            Retenciones Result = null;
            using (var repoitorio = new Repositorio<Retenciones>())
            {
                Result = repoitorio.Buscar(retencion);
            }

            return Result;
        }


        public static List<Retenciones> Lista(Expression<Func<Retenciones, bool>> busqueda)
        {
            List<Retenciones> Result = null;
            using (var db = new Repositorio<Retenciones>())
            {
                try
                {
                    Result = db.Lista(busqueda).ToList(); //EntitySet.Where(busqueda).ToList();
                }
                catch
                {

                }
                return Result;
            }
        }
    }
}
