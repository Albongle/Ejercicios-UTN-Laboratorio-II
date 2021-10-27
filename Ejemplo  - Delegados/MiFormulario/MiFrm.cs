using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiFormulario
{
    public partial class MiFrm : Form
    {
        public delegate void MiDelegado(Persona persona);
        MiDelegado actualizador;
        List<Persona> personas;
        public MiFrm()
        {
            this.personas = new List<Persona>()
            {
                new Persona("Jorge","Perez",1),
                new Persona("Juan","Gonzalez",2),
                new Persona("Francisco","Lopez",3),
                new Persona("Raul","Martinez",4),
                new Persona("Luis","Fernandez",5),
                new Persona("Miguel","Ruiz",6),
                new Persona("Facundo","Romeo",7),
                new Persona("Sebastian","Romeo",8),
                new Persona("Lenadro","Romeo",9),
                new Persona("Cesar","Romero",10)
            };
            InitializeComponent();
        }

        private void MiFrm_Load(object sender, EventArgs e)
        {
            //MiDelegado Actualizador = new MiDelegado(this.ActualizarListBox);
            this.actualizador += this.ActualizarRichText;
            this.actualizador += this.ActualizarListBox;


        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            //IEnumerable<Persona> persona = from elemento in personas where elemento.Apellido == "Romeo" select elemento;
            //IEnumerable<string> personasAux = personas.Where(elemento => elemento.Apellido == "Romeo").Select(element => element.Nombre);
            //List<Persona> personasAux2 = this.personas.FindAll(persona => persona.Apellido == "Romeo");   


            //this.personas.ForEach((persona) => this.lstPersonas.Items.Add(persona));
            // Action action = () => { MessageBox.Show("Mensaje desde el delegado y funcion anonima"); };

            //action.Invoke();
            //Persona p = new Persona("Raul", "Martinez", 10);
            //Persona pAux = this.personas.Find(persona => persona.Dni == p.Dni);
            //MessageBox.Show(this.personas.Exists(persona => persona.Dni == p.Dni).ToString());


            //this.personas.Sort((personaA, personaB) => personaA.Dni - personaB.Dni); para ordener
            this.personas.ForEach(persona => actualizador(persona));
        }


        public void ActualizarListBox(Persona persona)
        {
            this.lstPersonas.Items.Add(persona);
        }
        public void ActualizarRichText(Persona persona)
        {
            this.rchTextDatos.Text+=$"{persona.ToString()}\n";
        }
        




    }
}
