using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroOrigen;
        protected string nroDestino;
        public enum TipoLlamada { Local, Provincial,Todas};

        public Llamada (float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public static int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            int returnAux = 0;
            if (llamada1.Duracion < llamada2.Duracion)
            {
                returnAux = -1;
            }
            else if(llamada1.Duracion > llamada2.Duracion)
            {
                returnAux = 1;
            }
            return returnAux;
        }

        public string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine($"La duracion de la llamadas es : {this.Duracion}");
            returnAux.AppendLine($"El numero de origen de la llamada es : {this.NroOrigen}");
            returnAux.AppendLine($"El numoer de destino de la llamadas es : {this.NroDestino}");
            return returnAux.ToString();
        }


    }
}
