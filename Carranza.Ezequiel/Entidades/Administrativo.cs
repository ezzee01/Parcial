using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Cargo del personal no docente
    /// </summary>
    public enum ECargo
    {
        Portería = 100,
        Cocina = 110,
        Secretaría = 140,
        Tesorería = 240,
        Dirección = 180
    }

    public class Administrativo : Personal
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private ECargo cargo;
        public static double salarioBase;

        
        /// <summary>
        /// Propiedades para obtener y asignar cargo del personal no docente
        /// </summary>
        public ECargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        
        /// <summary>
        /// Constructor de clase, seteo salario base en 30000
        /// </summary>
        static Administrativo()
        {
            salarioBase = 30000;
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellido</param>
        /// <param name="dni">DNI</param>
        /// <param name="femenino">Sexo</param>
        /// <param name="horaEntrada">Hora de entrada</param>
        /// <param name="horaSalida">Hora de salida</param>
        /// <param name="cargo">Cargo</param>
        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo):base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.Cargo = cargo;
        }

        
        /// <summary>
        /// Implementacion para el calculo del salario
        /// </summary>
        /// <returns></returns>
        protected override double CalcularSalario()
        {
            return salarioBase * (int)this.Cargo / 100;
        }

        /// <summary>
        /// Redefinicion del metodo ToString, muestra todos los datos
        /// </summary>
        /// <returns>Cadena con todos los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Cargo: " + this.Cargo);

            return sb.ToString();
        }

    }
}
