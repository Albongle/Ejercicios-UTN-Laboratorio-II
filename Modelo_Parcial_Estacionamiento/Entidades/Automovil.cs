using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Automovil : Vehiculo
    {
        #region "Atributos"
        private static double valorHora;
        private string marca;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor de clase que establece el valor de la hora por defecto para Automovil
        /// </summary>
        static Automovil()
        {
            Automovil.valorHora = 120;
        }
        /// <summary>
        /// Constructor con parametros para Automovil
        /// </summary>
        /// <param name="patente">Es la patente del Automovil</param>
        /// <param name="horaIngreso">Es la hora de ingreso del Automovil</param>
        public Automovil(string patente, DateTime horaIngreso, string marca)
            : base(patente, horaIngreso)
        {
            this.marca = marca;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Establece  el Valor de la Hora para Automovil
        /// </summary>
        public static double ValorHora
        {
            set
            {
                if(value>0)
                {
                    Automovil.valorHora = value;
                }
            }
        }
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        /// <summary>
        /// Devuelve el Tipo de Vehiculo
        /// </summary>
        public override string Descripcion { get { return this.marca; } }
        #endregion

        #region "Metodos"

        /// <summary>
        /// Sobreesctirura del metodo cargo de estacionamiento, multiplica el valor de la hora para Automovil por la cantidad de horas
        /// </summary>
        /// <returns>El cargo de horas para Automovil</returns>
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****AUTOMOVIL*****");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Marca: {this.Descripcion}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
