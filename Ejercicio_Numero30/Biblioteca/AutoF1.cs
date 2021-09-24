using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1 (short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
        }
        //Generamos los Get Y Set

        public short Combustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        //Generamos las sobrecargas de comparacion

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia && a1.numero == a2.numero;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        //Generamos el metodo Mostrar Datos

        public string MostrarDatos()
        {
            return $"El auto numero: {this.numero}" +
                $"\nEscuderia: {this.escuderia}" +
                $"\nEn competencia: {this.EnCompetencia}" +
                $"\nCantidad de combustible: {this.Combustible}" +
                $"\nVueltas restantes: {this.VueltasRestantes}";
        }
    }
}
