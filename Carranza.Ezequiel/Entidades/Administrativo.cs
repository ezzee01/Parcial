using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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
        private ECargo cargo;
        public static double salarioBase;

        //prop

        public ECargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        //cons

        static Administrativo()
        {
            salarioBase = 30000;
        }

        public Administrativo(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo):base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.Cargo = cargo;
        }

        //metodos

        protected override double CalcularSalario()
        {
            return salarioBase * (int)this.Cargo / 100;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Cargo: " + this.Cargo);

            return sb.ToString();
        }

    }
}
