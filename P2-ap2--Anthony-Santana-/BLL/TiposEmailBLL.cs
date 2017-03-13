using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class TiposEmailBLL
    {

        public static bool Guardar(Entidades.TiposEmail nuevo)
        {
            bool retorno = false;
            using (var db = new Repositorio<Entidades.TiposEmail>())
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



        public static bool Mofidicar(TiposEmail existente)
{
    bool eliminado = false;
    using (var repositorio = new Repositorio<TiposEmail>())
    {
        eliminado = repositorio.Modificar(existente);
    }

    return eliminado;

}

public static bool Eliminar(TiposEmail existente)
{
    bool eliminado = false;
    using (var repositorio = new Repositorio<TiposEmail>())
    {
        eliminado = repositorio.Eliminar(existente);
    }

    return eliminado;

}



        public static TiposEmail Buscar(Expression<Func<TiposEmail, bool>> retencion)
{
            TiposEmail Result = null;
    using (var repoitorio = new Repositorio<TiposEmail>())
    {
        Result = repoitorio.Buscar(retencion);
    }

    return Result;
  }


  

        public static List<TiposEmail> Lista(Expression<Func<TiposEmail, bool>> busqueda)
 {
    List<TiposEmail> Result = null;
    using (var db = new Repositorio<TiposEmail>())
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
