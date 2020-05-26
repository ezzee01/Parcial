using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Enumerado de Colores de aula
    /// </summary>
    public enum EColores
    {
        Naranja, Rojo, Amarillo, Verde
    }

    public class Alumno : Persona
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private EColores colorSala;
        private int legajo;
        private double precioCuota;
        private Responsable responsable;

        
        /// <summary>
        /// Propiedades para obtener y setear valores de atributos
        /// </summary>
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

        public double PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }

        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        
        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="nombre">Nombre de alumno</param>
        /// <param name="apellido">Apellido de alumno</param>
        /// <param name="dni">DNI de alumno</param>
        /// <param name="femenino">Sexo de alumno</param>
        /// <param name="precioCuota">Precio de la cuota</param>
        /// <param name="legajo">Legajo del alumno</param>
        public Alumno(string nombre, string apellido, int dni, bool femenino, double precioCuota, int legajo) : base(nombre, apellido, dni, femenino)
        {
            this.PrecioCuota = precioCuota;
            this.Legajo = legajo;
        }

        
        /// <summary>
        /// Obtengo el responsable del alumno
        /// </summary>
        /// <param name="al">Alumno</param>
        public static implicit operator Responsable(Alumno al)
        {
            return al.Responsable;
        }

        /// <summary>
        /// Comparo alumnos
        /// </summary>
        /// <param name="a1">Alumno a comparar</param>
        /// <param name="a2">Alumno a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        /// <summary>
        /// Comparo alumnos
        /// </summary>
        /// <param name="a1">Alumno a comparar</param>
        /// <param name="a2">Alumno a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1.Dni == a2.Dni)
            {
                return true;
            }
            else return false;
        }


        /// <summary>
        /// Redefinicion del metodo ToString, muestra todos los datos
        /// </summary>
        /// <returns>Cadena con todos los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(this.Responsable.ToString());
            sb.AppendLine("Precio de la cuota: " + this.PrecioCuota + "\n----------------------------------------");

            return sb.ToString();
        }


    }
}
