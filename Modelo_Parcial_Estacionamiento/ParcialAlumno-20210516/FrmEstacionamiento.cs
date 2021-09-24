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

namespace ParcialAlumno_20210516
{
    public partial class FrmEstacionamiento : Form
    {
        Estacionamiento estacionamiento;
        public FrmEstacionamiento()
        {
            InitializeComponent();
        }

        private void FrmEstacionamiento_Load(object sender, EventArgs e)
        {
            this.cmbTipoVehiculo.DataSource = Enum.GetValues(typeof(Vehiculo.EVehiculos));
            this.cmbTipoMoto.DataSource = Enum.GetValues(typeof(Moto.ETipo));
            this.estacionamiento = Estacionamiento.GetEstacionamiento("Algo", 20);
            this.txtNombreEstacionamiento.Text = this.estacionamiento.Nombre;
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((Vehiculo.EVehiculos)this.cmbTipoVehiculo.SelectedItem == Vehiculo.EVehiculos.Automovil)
            {
                this.cmbTipoMoto.Visible = false;
                lblTipo.Text = "Marca:";
                this.txtMarca.Location = this.cmbTipoMoto.Location;
                this.txtMarca.Visible = true;
            }
            else
            {
                this.cmbTipoMoto.Visible = true;
                lblTipo.Text = "Tipo Moto:";
                this.txtMarca.Visible = false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo;
            if((Vehiculo.EVehiculos)this.cmbTipoVehiculo.SelectedItem == Vehiculo.EVehiculos.Automovil)
            {
                vehiculo = new Automovil(this.txtPatente.Text, DateTime.Now, this.txtMarca.Text);
            }
            else
            {
                vehiculo = new Moto(this.txtPatente.Text, DateTime.Now, (Moto.ETipo)this.cmbTipoMoto.SelectedItem);
            }

            if(this.estacionamiento+vehiculo)
            {
                this.lstVehiculos.Items.Add(vehiculo);
                MessageBox.Show(vehiculo.ToString(), "Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void lstVehiculos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.estacionamiento - (Vehiculo)this.lstVehiculos.SelectedItem)
            {
                MessageBox.Show(this.estacionamiento.InformarSalida((Vehiculo)this.lstVehiculos.SelectedItem), "Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lstVehiculos.Items.Remove((Vehiculo)this.lstVehiculos.SelectedItem);
            }
        }

    }
}
