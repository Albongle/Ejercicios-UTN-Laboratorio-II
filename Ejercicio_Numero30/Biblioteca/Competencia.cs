using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia (short cantidadVueltas, short cantidadCompetidores)
            :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        //Generamos las sobrecarga de operadores para agregar, quitar competidores y de comparacion


        public static bool operator == (Competencia c, AutoF1 a)
        {
            bool returnAux = false;
            if(c.competidores.Count>0)
            {
                foreach (AutoF1 auto in c.competidores)
                {
                    if(auto == a)
                    {
                        returnAux = true;
                        break;
                    }
                }
            }
            //En esta sobre cargar vamos a comparar un AutoF1 con la competencia y determinar si este auto pertenece a la lista de competidores
            return returnAux;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            //Esta sobrecarga, agrega un auto a la competencia, si este no existe
            Random combustRamdon = new Random();
            bool returnAux = false;
            if (c.competidores.Count < c.cantidadCompetidores && c != a)//Evaluamos que la competencia aun tenca capacidad para aceptar competidores y si el competidor a agregar no existe
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.Combustible = (short)combustRamdon.Next(15, 100);
                c.competidores.Add(a);
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool returnAux = false;
            if(c==a)//Verificamos si el auto pertenece a la competencia y lo retiramos.
            {
                c.competidores.Remove(a);
                returnAux = true;
            }
            return returnAux;
        }

        //Generamos el metodo Mostrar Datos de la competencia
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Cantidad de vueltas en la competencia: {this.cantidadVueltas}");
            stringBuilder.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            //Imprimimos luego todos los competidores
            foreach (AutoF1 auto in this.competidores)
            {
                stringBuilder.AppendLine(auto.MostrarDatos());
            }

            return stringBuilder.ToString();
        }
    }
}
