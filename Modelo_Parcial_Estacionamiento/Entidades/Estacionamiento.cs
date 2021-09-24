using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        #region "Atributos"
        private int capacidadEstacionamiento;
        private string nombre;
        private List<Vehiculo> listadoVehiculos;
        private static Estacionamiento estacionamiento;

        #endregion
        #region "Constructores"
        /// <summary>
        /// Constructor de Estacionamiento
        /// </summary>
        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }
        #endregion

        #region "Propiedades"
        public List<Vehiculo> ListadoVehiculos
        {
            get { return this.listadoVehiculos; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }

        #endregion

        #region "Metodos"
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Retiro Estacionamiento {this.nombre}");
            sb.AppendLine(vehiculo.ToString());
            sb.AppendLine($"Hora de salida: {vehiculo.HoraEgreso}");
            sb.AppendLine($"El cargo por estacionamiento es: {vehiculo.CostoEstadia.ToString("00.0")}");
            return sb.ToString();
        }
        #endregion
        #region "Operadores"
        /// <summary>
        /// Agrega un nuevo vehiculo al estacionamiento
        /// </summary>
        /// <param name="estacionamiento">Es el estacionamiento donde se va a agregar el vehiculo</param>
        /// <param name="vehiculo">Es el vehiculo a agregar al estacionamiento</param>
        /// <returns>Los datos del vehiculo ingresado</returns>
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returnAux = false;
            if (estacionamiento.listadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                Estacionamiento.estacionamiento.listadoVehiculos.Add(vehiculo);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returnAux = false;
            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                Estacionamiento.estacionamiento.listadoVehiculos.Remove(vehiculo);
                returnAux = true;
            }

            return returnAux;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Verifica si un vehiculo pertece al Estacionamiento
        /// </summary>
        /// <param name="estacionamiento">Es el estacionamiento donde se va bucar el vehiculo</param>
        /// <param name="vehiculo">Es el vehiculo a buscar en el estacionamiento</param>
        /// <returns>True en caso de pertenecer al estacionamiento, de lo contrario False</returns>
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returAux = false;
            if (Estacionamiento.estacionamiento.listadoVehiculos.Count > 0)
            {
                foreach (Vehiculo v in estacionamiento.listadoVehiculos)
                {
                    if (v == vehiculo)
                    {
                        returAux = true;
                        break;
                    }
                }
            }
            return returAux;
        }
        /// <summary>
        /// Verifica si un vehiculo NO pertece al Estacionamiento
        /// </summary>
        /// <param name="estacionamiento">Es el estacionamiento donde se va bucar el vehiculo</param>
        /// <param name="vehiculo">Es el vehiculo a buscar en el estacionamiento</param>
        /// <returns>True en caso de NO pertenecer al estacionamiento, de lo contrario False</returns>
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        #endregion
    }
}
