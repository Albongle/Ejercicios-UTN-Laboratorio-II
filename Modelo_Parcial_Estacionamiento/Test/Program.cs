using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento miEstacionamiento = Estacionamiento.GetEstacionamiento("24HS", 5);
            Vehiculo[] vehiculos = { new Automovil("IZO718", DateTime.Now, "Ford"),
                new Automovil("EPX277", DateTime.Now, "Chevrolet"),
                new Automovil("IDW900", DateTime.Now, "VolksWagen"),
                new Automovil("IDW900", DateTime.Now, "VolksWagen"),
                new Moto("LDP123", DateTime.Now, Moto.ETipo.Scooter),
                new Moto("JUY866", DateTime.Now, Moto.ETipo.Ciclomotor),
                new Moto("AAA999", DateTime.Now, Moto.ETipo.Sport)};

            foreach (Vehiculo item in vehiculos)
            {
                if(miEstacionamiento+item)
                {
                    Console.WriteLine($"Se agregro{item.ToString()}");
                }else
                {
                    Console.WriteLine($"No se pudo Agregar{item.ToString()}");
                }
            }
            Console.ReadKey();
            Console.Clear();
            foreach (Vehiculo item in vehiculos)
            {
                if (miEstacionamiento - item)
                {
                    Console.WriteLine($"{miEstacionamiento.InformarSalida(item)}");
                }
                else
                {
                    Console.WriteLine($"No se pudo retirar{item.ToString()}");
                }
            }




            Console.ReadKey();
        }
    }
}
