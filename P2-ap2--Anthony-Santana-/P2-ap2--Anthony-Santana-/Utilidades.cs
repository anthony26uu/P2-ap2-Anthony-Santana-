using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P2_ap2__Anthony_Santana_
{
  public  class Utilidades
    {
        public static int TOIN(string nombre)
        {
            int numero;
            int.TryParse(nombre, out numero);
            return numero;
        }
    }
}
