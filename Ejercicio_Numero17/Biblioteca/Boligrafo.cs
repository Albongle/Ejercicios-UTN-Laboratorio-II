using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        #region Atributos
        //Generamos los atributos para boligrafo
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region Constructor
        //Generamos el constructor para Boligrafo
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        #endregion

        #region Metodos
        //Generamos los metodos Get

        /// <summary>
        /// Metodo publico para obtener el color del boligrafo
        /// </summary>
        /// <returns>el color del boligrafo</returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        /// <summary>
        /// Metodo publico para obtener la cantidad de tinta del boligafo
        /// </summary>
        /// <returns>la cantidad de tinta del boligafo</returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        //Generamos el Metodo privado SetTinta

        /// <summary>
        /// Metodo privado que carga o gasta tinta 
        /// </summary>
        /// <param name="tinta">es la cantidad de tinta</param>
        private void SetTinta(short tinta)
        {
            //Inicialmente validamos si el dato recibido es mayor o menor que cero, para determinar si se va a gastar o cargar tinta
            if (tinta > 0)
            {
                //Dentro de este if vamos a recargar tinta
                //Validamos si la tinta existente del objeto mas la recibida no es mayor a la capacidad maxima, en caso de ser mayor asignamos el tope, de lo contrario sumamos
                if ((this.tinta + tinta) > cantidadTintaMaxima)
                {
                    this.tinta = cantidadTintaMaxima;
                }
                else
                {
                    this.tinta += tinta;
                }
            }
            else if (tinta < 0)
            {
                //Si tinta es menor que cero es porque se va a gastar tinta
                //validamos si el objeto tiene tinta mayor a cero como para poder gastar
                if (this.tinta > 0)
                {
                    if ((this.tinta + tinta) < 0) //Si el descuento de tinta mas la tinta existente devuelve un valor negativo, establecemos el valor en cero
                    {
                        this.tinta = 0;
                    }
                    else
                    {
                        this.tinta += tinta; //Sumamos ya que vamos a estar recibiendo un valor negativo, de esta manera descontamos.
                    }
                }
            }
        }

        //Generamos el metodo recargar

        /// <summary>
        /// Setea la cantidad de tinta en su maximo posible
        /// </summary>
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        //Generamos el metodo Pintar

        /// <summary>
        /// Diujara tantos astericos como tinta se quiera y pueda gastar, en caso de no poseer tinta asignara "No se puede Pintar ya que no se posee tinta"
        /// </summary>
        /// <param name="gasto">Es la cantidad de tinta a gastar</param>
        /// <param name="dibujo">variable por referencia donde se va almacenar el resultado del dibujo</param>
        /// <returns>True en caso de haber podido dibujar, de lo contrario False</returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = string.Empty;
            bool returAux = false;
            short cont = 0;
            if(this.tinta==0)
            {
                dibujo = "No se puede Pintar ya que no se posee tinta";
            }
            else
            {
                //Generamos un bucle para ir adicionando * a cadena Aux segun el gasto de tinta a realizar

                while (gasto>0 && (this.tinta+cont)>0)
                {
                    cadenaAux += "*";
                    cont--;
                    gasto--;
                }
                dibujo = cadenaAux;
                returAux = true;
                this.SetTinta(cont); //seteamos el nivel de tinta segun el gasto que se realizo
            }
            return returAux;
        }
        #endregion
    }
}
