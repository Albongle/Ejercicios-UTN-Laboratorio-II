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
        /// Metodo de clase que valida si el caracter es una S
        /// </summary>
        /// <param name="caracter">Caracter a validar</param>
        /// <returns>True en caso exitoso, False de lo contrario</returns>
        public static bool ValidarS_N(char caracter)
        {
            bool returnAux = false;
            if(char.ToUpper(caracter)=='S')
            {
                returnAux = true;
            }            
            return returnAux;
        }
    }
}
