using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public abstract class Vehiculo
    {
        #region "Atributos"
        public enum EVehiculos { Automovil, Moto };
        private DateTime horaIngreso;
        private DateTime horaEgreso;
        private string patente;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor con parametros para Vehiculos
        /// </summary>
        /// <param name="patente">Es la patente del vehiculo</param>
        /// <param name="horaIngreso">Es la hora en la que ingresa el vehiculo</param>
        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.Patente = patente;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Establece y devuelve la patente del vehiculo
        /// </summary>
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (this.ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }
        /// <summary>
        /// Devuelve el tipo de Vehiculo "Automovil, Camioneta o Moto"
        /// </summary>
        public abstract string Descripcion{ get; }
        public abstract double CostoEstadia{ get; }
        /// <summary>
        /// Estableces y devuelve la hora de ingreso del Vehiculo
        /// </summary>
        public DateTime HoraIngreso { get { return this.horaIngreso; }}
        /// <summary>
        /// Esteblece y devuelve la hora de egreso del vehiculo. Esta no puede ser menor a la de ingreso
        /// </summary>
        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if (value > this.HoraIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo privado que validara que la patente recibida sea correcta.
        /// Esta solo debe poseer solamente numeros, letras. Siendo la cantidad de caracteres en 6 y 7
        /// </summary>
        /// <param name="patente">Es la patente a validar</param>
        /// <returns>True en caso de una patente valida, de lo contrario False</returns>
        private bool ValidarPatente(string patente)
        {
            bool returnAux = false;
            if (!string.IsNullOrEmpty(patente) && patente.Length >= 6 && patente.Length < 8)
            {
                returnAux = true;
            }
            return returnAux;
        }
        /// <summary>
        /// Metodo virtual usado para aplicar un cargo de estacionamiento para los vehiculos.
        /// </summary>
        /// <returns>La cantidad de horas generadas por el vehiculo</returns>
        protected virtual double CargoDeEstacionamiento()
        {
            double horasAcumuladas=  0;
            if (this.HoraEgreso > this.HoraIngreso)
            {
                horasAcumuladas = (this.HoraEgreso - this.HoraIngreso).TotalHours;
            }
            return horasAcumuladas;
        }
        /// <summary>
        /// Metodo protegido que muestra los datos del vehiculo
        /// </summary>
        /// <returns>Los datos del vehiculo</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine($"Patente {this.Patente}");
            returnAux.AppendLine($"Ingreso: {this.HoraIngreso} ");
            return returnAux.ToString();
        }

        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Dos vehiculos son iguales si su patente es igual
        /// </summary>
        /// <param name="v1">Es el primer vehiculo a comprar</param>
        /// <param name="v2">Es el segundo vehiculo a comparar</param>
        /// <returns>True si los vehiculos son iguales, de lo contrario False</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1">Es el primer vehiculo a comprar</param>
        /// <param name="v2">Es el segundo vehiculo a comparar</param>
        /// <returns>True si los vehiculos son distintos, de lo contrario False</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}

