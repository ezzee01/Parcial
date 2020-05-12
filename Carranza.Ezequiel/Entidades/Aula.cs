using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETurno
    {
        mañana, tarde
    }

    public class Aula
    {
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private ETurno tuno;

        //prop

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

        //cons

        public Aula(EColores colorSala, ETurno turno, Docente docente)
        {
            this.ColorSala = colorSala;
            this.Turno = tuno;
            this.Docente = docente;
        }

        static Aula()
        { }

        //metodos

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Turno: " + this.Turno);
            sb.AppendLine("Color de la sala: " + this.ColorSala);
            sb.AppendLine("Docente: " + this.Docente);

            return sb.ToString();
        }

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
