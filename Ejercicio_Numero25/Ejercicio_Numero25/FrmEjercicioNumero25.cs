using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Ejercicio_Numero25
{
    public partial class FrmEjercicioNumero25 : Form
    {
        public FrmEjercicioNumero25()
        {
            InitializeComponent();
        }

        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            //Vamos a obtener de la caja de texto el valo en binario ingresado y vamos a convertirlo a decimal y guardarlo en la caja de texto resutladoDecimal
            this.txtResultadoDecimal.Text = ((NumeroDecimal)((NumeroBinario)this.txtBinario.Text)).Numero.ToString(); //Nos va a devolver un numero binario, para pasarlo a decimal le aplicamos otra conversion explicita
        }

        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            //Para este caso vamos a generar una variable Aux de tipo double y vamos a convertir el ingreso de la caja de texto a este.
            double ingresoAux;
            if(double.TryParse(this.txtDecimal.Text, out ingresoAux))
            {
                this.txtResultadoBinario.Text = ((NumeroBinario)((NumeroDecimal)ingresoAux)).Numero;
            }
            else
            {
                this.txtResultadoBinario.Text = "Datos erroneos";
            }
        }
    }
}
