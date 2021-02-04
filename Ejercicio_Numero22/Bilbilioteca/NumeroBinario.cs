using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario (string numero)
        {
            this.numero = numero;
        }


        public string Numero
        {
            get
            {
                return this.numero;
            }
        }


        public double BinarioDecimal(string valorRecibido)
        {
            double resultado = 0; //Valor a retornar, lo inicializamos en cero dado que si la cadena recibida no corresponder a un binario, restornamos cero
            int cantidadCaracteres = valorRecibido.Length; // guardamos la longitud de la cadena para saber hasta donde tenemos que ir calculando
            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }

        // Generamos la sobrecargar

        public static explicit operator NumeroBinario (string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator NumeroDecimal (NumeroBinario numeroBinario)
        {
            return (NumeroDecimal)numeroBinario.BinarioDecimal(numeroBinario.Numero);
        }

        //Generamos las sobrecargas de comparacion, operadores de suma y resta


        public static bool operator == (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.Numero == ((NumeroBinario)numeroDecimal).Numero;
        }
        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }

        public static string operator + (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalBinario(((NumeroDecimal)numeroBinario).Numero + numeroDecimal.Numero);
            //Usamos el metodo Decimal a Binario para convertir la suma de los dos numeros en decimal
        }
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalBinario(((NumeroDecimal)numeroBinario).Numero - numeroDecimal.Numero);
            //Usamos el metodo Decimal a Binario para convertir la resta de los dos numeros en decimal
        }
    }
}
