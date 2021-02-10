using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
using System.Threading;

namespace CentralitaFormulario
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmbFranja.Enabled = false;
        }
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Generamos un metodo privado para ir cargando los numeros al marcar.

        private void CargarNumero (string digitoPresionado)
        {
            if(this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }
            this.txtNroDestino.Text += digitoPresionado;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn9.Text);
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnAsterisco.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn0.Text);
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnNumeral.Text);
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(this.txtNroDestino.Text.IndexOf('#')==0)
            {
                this.cmbFranja.Enabled = true;
            }
            else
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void txtNroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Vamos a restringir el ingreso a solo numeros
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            float duracion = (float)random.Next(1, 3600);
            Llamada llamada;
            try
            {
                if (this.txtNroDestino.Text[0] == '#')
                {
                    llamada = new Provincial(this.txtNroOrigen.Text, (Provincial.Franja)this.cmbFranja.SelectedItem, duracion, this.txtNroDestino.Text);
                }
                else
                {
                    Thread.Sleep(2000);
                    float costo = (float)random.Next(1, 100);
                    llamada = new Local(this.txtNroOrigen.Text, duracion, this.txtNroDestino.Text, costo);
                }
                this.centralita += llamada;
            }
            catch (CentralitaException ex)
            {
                MessageBox.Show($"Error: {ex.Message}, producido en {ex.NombreClase}, al momento de {ex.NombreMetodo}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
