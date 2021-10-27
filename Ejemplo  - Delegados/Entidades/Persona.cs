using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        
        public Persona (string nombre, string apellido, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }

        public override string ToString() => $"{this.apellido}, {this.nombre}";


    }
}
