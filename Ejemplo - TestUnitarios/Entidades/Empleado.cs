using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
    public class Empleado : Persona
    {
        #region "Atributos"
        private string legajo;
        private string contrato;
        private string funcion;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;
        private string telefono;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor de Empleado
        /// </summary>
        /// <param name="legajo">Legajo del Empleado</param>
        /// <param name="nombre">Nombre del Empleado</param>
        /// <param name="apellido">Apellido del Empleado</param>
        public Empleado(string legajo, string nombre, string apellido)
            : base(nombre, apellido)
        {
            this.Legajo = legajo;

        }
        /// <summary>
        /// Constructor con todos los atributos del Empleado
        /// </summary>
        /// <param name="legajo">Legajo del Empleado</param>
        /// <param name="contrato">Tipo de contrato del Empleado</param>
        /// <param name="funcion">Funcion del Empleado</param>
        /// <param name="horaInicio">Hora de Inicio de trabajo del Empleado</param>
        /// <param name="horaFin">Hora de Fin de trabajo del Empleado</param>
        public Empleado(string legajo, string nombre, string apellido, string contrato, DateTime fechaDeNacimiento, string dni, string telefono, string funcion, TimeSpan horaInicio, TimeSpan horaFin)
            : base(nombre, apellido,dni,fechaDeNacimiento)
        {

            this.Contrato = contrato;
            this.Funcion = funcion;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
            this.Telefono = telefono;
        }
        #endregion

        #region "Propiedades"
        public string Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                if (this.ValidaLegajo(value))
                {
                    this.legajo = value;
                }
                else
                {
                    throw new LegajoErroneoException("Legajo Erroneo");
                }
            }
        }


        public string Contrato { get { return this.contrato; } set { this.contrato = value; } }
        public string Funcion { get { return this.funcion; } set { this.funcion = value; } }
        public TimeSpan HoraInicio
        {
            get
            {
                return this.horaInicio;
            }
            set
            {
                if (this.ValidaHora(value, this.HoraFin) || this.HoraFin == TimeSpan.Zero)
                {

                    this.horaInicio = value;
                }
                else
                {
                    throw new Exception("Hora de Inicio Erronea");
                }

            }
        }
        public TimeSpan HoraFin
        {
            get
            {
                return this.horaFin;
            }
            set
            {
                if (this.ValidaHora(this.HoraInicio, value) || this.HoraInicio == TimeSpan.Zero)
                {
                    this.horaFin = value;
                }
                else
                {
                    throw new Exception("Hora de Fin Erronea");
                }
            }
        }
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                if (this.ValidaTelefono(value))
                {
                    this.telefono = value;
                }
                else
                {
                    throw new TelefonoErroneoException("Numero de Telefono erroneo, el formato debe ser (011 o 0351)15-1111-1111");
                }
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que valida el formato del legajo
        /// </summary>
        /// <param name="valor">Es el legajo a validar</param>
        /// <returns>True en caso de ser un legajo correcto, de lo contrario False</returns>
        private bool ValidaLegajo(string valor)
        {
            return base.ValidaCadenaTexto(valor, new Regex(@"^u[0-9]{6}"));
        }


        /// <summary>
        /// Metodo que valida que la hora de Fin no sea mayor que la de Inicio
        /// </summary>
        /// <param name="horaInicio">Hora de Inicio</param>
        /// <param name="horaFin">Hora de Fin</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        private bool ValidaHora(TimeSpan horaInicio, TimeSpan horaFin)
        {
            return (horaFin > horaInicio);
        }
        /// <summary>
        /// Matodo que valida que la cadena recibida sea un numero telefonico en un formato especifico (011 o 0351)15-1111-1111")
        /// </summary>
        /// <param name="valor">Es la cadena a evaluar</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        private bool ValidaTelefono(string valor)
        {
            return base.ValidaCadenaTexto(valor, new Regex(@"\([0-9]{3,4}\)[0-9]{2}\-[0-9]{4}\-[0-9]{3,4}"));
        }

        /// <summary>
        /// Metodo privado que realiza el calculo de horas entre dos intervalos
        /// </summary>
        /// <param name="horaInicio">Es la Hora de Inicio</param>
        /// <param name="horaFin">Es la Hora de Fin</param>
        /// <returns>La diferencia en cantidad de horas, 0 si la hora de Fin es menor a la de Inicio</returns>
        private double CargaHoraria(TimeSpan horaInicio, TimeSpan horaFin)
        {
            double returnAux = 0;
            if (this.ValidaHora(horaInicio, horaFin))
            {
                returnAux = (this.HoraFin - this.HoraInicio).TotalHours;
            }
            return returnAux;
        }


        /// <summary>
        /// Sobre escritura del matodo ToString que expone Legajo, Nombre y Apellido
        /// </summary>
        /// <returns>Todos los datos del Empleado</returns>
        public override string ToString()
        {
            return $"{this.Legajo} - {this.Apellido}, {this.Nombre}";
        }
        /// <summary>
        /// Metodo que expone todos los datos de Empleado
        /// </summary>
        /// <returns>Todos los datos del Empleado</returns>
        public override string MostrarDatos()
        {
            return $"{base.MostrarDatos()}" +
                $"\nLegajo: { this.Legajo}" +
                $"\nFuncion: {this.Funcion}" +
                $"\nContrato: {this.Contrato}" +
                $"\nTelefono: {this.Telefono}" +
                $"\nHora de Ingreso: {this.HoraInicio.ToString("HH:mm:ss")}" +
                $"\nHora de Salida: {this.HoraFin.ToString("HH:mm:ss")}" +
                $"\nCarga Horaria: {this.CargaHoraria(this.HoraInicio, this.HoraFin).ToString("0.00")}";
        }

        #endregion

        #region "Operadores"
        /// <summary>
        /// Dos empleados son iguales si coincide su Legajo
        /// </summary>
        /// <param name="empleado1">Empleado 1</param>
        /// <param name="empleado2">Empleado 2</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        public static bool operator ==(Empleado empleado1, Empleado empleado2)
        {
            return (empleado1.Legajo == empleado2.Legajo);
        }
        /// <summary>
        /// Dos empleados son distintos si no coincide su Legajo
        /// </summary>
        /// <param name="empleado1">Empleado 1</param>
        /// <param name="empleado2">Empleado 2</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        public static bool operator !=(Empleado empleado1, Empleado empleado2)
        {
            return !(empleado1 == empleado2);
        }
        #endregion
    }
}

