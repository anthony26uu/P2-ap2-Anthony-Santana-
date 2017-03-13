using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
  public  class EmpleadoBLL
    {

        public static bool Guardar(Entidades.Empleados nuevo)
        {
            bool retorno = false;
            using (var db = new Repositorio<Entidades.Empleados>())
            {
                try
                {
                    retorno = db.Guardar(nuevo) != null;
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return retorno;

        }



        public static bool Mofidicar(Entidades.Empleados  existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Empleados >())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.Empleados existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Empleados>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }


        public static Entidades.Empleados BuscarID(int id)
        {
            Entidades.Empleados empleado = null;
            using (var conexion = new ParcialDb())
            {
                try
                {
                    empleado = conexion.EmpleadoDb.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return empleado;
        }


        public static Entidades.Empleados Buscar(Expression<Func<Entidades.Empleados, bool>> retencion)
        {
            Entidades.Empleados Result = null;
            using (var repoitorio = new Repositorio<Entidades.Empleados>())
            {
                Result = repoitorio.Buscar(retencion);
            }

            return Result;
        }




        public static List<Entidades.Empleados> Lista(Expression<Func<Entidades.Empleados, bool>> busqueda)
        {
            List<Entidades.Empleados> Result = null;
            using (var db = new Repositorio<Entidades.Empleados>())
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
