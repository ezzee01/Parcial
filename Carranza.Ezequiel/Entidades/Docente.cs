using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        private double valorHora;

        //prop

        public int HorasMensuales
        {
            get
            {
                TimeSpan time = this.HoraSalida - this.HoraEntrada;
                return time.Hours;
            }
            set
            {
                TimeSpan time = new TimeSpan(value);
            }
        }

        public double ValorHora
        {
            get { return this.valorHora; }
            set { this.valorHora = value; }
        }

        //cons

        public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora) : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.ValorHora = valorHora;
        }

        protected override double CalcularSalario()
        {

            return this.ValorHora * this.HorasMensuales * 20;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Valor por hora: " + this.ValorHora);

            return sb.ToString();
        }
    }
}
