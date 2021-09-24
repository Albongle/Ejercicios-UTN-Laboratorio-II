using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Moto : Vehiculo
    {
        #region "Atributos"
        private static double valorHora;
        public enum ETipo {Ciclomotor, Scooter,Sport};
        private ETipo tipo;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor de clase que establece el valor de la hora por defecto para Moto
        /// </summary>
        static Moto()
        {
            valorHora = 100;
        }
        /// <summary>
        /// Constructor con parametros para Moto
        /// </summary>
        /// <param name="patente">Es la patente del Moto</param>
        /// <param name="horaIngreso">Es la hora de ingreso del Moto</param>
        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
            : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Establece el Valor de la Hora para Moto
        /// </summary>
        /// </summary>
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
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
        /// Devuelve el Tipo de Moto
        /// </summary>
        public override string Descripcion{ get { return this.tipo.ToString(); } }
        #endregion

        #region "Metodos"

        /// <summary>
        /// Sobreesctirura del metodo cargo de estacionamiento, multiplica el valor de la hora para Moto por la cantidad de horas
        /// </summary>
        /// <returns>El cargo de horas para Automovil</returns>
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****MOTO*****");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Tipo: {this.Descripcion}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
