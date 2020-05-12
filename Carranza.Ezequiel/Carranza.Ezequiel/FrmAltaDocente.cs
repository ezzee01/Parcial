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
    public partial class FrmAltaDocente : Form
    {
        public FrmAltaDocente()
        {
            InitializeComponent();
        }

        private void FrmAltaDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
