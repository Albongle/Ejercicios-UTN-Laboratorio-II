using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;


namespace Ejercicio_Numero17
{
    class Program
    { 
        
        /*17.	Crear la clase Bolígrafo a partir del siguiente diagrama:*/
        static void Main(string[] args)
        {
            ConsoleColor colorOriginalDeConsola = Console.ForegroundColor;
            string dibujo;
            Boligrafo boligrafoAzul = new Boligrafo(15, ConsoleColor.Blue);
            Console.ForegroundColor = boligrafoAzul.GetColor();
            boligrafoAzul.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);

            Console.ForegroundColor = colorOriginalDeConsola;
            Console.WriteLine($"El nivel de tinta del boligrafo azul es {boligrafoAzul.GetTinta()}");
            boligrafoAzul.Pintar(5, out dibujo);
            Console.WriteLine(dibujo);
            

            Console.WriteLine("Intentamos volver a gastar tinta\n\n");
            boligrafoAzul.Pintar(3, out dibujo);
            Console.WriteLine(dibujo);
            Console.ReadKey();

        }
    }
}
