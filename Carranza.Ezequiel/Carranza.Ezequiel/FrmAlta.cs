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
    public enum EAlta
    {
        Docente = 1,
        NoDocente = 2,
        Alumno = 3
    }

    public partial class FrmAlta : Form
    {
        Alumno alumno;
        Docente docente;
        Administrativo noDocente;
        Responsable responsable;
        List<Docente> docentes;
        List<Administrativo> noDocentes;
        List<Alumno> alumnos;
        EAlta tipoAlta;

        public EAlta TipoAlta
        {
            get { return this.tipoAlta; }
            set { this.tipoAlta = value; }
        }


        public FrmAlta(EAlta alta)
        {
            InitializeComponent();
            docentes = new List<Docente>();
            noDocentes = new List<Administrativo>();
            alumnos = new List<Alumno>();
            this.TipoAlta = alta;
        }

        private void FrmAltaDocente_Load(object sender, EventArgs e)
        {
            switch (tipoAlta)
            {
                case EAlta.Docente:
                    lblCargo.Visible = false;
                    cmbCargo.Visible = false;
                    lblLegajo.Visible = false;
                    txtLegajo.Visible = false;
                    lblPrecioCuota.Visible = false;
                    txtPrecioCuota.Visible = false;
                    lblNombreResponsable.Visible = false;
                    txtNombreResponsable.Visible = false;
                    lblApellidoResponsable.Visible = false;
                    txtApellidoResponsable.Visible = false;
                    lblDNIResponsable.Visible = false;
                    txtDNIResponsable.Visible = false;
                    cmbSexoResponsable.Visible = false;
                    lblTelResponsable.Visible = false;
                    txtTelResponsable.Visible = false;
                    cmbParentescoResponsable.Visible = false;
                    gpbResponsable.Visible = false;
                    break;
                case EAlta.NoDocente:
                    lblAlta.Text = "Alta de no docentes";
                    lblLegajo.Visible = false;
                    txtLegajo.Visible = false;
                    lblPrecioCuota.Visible = false;
                    txtPrecioCuota.Visible = false;
                    lblNombreResponsable.Visible = false;
                    txtNombreResponsable.Visible = false;
                    lblApellidoResponsable.Visible = false;
                    txtApellidoResponsable.Visible = false;
                    lblDNIResponsable.Visible = false;
                    txtDNIResponsable.Visible = false;
                    cmbSexoResponsable.Visible = false;
                    lblTelResponsable.Visible = false;
                    txtTelResponsable.Visible = false;
                    cmbParentescoResponsable.Visible = false;
                    gpbResponsable.Visible = false;
                    break;
                case EAlta.Alumno:
                    lblHoraEntrada.Visible = false;
                    lblHoraSalida.Visible = false;
                    dtmHoraEntrada.Visible = false;
                    dtmHoraSalida.Visible = false;
                    lblCargo.Visible = false;
                    cmbCargo.Visible = false;
                    lblValorHora.Visible = false;
                    txtValorHora.Visible = false;
                    lblAlta.Text = "Alta de alumnos y responsable";
                    break;
                default:
                    break;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (this.tipoAlta)
            {
                case EAlta.Docente:
                    docente = new Docente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), Validaciones.ValidarSexo(cmbSexo.Text), dtmHoraEntrada.Value, dtmHoraSalida.Value, double.Parse(txtValorHora.Text));
                    docentes.Add(docente);
                    MessageBox.Show("Docente ingresado correctamente", "Aviso");
                    break;
                case EAlta.NoDocente:
                    noDocente = new Administrativo(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), Validaciones.ValidarSexo(cmbSexo.Text), dtmHoraEntrada.Value, dtmHoraSalida.Value, Validaciones.ValidarCargo(cmbCargo.Text));
                    noDocentes.Add(noDocente);
                    MessageBox.Show("Personal ingresado correctamente", "Aviso");
                    break;
                case EAlta.Alumno:
                    alumno = new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), Validaciones.ValidarSexo(cmbSexo.Text), double.Parse(txtPrecioCuota.Text), int.Parse(txtLegajo.Text));
                    responsable = new Responsable(txtNombreResponsable.Text, txtApellidoResponsable.Text, int.Parse(txtDNIResponsable.Text), Validaciones.ValidarSexo(cmbSexoResponsable.Text), Validaciones.ValidarParentesco(cmbParentescoResponsable.Text), txtTelResponsable.Text);
                    alumno.Responsable = responsable;
                    alumnos.Add(alumno);
                    MessageBox.Show("Alumno ingresado correctamente", "Aviso");
                    break;
                default:
                    break;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtPrecioCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtNombreResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellidoResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtDNIResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtValorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
