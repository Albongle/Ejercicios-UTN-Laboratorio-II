using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        /*  g.	El método Mostrar será protegido. Reutilizará el código escrito en la clase base y agregará franjaHoraria y CostoLlamada, utilizando un StringBuilder.
            h.	Equals retornará true sólo si el objeto que recibe es de tipo Provincial.
            i.	ToString reutilizará el código del método Mostrar.

         */
        public enum Franja { Franja_1, Franja_2, Franja_3 };
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string nroOrigen, Franja miFranja, float duracion, string nroDestino)
            :base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }

        }

        private float CalcularCosto()
        {
            float returnAux = 0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    {
                        returnAux = base.Duracion * (float)0.99;
                        break;
                    }
                case Franja.Franja_2:
                    {
                        returnAux = base.Duracion * (float)1.25;
                        break;
                    }
                default:
                    {
                        returnAux = base.Duracion * (float)0.66;
                        break;
                    }
            }
            return returnAux;
        }
        protected override string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine(base.Mostrar());
            returnAux.AppendLine($"La franja horaria es: {this.franjaHoraria}");
            returnAux.AppendLine($"El costo de la llamada provincial es: {this.CostoLlamada}");
            return returnAux.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
