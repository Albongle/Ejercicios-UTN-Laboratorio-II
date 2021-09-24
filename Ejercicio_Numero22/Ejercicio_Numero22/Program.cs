using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_Numero22
{
/*22.	Tomando la clase Conversor del ejercicio 13, se pide:
Agregar las clases:
a.	NumeroBinario:
i.	único atributo número (string)
ii.	único constructor privado (recibe un parámetro de tipo string)
b.	NumeroDecimal
i.	único atributo número (double)
ii.	único constructor privado (recibe un parámetro de tipo double)
Utilizando los métodos de la clase Conversor donde corresponda, agregar las sobrecargas de operadores:
c.	NumeroBinario:
i.	string + (NumeroBinario, NumeroDecimal)
ii.	string - (NumeroBinario, NumeroDecimal)
iii.	bool == (NumeroBinario, NumeroDecimal)
iv.	bool != (NumeroBinario, NumeroDecimal)
d.	NumeroDecimal: 
i.	double + (NumeroDecimal, NumeroBinario)
ii.	double - (NumeroDecimal, NumeroBinario)
iii.	bool == (NumeroDecimal, NumeroBinario)
iv.	bool != (NumeroDecimal, NumeroBinario)

Agregar conversiones implícitas para poder ejecutar:
e.	NumeroBinario objBinario = "1001";
f.	NumeroDecimal objDecimal = 9;
Agregar conversiones explícitas para poder ejecutar:
g.	(string)objBinario
h.	(double)objDecimal

Generar el código en el Main para instanciar un objeto de cada tipo y operar entre ellos, imprimiendo cada resultado por pantalla.
*/
    class Program
    {
        static void Main(string[] args)
        {
            //Probamos el codigo

            NumeroBinario numeroBinario = (NumeroBinario)"1111";
            NumeroDecimal numeroDecimal = (NumeroDecimal)8;

            Console.WriteLine($"El numero binario es {numeroBinario.Numero}, sumado con el decimal da un total de {numeroDecimal + numeroBinario}");

            Console.WriteLine($"El numero decimal es {numeroDecimal.Numero}, sumado con el binario da un total de {(numeroBinario + numeroDecimal)}");

            Console.WriteLine($"El numero binario es {numeroBinario.Numero}, resta con el decimal da un total de {numeroDecimal - numeroBinario}");
            Console.WriteLine($"El numero decimal es {numeroDecimal.Numero}, resta con el binario da un total de {(numeroBinario - numeroDecimal)}");
            Console.ReadKey();

        }
    }
}
