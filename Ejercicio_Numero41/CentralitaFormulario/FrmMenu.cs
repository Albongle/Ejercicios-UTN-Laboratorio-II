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

namespace CentralitaFormulario
{
    public partial class FrmMenu : Form
    {
        private FrmMostrar frmMostrar;
        private FrmLlamador llamador;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
           llamador = new FrmLlamador(new Centralita("Mi Centralita"));
           llamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Todas);
            frmMostrar.Centralita = this.llamador.Centralita;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Local);
            frmMostrar.Centralita = this.llamador.Centralita;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Provincial);
            frmMostrar.Centralita = this.llamador.Centralita;
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
