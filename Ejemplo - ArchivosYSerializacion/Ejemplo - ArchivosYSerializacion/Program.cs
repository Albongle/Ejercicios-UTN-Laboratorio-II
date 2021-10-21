using System;
using System.Collections.Generic;
using Entidades;

namespace Ejemplo___ArchivosYSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {

            GestorArchivo gda = new GestorArchivo();
            Persona p = new Persona("Jose", "Perez", 34);
         
            

            try
            {
                gda.Tipo = IArchivos<Persona>.ETipoArchivo.JSON;
                ((IArchivos<Persona>)gda).Escribir(p, "GDA2.json");
                Console.WriteLine("Listo");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


            Console.ReadKey();
        }
    }
}
