using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EParentesco
    {
        Madre, Padre, Tia, Tio, Abuela, Abuelo, Otro
    }

    public class Responsable : Persona
    {
        private EParentesco parentesco;
        private string telefono;

        //propiedades

        public EParentesco Parentesco
        {
            get { return this.parentesco; }
            set { this.parentesco = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        //cons 

        public Responsable(string nombre, string apellido, int dni, bool femenino, EParentesco parentesco, string telefono) : base(nombre, apellido, dni, femenino)
        {
            this.Telefono = telefono;
            this.Parentesco = parentesco;
        }

        //metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Teléfono: " + this.Telefono);
            sb.AppendLine("Parentesco: " + this.Parentesco);

            return sb.ToString();
        }
    }
}
