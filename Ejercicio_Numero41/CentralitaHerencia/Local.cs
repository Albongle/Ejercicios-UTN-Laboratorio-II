using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        /*  d.	Sobreescribir el método Mostrar. Será protegido. Reutilizará el código escrito en la clase base y además agregará la propiedad CostoLlamada, utilizando un StringBuilder.
            e.	Equals retornará true sólo si el objeto que recibe es de tipo Local.
            f.	ToString reutilizará el código del método Mostrar.

         */
        protected float costo;

        public Local (Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
            this.costo = costo;
        }
        public Local(string nroOrigen, float duracion, string nroDestino, float costo)
            :base(duracion,nroDestino,nroOrigen)
        {
            this.costo = costo;   
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }
        protected override string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine(base.Mostrar());
            returnAux.AppendLine($"El costo de la llamada local es: {this.CostoLlamada}");
            return returnAux.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Local;    
        }
        public override string ToString()
        {
            return this.Mostrar(); 
        }
    }
}
