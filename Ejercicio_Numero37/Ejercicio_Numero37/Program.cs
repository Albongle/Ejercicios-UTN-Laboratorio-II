using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Ejercicio_Numero37
{
    class Program
    {
        /*37.	Centralita – Herencia
                Esta aplicación servirá de control de llamadas realizadas en una
                central telefónica.
                a.	Crear en una solución llamada CentralTelefonica un proyecto de tipo Biblioteca de Clases nombrado como CentralitaHerencia que contenga la siguiente jerarquía de clases:
                    Llamada:
                b.	La clase Llamada, tendrá todos sus atributos con el modificador protected. Crear las propiedades de sólo lectura para exponer estos atributos.
                c.	OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente.
                d.	Mostrar es un método de instancia. Utiliza StringBuilder.
                Local:
                e.	Heredará de Llamada.
                f.	Método Mostrar expondrá, además de los atributos de la clase base, la propiedad CostoLlamada. Utilizar StringBuilder.
                g.	CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
                h.	La propiedad CostoLlamada retornará el precio, que se calculará en el método CalcularCosto.
                Provincial:
                i.	Hederará de Llamada
                j.	Método Mostrar expondrá, además de los atributos de la clase base, la propiedad CostoLlamada y franjaHoraria. Utilizar StringBuilder.
                k.	CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma. Los valores serán: Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
                    Centralita:
                l.	CalcularGanancia será privado. Este método recibe un Enumerado TipoLlamada y retornará el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local, Provincial o de Todas según corresponda).
                m.	El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
                n.	La lista sólo se inicializará en el constructor por defecto Centralita().
                o.	Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el precio de lo facturado según el criterio. Dichos valores se calcularán en el método CalcularGanancia().
                Generar un nuevo proyecto del tipo Console Application llamado Test. El namespace también deberá llamarse Test. Agregar el siguiente código en el Main para probar la Centralita.

                // Mi central
                Centralita c = new Centralita("Fede Center");

                // Mis 4 llamadas
                Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
                Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
                Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
                Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

                // Las llamadas se irán registrando en la Centralita.
                // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
                c.Llamadas.Add(l1);
                Console.WriteLine(c.Mostrar());
                c.Llamadas.Add(l2);
                Console.WriteLine(c.Mostrar());
                c.Llamadas.Add(l3);
                Console.WriteLine(c.Mostrar());
                c.Llamadas.Add(l4);
                Console.WriteLine(c.Mostrar());

                c.OrdenarLlamadas();
                Console.WriteLine(c.Mostrar());

                Console.ReadKey();
        

*/
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());
            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
