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

        public static Entidades.Retenciones BuscarID(int id)
        {
            Entidades.Retenciones retencion = null;
            using (var conexion = new ParcialDb())
            {
                try
                {
                    retencion = conexion.RetencionesDb.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return 
                retencion;
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


        public static List<Entidades.Retenciones> GetListodo()
        {
            List<Entidades.Retenciones> lista = new List<Entidades.Retenciones>();
            using (var db = new DAL.Repositorio<Retenciones>())
            {
                try
                {
                    return db.ListaTodo();
                }
                catch (Exception)
                {

                    throw;
                }
           
            }
        }

        public static List<Entidades.Retenciones> Listar1(Expression<Func<Empleados, bool>> criterioBusqueda)
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
