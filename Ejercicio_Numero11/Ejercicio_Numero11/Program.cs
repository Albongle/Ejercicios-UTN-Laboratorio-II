using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_Numero11
{
    class Program
    {
        /*  
         *  Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la siguiente firma: bool Validar(int valor, int min, int max):
            a.	valor: dato a validar
            b.	min y max: rango en el cual deberá estar la variable valor.
            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que esten dentro del rango -100 y 100.
            Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
            Nota: Utilizar variables escalares, NO utilizar vectores.*/
        static void Main(string[] args)
        {
            int ingreso;
            int max = int.MinValue;
            int min = int.MaxValue;
            int i = 0; // Variable que se usara para iterar en el DO WHILE
            int acumulado = 0; // Se inicializa la variable acumulador en cero
            float promedio;
            Console.Title = "Ejercicio Numero 11";
            do
            {
                Console.Clear();
                Console.WriteLine($"Ingrese el numero {i}: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if(Validacion.Validar(ingreso,-100,100))
                {
                    if(i==0 || ingreso>max)
                    {
                        max = ingreso;
                    }
                    if(i==0 || ingreso< min)
                    {
                        min = ingreso;
                    }
                    acumulado += ingreso;
                    i++;
                }
                else
                {
                    Console.WriteLine("Error. Debe ingresas un numero mayor que -100 y menor que 100");
                    Console.ReadKey();
                }

            } while (i < 10);

            promedio = (float)acumulado / i;
            Console.WriteLine($"El maximo es {max}, el minimo es {min} y el promedio es {promedio}");
            Console.ReadKey();
        }
    }
}
