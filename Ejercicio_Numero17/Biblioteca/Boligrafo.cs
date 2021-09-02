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
            int tintaAux = this.tinta + tinta;

            
            if(tintaAux > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else if (tintaAux < 0)
            {
                this.tinta = 0;
            }
            else
            {
                //En el caso de que la operacion no supere los limites permitidos, simplemente sumo
                this.tinta += tinta;
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
            if(this.tinta==0)
            {
                dibujo = "No se puede Pintar ya que no se posee tinta";
            }
            else
            {
                //Generamos un bucle para ir adicionando * a cadena Aux segun el gasto de tinta a realizar

                while (gasto>0 && this.tinta>0)
                {
                    cadenaAux += "*";
                    gasto--; //decrementamos el gasto recibido
                    this.SetTinta(-1); //gastamos tinta
                }
                dibujo = cadenaAux;
                returAux = true;
                
            }
            return returAux;
        }
        #endregion
    }
}
