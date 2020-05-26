using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Tipos de responsable para alumno
    /// </summary>
    public enum EParentesco
    {
        Madre, Padre, Tia, Tio, Abuela, Abuelo, Otro
    }

    public class Responsable : Persona
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private EParentesco parentesco;
        private string telefono;

        /// <summary>
        /// Propiedad para setear y obtener tipo de parentesco
        /// </summary>
        public EParentesco Parentesco
        {
            get { return this.parentesco; }
            set { this.parentesco = value; }
        }

        /// <summary>
        /// Propiedad para setear y obtener telefono del responsable
        /// </summary>
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }


        /// <summary>
        /// Constructor de instancia, setea todos los datos de instancia de un responsable
        /// </summary>
        /// <param name="nombre">Nombre del responsable</param>
        /// <param name="apellido">Apellido del responsable</param>
        /// <param name="dni">DNI del responsable</param>
        /// <param name="femenino">Sexo del responsable</param>
        /// <param name="parentesco">Parentesco del responsable</param>
        /// <param name="telefono">Teléfono del responsable</param>
        public Responsable(string nombre, string apellido, int dni, bool femenino, EParentesco parentesco, string telefono) : base(nombre, apellido, dni, femenino)
        {
            this.Telefono = telefono;
            this.Parentesco = parentesco;
        }

        
        /// <summary>
        /// Redefinicion del metodo ToString, muestra todos los datos de un responsable
        /// </summary>
        /// <returns>Cadena con todos los datos de un responsable</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nResponsable:\n");
            sb.AppendLine(base.ToString());
            sb.AppendLine("Teléfono: " + this.Telefono);
            sb.AppendLine("Parentesco: " + this.Parentesco);

            return sb.ToString();
        }
    }
}
