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
    public partial class FrmPrincipal : Form
    {
        List<Docente> docentes;
        List<Administrativo> noDocentes;
        List<Alumno> alumnos;
        List<Responsable> responsables;

        public FrmPrincipal()
        {
            InitializeComponent();
            docentes = new List<Docente>();
            noDocentes = new List<Administrativo>();
            alumnos = new List<Alumno>();
            responsables = new List<Responsable>();
        }

        private void mnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnAltaDocente_Click(object sender, EventArgs e)
        {
            FrmAlta nuevoDocente = new FrmAlta(EAlta.Docente);
            nuevoDocente.ShowDialog();
        }

        private void mnAltaNoDocente_Click(object sender, EventArgs e)
        {
            FrmAlta nuevoNoDocente = new FrmAlta(EAlta.NoDocente);
            nuevoNoDocente.ShowDialog();

        }

        private void mnAltaAlumno_Click(object sender, EventArgs e)
        {
            FrmAlta nuevoAlumno = new FrmAlta(EAlta.Alumno);
            nuevoAlumno.ShowDialog();
        }

        private void mnValoresDePrueba_Click(object sender, EventArgs e)
        {
            docentes = HarcodeoListas.CargarDocentes(docentes);
            noDocentes = HarcodeoListas.CargarNoDocentes(noDocentes);
            alumnos = HarcodeoListas.CargarAlumnos(alumnos);
            responsables = HarcodeoListas.CargarResponsable(responsables);
            HarcodeoListas.AgregarResponsableEnAlumno(alumnos, responsables);

            MessageBox.Show("Datos cargados", "Aviso");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void mnReportesValoresDePrueba_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes(EReportes.ValoresDePrueba, alumnos, docentes, noDocentes);
            reportes.ShowDialog();
        }

        private void mnSueldoDocente_Click(object sender, EventArgs e)
        {
            FrmReportes reporte = new FrmReportes(EReportes.SueldoDocente, this.alumnos, this.docentes, this.noDocentes);

            reporte.ShowDialog();
        }

        private void mnSueldoNoDocente_Click(object sender, EventArgs e)
        {
            FrmReportes reporte = new FrmReportes(EReportes.SueldoNoDocente, this.alumnos, this.docentes, this.noDocentes);
            reporte.ShowDialog();
        }

        private void mnRecaudaciónPorAula_Click(object sender, EventArgs e)
        {
            FrmReportes reporte = new FrmReportes(EReportes.RecaudacionAula, this.alumnos, this.docentes, this.noDocentes);
            reporte.ShowDialog();
        }

        private void mnRecaudacionTotal_Click(object sender, EventArgs e)
        {
            FrmReportes reporte = new FrmReportes(EReportes.RecaudacionTotal, this.alumnos, this.docentes, this.noDocentes);
            reporte.ShowDialog();
        }

        private void mnInformacionPadres_Click(object sender, EventArgs e)
        {
            FrmReportes reporte = new FrmReportes(EReportes.Padres, this.alumnos, this.docentes, this.noDocentes);
            reporte.ShowDialog();
        }

        private void mnAltaAula_Click(object sender, EventArgs e)
        {
            FrmAltaAula aula = new FrmAltaAula();
            aula.ShowDialog();
        }
    }
}
