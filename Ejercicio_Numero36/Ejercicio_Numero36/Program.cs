using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_Numero36
{
    class Program
    {
        /*36.	Tomar como base el ejercicio 30 de esta guía. Agregar la clase VehiculoDeCarrera y la clase MotoCross:
            a.	Mover toda la información pedida a la clase VehiculoDeCarrera, modificando AutoF1, generando sus correspondientes propiedades.
            b.	Dos VehiculoDeCarrera son iguales si coincide su número y escudería.
            c.	Dos AutoF1 serán iguales cuando, además de coincidir los datos contenidos en VehiculoDeCarrera, coincida el atributo caballosDeFuerza.
            d.	Dos MotoCross son iguales si coincide cuando, además de coincidir los datos contenidos en VehiculoDeCarrera, coincida el atributo cilindrada.
            e.	El método Mostrar de VehiculoDeCarrera será el único capaz de exponer información de este tipo de objetos.
            f.	En la clase Competencia cambiar el tipo de la lista por VehiculoDeCarrera.
            g.	Si la competencia es declarada del tipo CarreraMotoCross, sólo se podrán agregar vehículos del tipo MotoCross. Si la competencia es del tipo F1, sólo se podrán agregar objetos AutoF1. Colocar dicha comparación dentro del == de la clase Competencia.
            h.	Modificar todo lo que sea necesario para que el sistema siga comportándose de la misma forma, aceptando también vehículos del tipo MotoCross en la competencia.*/
        static void Main(string[] args)
        {
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 20, Competencia.ETipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());
                if ((formulaUno + autos[i]))
                {
                    Console.WriteLine("Se Agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                }
                else
                {
                    Console.WriteLine("No se agrego ya que la competencia esta completa: {0}", autos[i].MostrarDatos());
                }
            }

            

            MotoCross motoCross = new MotoCross(5, "Motos");
            if (formulaUno + motoCross)
            {
                Console.WriteLine("Se agrego la moto");
            }
            else
            {
                Console.WriteLine("no se puede agregar la moto");
            }

            Console.WriteLine();
            Console.WriteLine("<-------------------------------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());

            Console.ReadKey();
        }
    }
}
