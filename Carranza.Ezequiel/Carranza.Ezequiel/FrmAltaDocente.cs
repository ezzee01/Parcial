using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Carranza.Ezequiel
{
    public partial class FrmAltaDocente : Form
    {
        List<Docente> docentes;

        public FrmAltaDocente()
        {
            InitializeComponent();
            docentes = new List<Docente>();
        }

        private void FrmAltaDocente_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool sexo = false;
            int dni;
            DateTime entrada;
            DateTime salida;
            double valorHora;

            dni = int.Parse(txtDni.Text);
            valorHora = double.Parse(txtValorHora.Text);

            if (cmbSexo.Text == "Femenino")
            {
                sexo = true;
            }

            Docente docente = new Docente(txtNombre.Text, txtApellido.Text, dni, sexo, dtmHoraEntrada.Value, dtmHoraSalida.Value, valorHora);

            this.docentes.Add(docente);
        }
    }
}
