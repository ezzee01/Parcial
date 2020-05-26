using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private DateTime horaEntrada;
        private DateTime horaSalida;

        
        /// <summary>
        /// Propiedad publica para horarios de entrada
        /// </summary>
        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }

        /// <summary>
        /// Propiedad publica para horarios de salida
        /// </summary>
        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }

        /// <summary>
        /// Propiedad publica para obtener salario del personal
        /// </summary>
        public double Salario
        {
            get { return CalcularSalario(); }
        }


        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="nombre">Nombre del personal</param>
        /// <param name="apellido">Apellido del personal</param>
        /// <param name="dni">DNI del personal</param>
        /// <param name="femenino">Sexo del personal</param>
        /// <param name="horaEntrada">Hora de entrada del personal</param>
        /// <param name="horaSalida">Hora de salida del personal</param>
        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida) : base(nombre, apellido, dni, femenino)
        {
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;
        }

        
        /// <summary>
        /// Metodo abstracto a ser implementado en clases hijas 
        /// </summary>
        /// <returns>Retorna salario calculado</returns>
        protected abstract double CalcularSalario();

        /// <summary>
        /// Redefinicion del metodo ToString, muestra todos los datos del personal
        /// </summary>
        /// <returns>Cadena con todos los datos del personal</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Hora de entrada: " + this.HoraEntrada.Hour + ":" + this.horaEntrada.Minute);
            sb.AppendLine("Hora de salida: " + this.HoraSalida.Hour + ":" + this.horaSalida.Minute);

            return sb.ToString();
        }

    }
}
