using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_Numero20
{
    class Program
    {/**
      * 20.	Generar un nuevo proyecto del tipo Console Application. Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dolar.
            a.	Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,08 dólares y 1 dólar equivale a 66 pesos.
            b.	El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
            c.	Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.
            d.	Colocar dentro del Main el código necesario para probar todos los métodos.
            e.	Los constructores estáticos le darán una cotización respecto del dólar por defecto a las clases.
            f.	Los comparadores == compararan cantidades.
            g.	Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido. Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.
            h.	Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.
      */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Numero 20";
            Euro billeteEuro = 1;
            Peso billetePeso = (Peso)billeteEuro;
            Dolar billeteDolar = 100;


            Console.WriteLine(billetePeso.GetCantidad);
            billetePeso = (Peso)billeteDolar;
            Console.WriteLine("Cantidad de Dolares convertidos a Pesos {0}",billetePeso.GetCantidad);
            Console.ReadKey();
        }
    }
}
