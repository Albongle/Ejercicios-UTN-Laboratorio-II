using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local (Llamada llamada, float costo)
            :base (llamada.Duracion,llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string nroOrigen, float duracion, string nroDestino, float costo)
            :this(new Llamada(duracion,nroDestino, nroOrigen), costo)
        {
            
        }

        public float CostoLlamada
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
    }
}
