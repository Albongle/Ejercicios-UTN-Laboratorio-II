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
        private List<VehiculoDeCarrera> competidores;
        public enum ETipoCompetencia { F1, MotoCross };
        private ETipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, ETipoCompetencia tipo)
            : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if(!object.ReferenceEquals(this.competidores,null) && i>=0 && i<= this.competidores.Count) 
                {
                    return this.competidores[i];
                }
                return null;
            }
        }
        public ETipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        //Generamos las sobrecarga de operadores para agregar, quitar competidores y de comparacion


        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = false;
            //Evaluamos si el vehiculo a comparar con la competencia, es del mismo tipo y por otro lado evaluamos que este vehiculo se encuentre en la competencia.
            //Rotornamos true si el vehiculo pertenece a la competencia o bien si el vehiculo difiere con el tipo de competencia
            if((c.Tipo == Competencia.ETipoCompetencia.F1 && v.GetType() == typeof(AutoF1)) || (c.Tipo == Competencia.ETipoCompetencia.MotoCross && v.GetType() == typeof(MotoCross)))
            {
                if (c.competidores.Count > 0)
                {
                    foreach (VehiculoDeCarrera vehiculo in c.competidores)
                    {
                        if (vehiculo == v)
                        {
                            returnAux = true;
                            break;
                        }
                    }
                }
            }

            //En esta sobre cargar vamos a comparar un AutoF1 con la competencia y determinar si este auto pertenece a la lista de competidores
            return returnAux;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            //Esta sobrecarga, agrega un auto a la competencia, si este no existe
            Random combustRamdon = new Random();
            bool returnAux = false;
            if (c.competidores.Count < c.cantidadCompetidores && c != v)//Evaluamos que la competencia aun tenca capacidad para aceptar competidores y si el competidor a agregar no existe
            {
                v.EnCompetencia = true;
                v.VueltasRestantes = c.cantidadVueltas;
                v.Combustible = (short)combustRamdon.Next(15, 100);
                c.competidores.Add(v);
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = false;
            if (c == v)//Verificamos si el auto pertenece a la competencia y lo retiramos.
            {
                c.competidores.Remove(v);
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
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                if (vehiculo.GetType() == typeof(AutoF1))
                {
                    stringBuilder.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                }
                else if (vehiculo.GetType() == typeof(MotoCross))
                {
                    stringBuilder.AppendLine(((MotoCross)vehiculo).MostrarDatos());
                }
            }
            return stringBuilder.ToString();
        }
    }
}
