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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == lblUsuario.Text && txtContraseña.Text == lblContraseña.Text)
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, reingrese su usuario y contraseña", "Error");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}
