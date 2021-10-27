using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Ejemplo____Delegados
{
    class Program
    {

        public delegate string MiDelegado(string value);
        static Predicate<int> predicate = (int value) =>
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        };
        Func<int, int> funcion = (int algo) => algo;


        static void Main(string[] args)
        {

            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            MiDelegado delegado = MostrarMensaje;
            delegado += MostrarMensaje2;
            delegado += MostrarMensaje3;

            //foreach (var item in delegado.GetInvocationList())
            //{
            //    string mensaje = ((MiDelegado)item).Invoke("Hola Mundo");
            //    Console.WriteLine(mensaje);
            //}



            Console.WriteLine(delegado("Hola Mundo"));
            //numeros.Sort((x, y) => y - x);
            //numeros.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }

        public static string MostrarMensaje(string mensaje)
        {
            return $"El mensaje recibido desde MostrarMensaje es {mensaje}";
        }
        public static string MostrarMensaje2(string mensaje)
        {
            return $"El mensaje recibido desde MostrarMensaje2 es {mensaje}";
        }
        public static string MostrarMensaje3(string mensaje)
        {
            return $"El mensaje recibido desde MostrarMensaje3 es {mensaje}";
        }


    }
}
