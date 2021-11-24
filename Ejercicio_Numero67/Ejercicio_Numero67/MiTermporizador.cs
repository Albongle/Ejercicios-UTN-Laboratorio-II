using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Ejercicio_Numero67
{
    public partial class MiTermporizador : Form
    {
        Temporizador temporizador;
        public MiTermporizador()
        {
            InitializeComponent();
            this.temporizador = new Temporizador();
            this.temporizador.EventoTiempo += ActualizarHora;
        }


        public void ActualizarHora()
        {
            if (this.InvokeRequired)
            {
                EncargadoTiempo callback = new EncargadoTiempo(ActualizarHora);
                this.Invoke(callback);
            }
            else
            {
                this.lblTiempo.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!this.temporizador.Activo)
            {
                temporizador.Activo = true;
                this.btnIniciar.Text = "Detener";
            }
            else
            {
                this.temporizador.Activo = false;
                this.btnIniciar.Text = "Iniciar";
            }
        }

        private void nupdwIntervalo_ValueChanged(object sender, EventArgs e)
        {
            this.temporizador.Intervalo = ((int)this.nupdwIntervalo.Value)*1000;
        }
    }
}
