using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_Numero13
{
    class Program
    {
        /*13.	Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
            string DecimalBinario(int). Convierte un número de entero a binario.
            int BinarioDecimal(string). Convierte un número binario a entero.*/
        static void Main(string[] args)
        {
            int ingresoDecimal;
            string ingresoBinario;
            string binario;
            int numeroDecimal;
            Console.WriteLine("Ingrese el numero en Decimal: ");
            int.TryParse(Console.ReadLine(), out ingresoDecimal);
            binario = Conversor.DecimalBinario(ingresoDecimal);
            Console.WriteLine($"El resultado en Binario es {binario}");

            Console.WriteLine("ingrese el numero en Binario: ");
            ingresoBinario = Console.ReadLine();
            numeroDecimal = Conversor.BinarioDecimal(ingresoBinario);
            Console.WriteLine($"El resultado en Decimal es {numeroDecimal}");
            Console.ReadKey();

        }
    }
}
