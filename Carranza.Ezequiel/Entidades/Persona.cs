using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private string apellido;
        private int dni;
        private bool femenino;
        private string nombre;

        
        /// <summary>
        /// Propiedades para obtener y setear Apellido de una persona
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        /// <summary>
        /// Propiedades para obtener y setear DNI de una persona
        /// </summary>
        public int Dni
        {
            get { return this.dni; }
            set
            {
                ValidarPersonaSinDNI(value);
                this.dni = value;
            }
        }

        /// <summary>
        /// Propiedades para obtener y setear sexo de una persona
        /// </summary>
        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }

        /// <summary>
        /// Propiedades para obtener y setear Nombre de una persona
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }


        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="nombre">Nombre de una persona</param>
        /// <param name="apellido">Apellido de una persona</param>
        /// <param name="dni">DNI de una persona</param>
        protected Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="nombre">Nombre de una persona</param>
        /// <param name="apellido">Apellido de una persona</param>
        /// <param name="dni">DNI de una persona</param>
        /// <param name="femenino">Sexo de una persona</param>
        protected Persona(string nombre, string apellido, int dni, bool femenino) : this(nombre, apellido, dni)
        {
            this.Femenino = femenino;
        }


        /// <summary>
        /// Redefinicion del metodo ToString, muestra todos los datos de una persona
        /// </summary>
        /// <returns>Cadena con todos los datos de una persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("DNI: " + this.Dni);
            sb.Append("Sexo: ");
            if (this.femenino)
            {
                sb.Append("Femenino");
            }
            else sb.Append("Masculino");

            return sb.ToString();

        }

        /// <summary>
        /// Valida DNI
        /// </summary>
        /// <param name="valor">DNI de una persona</param>
        public void ValidarPersonaSinDNI(int valor)
        {
            if (valor < 10000000)
            {
                throw new PersonaSinDniException("El DNI no puede ser menor a 10000000");
            }
        }
    }
}
