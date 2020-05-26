using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Enumerado de turnos
    /// </summary>
    public enum ETurno
    {
        mañana, tarde
    }

    public class Aula
    {
        /// <summary>
        /// Atributos del aula
        /// </summary>
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private ETurno tuno;


        /// <summary>
        /// Propiedades para atributos del aula
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }

        public ETurno Turno
        {
            get { return this.tuno; }
            set { this.tuno = value; }
        }

        
        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="colorSala">Color del aula</param>
        /// <param name="turno">Turno</param>
        /// <param name="docente">Docente asignado</param>
        public Aula(EColores colorSala, ETurno turno, Docente docente)
        {
            this.ColorSala = colorSala;
            this.Turno = tuno;
            this.Docente = docente;
        }
        

        
        /// <summary>
        /// Operador para agregar alumno a la lista
        /// </summary>
        /// <param name="aula">Aula</param>
        /// <param name="alumno">Alumno a asignar</param>
        /// <returns></returns>
        public static bool operator +(Aula aula, Alumno alumno)
        {
            bool existe = false;

            if (ValidarLista(aula))
            {
                foreach (Alumno aux in aula.Alumnos)
                {
                    if (aux != alumno)
                    {
                        aula.Alumnos.Add(aux);
                        existe = true;
                    }
                }
            }
            return existe;
        }

        /// <summary>
        /// Redefinicion del metodo ToString, muestra todos los datos 
        /// </summary>
        /// <returns>Cadena con todos los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Turno: " + this.Turno);
            sb.AppendLine("Color de la sala: " + this.ColorSala);
            sb.AppendLine("Docente: " + this.Docente);

            return sb.ToString();
        }

        /// <summary>
        /// Valido que la lista de alumnos no supere los 30
        /// </summary>
        /// <param name="aula"></param>
        /// <returns></returns>
        private static bool ValidarLista(Aula aula)
        {
            if (aula.Alumnos.Capacity < 30)
            {
                return true;
            }
            else return false;
        }

        
    }
}
