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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipoLlamada;
        public FrmMostrar(Llamada.TipoLlamada tipoLlamada)
        {
            InitializeComponent();
            this.tipoLlamada = tipoLlamada;
        }

        public Centralita Centralita
        {
            set {this.centralita = value; }
        }
        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            foreach (Llamada item in this.centralita.Llamadas)
            {
                if(item is Local && this.tipoLlamada== Llamada.TipoLlamada.Local)
                {
                    rchTextDatos.Text += item.ToString();
                }
                else if(item is Provincial && this.tipoLlamada == Llamada.TipoLlamada.Provincial)
                {
                    rchTextDatos.Text += item.ToString();
                }
                else if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
                {
                    rchTextDatos.Text += item.ToString();
                }
            }

            if(this.tipoLlamada==Llamada.TipoLlamada.Todas)
            {
                rchTextDatos.Text += $"Ganancia por todas las llamadas {this.centralita.GananciasPorTodas}";
            }
            else if (this.tipoLlamada == Llamada.TipoLlamada.Local)
            {
                rchTextDatos.Text += $"Ganancia por llamadas Locales {this.centralita.GananciasPorLocal}";
            }
            else
            {
                rchTextDatos.Text += $"Ganancia por llamadas Provinciales {this.centralita.GananciasPorProvincial}";
            }

        }
    }
}
