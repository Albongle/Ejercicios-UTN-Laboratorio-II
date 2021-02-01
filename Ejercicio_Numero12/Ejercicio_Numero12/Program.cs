using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_Numero12
{
    class Program
    {
        /**
         * 12.	Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje "¿Continuar? (S/N)".
            En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/

        static void Main(string[] args)
        {
            int ingreso;
            int i = 0;
            int acumulado = 0;
            Console.Title = "Ejercicio Numero 12";
            do
            {
                Console.Clear();
                i++;
                Console.WriteLine($"Ingrese el numero {i}");
                if(int.TryParse(Console.ReadLine(), out ingreso))
                {
                    acumulado += ingreso;
                }
                Console.WriteLine($"Desea seguir ingresando numeros? (s/n)\n");

            } while (Validacion.ValidarS_N(Console.ReadKey().KeyChar));

            Console.WriteLine($"\nEl resultado de la suma es {acumulado}");
            Console.ReadKey();
        }
    }
}
