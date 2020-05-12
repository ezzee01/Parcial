using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EColores
    {
        Naranja, Rojo, Amarillo, Verde
    }

    public class Alumno : Persona
    {
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;

        //prop

        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }

        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        //cons

        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota) : base(nombre, apellido, dni, femenino)
        {
            this.PrecioCuota = precioCuota;
        }

        //metodos

        public static implicit operator Responsable(Alumno al)
        {
            return al.Responsable;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1.Dni == a2.Dni)
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Precio de la cuota: " + this.PrecioCuota);

            return sb.ToString();
        }


    }
}
