using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carranza.Ezequiel
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Constructor para futuro codigo
        public FrmPrincipal(string msj):this()
        {

        }

        private void mnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnAltaDocente_Click(object sender, EventArgs e)
        {
            FrmAltaDocente nuevoDocente = new FrmAltaDocente();
            nuevoDocente.ShowDialog();
        }
    }
}
