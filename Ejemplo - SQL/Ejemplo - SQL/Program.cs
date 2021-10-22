using System;
using System.Configuration;
using Entidades;

namespace Ejemplo___SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorSQL sql = new GestorSQL();
            string mensaje = ConfigurationManager.AppSettings["mensaje"];

            Console.WriteLine($"{sql.ObtenerProvincia(10)}");
            Console.WriteLine($"Mensaje desde el configuration manager{mensaje}");
            Console.ReadKey();
        }
    }
}
