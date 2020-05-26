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
    public enum EReportes
    {
        Padres,
        SueldoDocente,
        SueldoNoDocente,
        RecaudacionAula,
        RecaudacionTotal,
        ValoresDePrueba
    }

    public partial class FrmReportes : Form
    {
        EReportes reportes;
        List<Alumno> alumnos;
        List<Docente> docentes;
        List<Administrativo> noDocentes;
        int contador = 0;

        public FrmReportes(EReportes reporte, List<Alumno> al, List<Docente> doc, List<Administrativo> adm)
        {
            InitializeComponent();
            this.reportes = reporte;
            this.alumnos = al;
            this.docentes = doc;
            this.noDocentes = adm;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {            
            switch (this.reportes)
            {
                case EReportes.Padres:
                    lblTituloReporte.Text = "Información de responsable";
                    break;
                case EReportes.SueldoDocente:
                    lblTituloReporte.Text = "Sueldos docentes";
                    break;
                case EReportes.SueldoNoDocente:
                    lblTituloReporte.Text = "Sueldos No docentes";
                    break;
                case EReportes.RecaudacionAula:
                    lblTituloReporte.Text = "Recaudación por Aula";
                    break;
                case EReportes.RecaudacionTotal:
                    lblTituloReporte.Text = "Recaudación Total";
                    break;
                case EReportes.ValoresDePrueba:
                    lblTituloReporte.Text = "Valores de prueba";
                    break;
                default:
                    break;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (this.contador < 2)
            {
                this.contador++;
            }
            else if (this.contador == 2)
            {
                this.contador = 0;
            }

            this.MostrarReporte();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            btnAnterior.Enabled = true;
            btnMostrar.Enabled = false;

            this.MostrarReporte();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (this.contador > 0)
            {
                this.contador--;
            }
            else if (this.contador == 0)
            {
                this.contador = 2;
            }

            this.MostrarReporte();
        }


        private void MostrarReporte()
        {
            double totalRecaudado = 0;
            Responsable responsable;

            switch (this.reportes)
            {
                case EReportes.Padres: //HACERLO POR CADA AULA
                    for (int i = 0; i < alumnos.Count; i++)
                    {
                        responsable =alumnos.ElementAt<Alumno>(i);
                        rtbReporte.Text += responsable.ToString();
                    }
                    break;
                case EReportes.SueldoDocente:
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    for (int i = 0; i < docentes.Count; i++)
                    {
                        rtbReporte.Text += docentes.ElementAt<Docente>(i).Nombre + " " + docentes.ElementAt<Docente>(i).Apellido + "\n";
                        rtbReporte.Text += "Salario: " + docentes.ElementAt<Docente>(i).Salario.ToString() + "\n--------------------\n";
                    }
                    break;
                case EReportes.SueldoNoDocente:
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    for (int i = 0; i < noDocentes.Count; i++)
                    {
                        rtbReporte.Text += noDocentes.ElementAt<Administrativo>(i).Nombre + " " + noDocentes.ElementAt<Administrativo>(i).Apellido + "\n";
                        rtbReporte.Text += "Sueldo: " + noDocentes.ElementAt<Administrativo>(i).Salario.ToString() + "\n--------------------\n";
                    }
                    break;
                case EReportes.RecaudacionAula: //PARA COMPLETAR
                    break;
                case EReportes.RecaudacionTotal:
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    for (int i = 0; i < alumnos.Count; i++)
                    {
                        totalRecaudado += alumnos.ElementAt<Alumno>(i).PrecioCuota;
                    }
                    rtbReporte.Text = "Total recaudado por el jardín: " + totalRecaudado.ToString(); 
                    break;
                case EReportes.ValoresDePrueba:

                    switch (this.contador)
                    {
                        case 0:
                            rtbReporte.Text = "Alumnos\n--------------------\n";
                            for (int i = 0; i < alumnos.Count; i++)
                            {
                                rtbReporte.Text += alumnos.ElementAt<Alumno>(i).ToString();
                            }
                            break;

                        case 1:
                            rtbReporte.Text = "Docentes\n--------------------\n";
                            for (int i = 0; i < docentes.Count; i++)
                            {
                                rtbReporte.Text += docentes.ElementAt<Docente>(i).ToString();
                            }
                            break;

                        case 2:
                            rtbReporte.Text = "No docentes\n--------------------\n";
                            for (int i = 0; i < noDocentes.Count; i++)
                            {
                                rtbReporte.Text += noDocentes.ElementAt<Administrativo>(i).ToString();
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
