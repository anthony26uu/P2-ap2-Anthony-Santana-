using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
  public  class EmpleadoBLL
    {
        public static bool Guardar(Entidades.Empleados empleado)
        {
            using (var conec = new ParcialDb())
            {
                try
                {

                    conec.EmpleadoDb.Add(empleado);

                    foreach (var g in empleado.RetencionesList)
                    {
                        conec.Entry(g).State = System.Data.Entity.EntityState.Unchanged;
                    }

                    conec.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
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

        public static Entidades.Empleados Buscar1(int id)
        {
            Entidades.Empleados emple = null;
            using (var conexion = new ParcialDb())
            {
                try
                {
                    emple = conexion.EmpleadoDb.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return emple;
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



        public static List<Retenciones> Listar(Expression<Func<Empleados, bool>> criterioBusqueda)
        {
            List<Retenciones> listado = new List<Retenciones>();
            List<Empleados> relaciones = null;
            using (var conexion = new ParcialDb())
            {
                try
                {
                    relaciones = conexion.EmpleadoDb.Where(criterioBusqueda).ToList();
                    foreach (var item in relaciones)
                    {
                        listado.Add(RetencionesBLL.BuscarID(item.RetencionId));
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
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
