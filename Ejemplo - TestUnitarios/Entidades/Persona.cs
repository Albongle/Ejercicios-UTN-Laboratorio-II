using System;
using System.Text.RegularExpressions;
using Excepciones;

namespace Entidades
{
    public abstract class Persona
    {
        #region "Atributos"
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int dni;

        #endregion

        #region "Constructores"
        protected Persona(string nombre, string apellido)
        {

            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        protected Persona(string nombre, string apellido, string dni, DateTime fechaNac): this(nombre, apellido)
        {
            this.FechaDeNacimiento = fechaNac;
            this.Dni = dni;
        }
        #endregion

        #region "Atributos"
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (this.ValidaNombreApellido(value))
                {
                    this.apellido = value;
                }
                else
                {
                    throw new ApellidoONombreErroneoException("Apellido Erroneo");
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (this.ValidaNombreApellido(value))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new ApellidoONombreErroneoException("Nombre Erroneo");
                }
            }
        }
        public DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaDeNacimiento;
            }
            set
            {
                if (this.ValidaFecha(value, DateTime.Now))
                {
                    this.fechaDeNacimiento = value;
                }
                else
                {
                    throw new FechaNacimientoErroneaException("Fecha de Nacimiento Erronea");
                }

            }
        }
        public string Dni
        {
            set
            {
                if (!this.ValidaDni(value,out this.dni))
                {
                    throw new DniErroneoException("DNI Erroneo");
                }

            }
            get => this.dni.ToString("00000000");
        }

        public int DniNumero
        {
            get => this.dni;
        }

        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que valida el formato del Nombre y Apellido
        /// </summary>
        /// <param name="valor">Es la cadena de tecto a validar</param>
        /// <returns>True en caso de ser una cadena correcta, de lo contrario False</returns>
        private bool ValidaNombreApellido(string valor)
        {
            return this.ValidaCadenaTexto(valor, new Regex(@"^[a-zA-Z]+$"));
        }
        /// <summary>
        /// Metodo que la fecha de Fin no sea mayor a la de Inicio
        /// </summary>
        /// <param name="fechaInicio">Fecha de Inicio</param>
        /// <param name="fechaFin">Fecha de Fin</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        protected bool ValidaFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return (fechaFin > fechaInicio);
        }

        /// <summary>
        /// Metodo que valida que la cadena recibida sea un DNI y la convierte a INT
        /// </summary>
        /// <param name="valor">Es la cadena a evaluar</param>
        /// <returns>Un numero de DNI, 0 en caso de ser vacia o con un carracter erroneo, -1 si no pudoi convertir a INT</returns>
        private bool ValidaDni(string valor, out int dni)
        {
            bool returnAux = false;
            dni = -1;
            if (this.ValidaCadenaTexto(valor, new Regex(@"^[0-9]{8}$")))
            {
                if (int.TryParse(valor, out dni))
                {
                    returnAux = true;
                }
            }
            return returnAux;
        }


        /// <summary>
        /// Metodo utilizado para validar cadenas de Texto con Expresiones regulares
        /// </summary>
        /// <param name="valor">Es la cadena de Texto</param>
        /// <param name="expresion">Es la Expresion regular con la que se desea hacer Match</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        protected bool ValidaCadenaTexto(string valor, Regex expresion)
        {
            return expresion.IsMatch(valor);
        }
        public virtual string MostrarDatos()
        {
            return $"{this.Apellido}, {this.Nombre}" +
                $"\nDNI: {this.DniNumero}" +
                $"\nFecha de Nacimiento: {this.FechaDeNacimiento.ToString("dd/MM/yyyy")}";
        }
        public abstract override string ToString();
        #endregion
    }
}

