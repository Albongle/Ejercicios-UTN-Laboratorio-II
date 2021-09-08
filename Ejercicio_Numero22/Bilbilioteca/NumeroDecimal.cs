using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NumeroDecimal
    {
        //Generamos atributos y constructores

        private double numero;
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get
            {
                return this.numero;
            }
        }

        //Copiamos del Ejercicio 13 los metodos de conversion
        //Remplazamos el tipo de variables de ingreso del metodo

        public string DecimalBinario(double numero)
        {
            string valorBinario = string.Empty; //variable que vamos a retornar
            int resultDiv = (int)numero;
            int restoDiv;
            //Generamos dos variables una para verificar si el resultado de la division es igual a 0 y otra para verificar el resto

            do
            {
                restoDiv = resultDiv % 2;
                resultDiv /= 2;
                valorBinario = restoDiv.ToString() + valorBinario; // lo hago de esta manera para ir dejando la ultima division en la primer posicion
            } while (resultDiv > 0);


            return valorBinario;
        }

        //Generamos las sobrecargas

        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.DecimalBinario(numeroDecimal.Numero);
        }
        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero == ((NumeroDecimal)numeroBinario).Numero;
        }
        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }
        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero + ((NumeroDecimal)numeroBinario).Numero;
        }
        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero - ((NumeroDecimal)numeroBinario).Numero;
        }
    }
}
