using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validacion
    {
        /// <summary>
        /// Metodo de clase que valida si un determinado valor se encuentra dentro de un rango determinado
        /// </summary>
        /// <param name="valor">Es el valor a validar</param>
        /// <param name="min">Es el rango minimo permitido</param>
        /// <param name="max">Es el rago maximo permitido</param>
        /// <returns>True en caso de ser un valor dentro del rango establecio, de lo contrario False</returns>
        public static bool Validar (int valor, int min, int max)
        {
            bool returnAux = false;
            if(valor>=min && valor <=max)
            {
                returnAux = true;
            }
            return returnAux;
        }
    }
}
