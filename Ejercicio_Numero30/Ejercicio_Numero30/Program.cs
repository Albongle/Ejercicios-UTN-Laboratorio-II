using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_Numero30
{
    /*30.	Diseñar una clase llamada Competencia y otra AutoF1 con los siguientes atributos y métodos:
     AutoF1:
    a.	Al generar un auto se cargará enCompetencia como falso y cantidadCombustible y vueltasRestantes en 0.
    b.	Dos autos serán iguales si el número y escudería son iguales.
    c.	Realizar los métodos getters y setters para cantidadCombustible, enCompetencia y vueltasRestantes.
    Competencia:
    d.	El constructor privado será el único capaz de inicializar la lista de competidores.
    e.	La sobrecarga + agregará un competidor si es que aún hay espacio (validar con cantidadCompetidores) y el competidor no forma parte de la lista (== entre Competencia y AutoF1).
    f.	Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia y se le asignará un número random entre 15 y 100 a cantidadCombustible.
    Generar los métodos en el Main para probar el código.*/
    class Program
    {
        static void Main(string[] args)
        {
            //Generamos codigo para probar las clases
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 5);
            AutoF1[] autos = new AutoF1[10];
            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());
                if ((formulaUno + autos[i]) == true)
                {
                    Console.WriteLine("Se Agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                }
                else
                {
                    Console.WriteLine("No se agrego ya que la competencia esta completa: {0}", autos[i].MostrarDatos());
                }
            }

            Console.WriteLine();
            Console.WriteLine("<-------------------------------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());

            Console.ReadKey();
        }
    }
}
