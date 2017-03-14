using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
  public  class EmpleadosRetenciones
    {
        public static bool Guardar(Entidades.EmpleadosRetenciones relacion)
        {
            bool resultado = false;
            using (var conexion = new ParcialDb())
            {
                try
                {
                    conexion.EmpleadosDecuentosDb.Add(relacion);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }

        public static bool Guardar(List<Entidades.EmpleadosRetenciones> listado)
        {
            bool resultado = false;
            try
            {
                foreach (var relacion in listado)
                {
                    resultado = Guardar(relacion);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }


        public static bool Mofidicar(Entidades.EmpleadosRetenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.EmpleadosRetenciones>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static List<Entidades.Retenciones> ListarRetenciones(Expression<Func<Entidades.EmpleadosRetenciones, bool>> criterioBusqueda)
        {
            List<Entidades.Retenciones> listado = new List<Entidades.Retenciones>();
            List<Entidades.EmpleadosRetenciones> relaciones = null;
            using (var conexion = new ParcialDb())
            {
                try
                {
                    relaciones = conexion.EmpleadosDecuentosDb.Where(criterioBusqueda).ToList();
                    foreach (var item in relaciones)
                    {
                        listado.Add(RetencionesBLL.BuscarID(item.EmpleadoId));
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }

        public static List<Entidades.Empleados> ListarEmmpleados(Expression<Func<Entidades.EmpleadosRetenciones, bool>> criterioBusqueda)
        {
            List<Entidades.Empleados> listado = new List<Entidades.Empleados>();
            List<Entidades.EmpleadosRetenciones> relaciones = null;
            using (var conexion = new ParcialDb())
            {
                try
                {
                    relaciones = conexion.EmpleadosDecuentosDb.Where(criterioBusqueda).ToList();
                    foreach (var item in relaciones)
                    {
                        listado.Add(EmpleadoBLL.BuscarID(item.EmpleadoId));
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }
    }
}
