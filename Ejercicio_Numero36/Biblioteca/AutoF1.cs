using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1 (short numero, string escuderia)
            :base(numero, escuderia)
        {
            base.Combustible = 0;
            base.VueltasRestantes = 0;
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            :this(numero,escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && (a1.CaballosDeFuerza == a2.CaballosDeFuerza);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        //Generamos el metodo Mostrar Datos

        public string MostrarDatos()
        {
            return $"El auto numero: {base.Numero}" +
                $"\nEscuderia: {base.Escuderia}" +
                $"\nEn competencia: {base.EnCompetencia}" +
                $"\nCantidad de combustible: {base.Combustible}" +
                $"\nVueltas restantes: {base.VueltasRestantes}";
        }
    }
}
