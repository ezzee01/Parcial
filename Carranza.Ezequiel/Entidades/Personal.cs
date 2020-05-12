using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;

        //prop

        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }

        public double Salario
        {
            get { return CalcularSalario(); }
        }

        //cons

        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida) : base(nombre, apellido, dni, femenino)
        {
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;
        }

        //met

        protected abstract double CalcularSalario();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Hora de entrada: " + this.HoraEntrada);
            sb.AppendLine("Hora de salida: " + this.HoraSalida);

            return sb.ToString();
        }

    }
}
