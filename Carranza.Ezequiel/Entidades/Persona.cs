using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private bool femenino;
        private string nombre;

        //propiedades

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }


        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }


        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        //constructores

        protected Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        protected Persona(string nombre, string apellido, int dni, bool femenino) : this(nombre, apellido, dni)
        {
            this.Femenino = femenino;
        }

        //metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("DNI: " + this.Dni);
            sb.AppendLine("Sexo: " + this.Femenino);

            return sb.ToString();

        }
    }
}
