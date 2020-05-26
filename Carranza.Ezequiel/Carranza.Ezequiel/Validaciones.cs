using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Carranza.Ezequiel
{
    class Validaciones
    {
        public static void SoloNumeros(KeyPressEventArgs key)
        {
            if (char.IsDigit(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (char.IsControl(key.KeyChar))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
            }
        }

        public static void SoloLetras(KeyPressEventArgs key)
        {
            if (char.IsLetter(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (char.IsControl(key.KeyChar))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
            }
        }

        public static bool ValidarSexo(string cadena)
        {
            bool sexo;
            if (cadena == "Femenino")
            {
                sexo = true;
            }
            else sexo = false;

            return sexo;
        }

        public static ECargo ValidarCargo(string cadena)
        {
            ECargo cargo;

            switch (cadena)
            {
                case "Portería":
                    cargo = ECargo.Portería;
                    break;
                case "Cocina":
                    cargo = ECargo.Cocina;
                    break;
                case "Secretaría":
                    cargo = ECargo.Secretaría;
                    break;
                case "Tesorería":
                    cargo = ECargo.Tesorería;
                    break;
                default:
                    cargo = ECargo.Dirección;
                    break;
            }

            return cargo;
        }



        public static EParentesco ValidarParentesco(string cadena)
        {
            EParentesco responsable;

            switch (cadena)
            {
                case "Padre":
                    responsable = EParentesco.Padre;
                    break;
                case "Tia":
                    responsable = EParentesco.Tia;
                    break;
                case "Tio":
                    responsable = EParentesco.Tio;
                    break;
                case "Abuela":
                    responsable = EParentesco.Abuela;
                    break;
                case "Abuelo":
                    responsable = EParentesco.Abuelo;
                    break;
                case "Otro":
                    responsable = EParentesco.Otro;
                    break;
                default:
                    responsable = EParentesco.Madre;
                    break;
            }

            return responsable;
        }
    }
}
