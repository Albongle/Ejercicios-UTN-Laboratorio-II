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
            string dibujo; //Variable para dibujar


            Boligrafo boligrafoDarkYellow = new Boligrafo(15, ConsoleColor.DarkYellow);
            Console.ForegroundColor = boligrafoDarkYellow.GetColor();
            boligrafoDarkYellow.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);

            Console.ForegroundColor = colorOriginalDeConsola;
            Console.WriteLine($"El nivel de tinta del boligrafo DarkYellow es {boligrafoDarkYellow.GetTinta()}");
            boligrafoDarkYellow.Pintar(5, out dibujo);
            Console.ForegroundColor = boligrafoDarkYellow.GetColor();

            Console.WriteLine(dibujo);
            
            Console.ForegroundColor = colorOriginalDeConsola;

            Console.WriteLine($"El nivel de tinta del boligrafo DarkYellow es {boligrafoDarkYellow.GetTinta()}");
            Console.WriteLine("\n\nIntentamos volver a gastar tinta");
            boligrafoDarkYellow.Pintar(3, out dibujo);
            Console.WriteLine(dibujo);
            Console.ReadKey();

        }
    }
}
