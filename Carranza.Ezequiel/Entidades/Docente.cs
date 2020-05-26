using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private double valorHora;

        
        /// <summary>
        /// Propiedad para horas mensuales
        /// </summary>
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

        /// <summary>
        /// Obtengo o seteo valor por hora
        /// </summary>
        public double ValorHora
        {
            get { return this.valorHora; }
            set { this.valorHora = value; }
        }


        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="nombre">Nombre del docente</param>
        /// <param name="apellido">Apellido del docente</param>
        /// <param name="dni">DNI del docente</param>
        /// <param name="femenino">Sexo del docente</param>
        /// <param name="horaEntrada">Hora de entrada del docente</param>
        /// <param name="horaSalida">Hora de salida del docente</param>
        /// <param name="valorHora">Valor por hora trabajada del docente</param>
        public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora) : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.ValorHora = valorHora;
        }


        /// <summary>
        /// Implementacion del método para calcular el saladio
        /// </summary>
        /// <returns>Salario del docente</returns>
        protected override double CalcularSalario()
        {

            return this.ValorHora * this.HorasMensuales * 20;
        }


        /// <summary>
        /// Redefinicion del metodo ToString, muestra todos los datos del docente
        /// </summary>
        /// <returns>Cadena con todos los datos del docente</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Valor por hora: " + this.ValorHora);

            return sb.ToString();
        }
    }
}
