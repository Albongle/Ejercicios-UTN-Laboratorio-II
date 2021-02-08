using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
          : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTodas
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                {
                    gananciaLocal += ((Local)llamada).CostoLlamada;
                }
                else if (llamada is Provincial)
                {
                    gananciaProvincial += ((Provincial)llamada).CostoLLamada;
                }
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    {
                        return gananciaLocal;

                    }
                case Llamada.TipoLlamada.Provincial:
                    {
                        return gananciaProvincial;
                    }
                default:
                    {
                        return gananciaLocal + gananciaProvincial;
                    }
            }
        }

        public string Mostrar ()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine($"La razon social es: ***** {this.razonSocial} *****");
            returnAux.AppendLine($"La ganancia total es : {this.GananciasPorTodas}");
            returnAux.AppendLine($"La ganancia local es : {this.GananciasPorLocal}");
            returnAux.AppendLine($"La ganancia provincial es : {this.GananciasPorProvincial}");
            returnAux.AppendLine("-------------------------------------------------------\n\n***** Listado de llamadas *****");
            foreach (Llamada llamada in this.Llamadas)
            {
                returnAux.AppendLine(llamada.Mostrar());
            }
            return returnAux.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
