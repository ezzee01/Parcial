namespace Carranza.Ezequiel
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnMenu = new System.Windows.Forms.MenuStrip();
            this.mnArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAltaDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAltaNoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAltaAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAltaAula = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInformacionPadres = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSueldoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSueldoNoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRecaudaciónPorAula = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRecaudacionTotal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReportesValoresDePrueba = new System.Windows.Forms.ToolStripMenuItem();
            this.mnValoresDePrueba = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMenu
            // 
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArchivo,
            this.mnReportes,
            this.mnValoresDePrueba});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(584, 24);
            this.mnMenu.TabIndex = 0;
            this.mnMenu.Text = "Menu";
            // 
            // mnArchivo
            // 
            this.mnArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAltaDocente,
            this.mnAltaNoDocente,
            this.mnAltaAlumno,
            this.mnAltaAula,
            this.mnSalir});
            this.mnArchivo.Name = "mnArchivo";
            this.mnArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnArchivo.Text = "Archivo";
            // 
            // mnAltaDocente
            // 
            this.mnAltaDocente.Name = "mnAltaDocente";
            this.mnAltaDocente.Size = new System.Drawing.Size(174, 22);
            this.mnAltaDocente.Text = "Alta de docente";
            this.mnAltaDocente.Click += new System.EventHandler(this.mnAltaDocente_Click);
            // 
            // mnAltaNoDocente
            // 
            this.mnAltaNoDocente.Name = "mnAltaNoDocente";
            this.mnAltaNoDocente.Size = new System.Drawing.Size(174, 22);
            this.mnAltaNoDocente.Text = "Alta de no docente";
            this.mnAltaNoDocente.Click += new System.EventHandler(this.mnAltaNoDocente_Click);
            // 
            // mnAltaAlumno
            // 
            this.mnAltaAlumno.Name = "mnAltaAlumno";
            this.mnAltaAlumno.Size = new System.Drawing.Size(174, 22);
            this.mnAltaAlumno.Text = "Alta de alumno";
            this.mnAltaAlumno.Click += new System.EventHandler(this.mnAltaAlumno_Click);
            // 
            // mnAltaAula
            // 
            this.mnAltaAula.Name = "mnAltaAula";
            this.mnAltaAula.Size = new System.Drawing.Size(174, 22);
            this.mnAltaAula.Text = "Alta de aula";
            this.mnAltaAula.Click += new System.EventHandler(this.mnAltaAula_Click);
            // 
            // mnSalir
            // 
            this.mnSalir.Name = "mnSalir";
            this.mnSalir.Size = new System.Drawing.Size(174, 22);
            this.mnSalir.Text = "Salir";
            this.mnSalir.Click += new System.EventHandler(this.mnSalir_Click);
            // 
            // mnReportes
            // 
            this.mnReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnInformacionPadres,
            this.mnSueldoDocente,
            this.mnSueldoNoDocente,
            this.mnRecaudaciónPorAula,
            this.mnRecaudacionTotal,
            this.mnReportesValoresDePrueba});
            this.mnReportes.Name = "mnReportes";
            this.mnReportes.Size = new System.Drawing.Size(65, 20);
            this.mnReportes.Text = "Reportes";
            // 
            // mnInformacionPadres
            // 
            this.mnInformacionPadres.Name = "mnInformacionPadres";
            this.mnInformacionPadres.Size = new System.Drawing.Size(221, 22);
            this.mnInformacionPadres.Text = "Información padres";
            this.mnInformacionPadres.Click += new System.EventHandler(this.mnInformacionPadres_Click);
            // 
            // mnSueldoDocente
            // 
            this.mnSueldoDocente.Name = "mnSueldoDocente";
            this.mnSueldoDocente.Size = new System.Drawing.Size(221, 22);
            this.mnSueldoDocente.Text = "Sueldo docente";
            this.mnSueldoDocente.Click += new System.EventHandler(this.mnSueldoDocente_Click);
            // 
            // mnSueldoNoDocente
            // 
            this.mnSueldoNoDocente.Name = "mnSueldoNoDocente";
            this.mnSueldoNoDocente.Size = new System.Drawing.Size(221, 22);
            this.mnSueldoNoDocente.Text = "Sueldo no docente";
            this.mnSueldoNoDocente.Click += new System.EventHandler(this.mnSueldoNoDocente_Click);
            // 
            // mnRecaudaciónPorAula
            // 
            this.mnRecaudaciónPorAula.Name = "mnRecaudaciónPorAula";
            this.mnRecaudaciónPorAula.Size = new System.Drawing.Size(221, 22);
            this.mnRecaudaciónPorAula.Text = "Recaudación por aula";
            this.mnRecaudaciónPorAula.Click += new System.EventHandler(this.mnRecaudaciónPorAula_Click);
            // 
            // mnRecaudacionTotal
            // 
            this.mnRecaudacionTotal.Name = "mnRecaudacionTotal";
            this.mnRecaudacionTotal.Size = new System.Drawing.Size(221, 22);
            this.mnRecaudacionTotal.Text = "Recaudación total del jardín";
            this.mnRecaudacionTotal.Click += new System.EventHandler(this.mnRecaudacionTotal_Click);
            // 
            // mnReportesValoresDePrueba
            // 
            this.mnReportesValoresDePrueba.Name = "mnReportesValoresDePrueba";
            this.mnReportesValoresDePrueba.Size = new System.Drawing.Size(221, 22);
            this.mnReportesValoresDePrueba.Text = "Reportes valores de prueba";
            this.mnReportesValoresDePrueba.Click += new System.EventHandler(this.mnReportesValoresDePrueba_Click);
            // 
            // mnValoresDePrueba
            // 
            this.mnValoresDePrueba.Name = "mnValoresDePrueba";
            this.mnValoresDePrueba.Size = new System.Drawing.Size(113, 20);
            this.mnValoresDePrueba.Text = "Valores de Prueba";
            this.mnValoresDePrueba.Click += new System.EventHandler(this.mnValoresDePrueba_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.mnMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.mnMenu;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardín - Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem mnArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnAltaDocente;
        private System.Windows.Forms.ToolStripMenuItem mnAltaNoDocente;
        private System.Windows.Forms.ToolStripMenuItem mnAltaAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnAltaAula;
        private System.Windows.Forms.ToolStripMenuItem mnReportes;
        private System.Windows.Forms.ToolStripMenuItem mnInformacionPadres;
        private System.Windows.Forms.ToolStripMenuItem mnSueldoDocente;
        private System.Windows.Forms.ToolStripMenuItem mnSueldoNoDocente;
        private System.Windows.Forms.ToolStripMenuItem mnRecaudaciónPorAula;
        private System.Windows.Forms.ToolStripMenuItem mnRecaudacionTotal;
        private System.Windows.Forms.ToolStripMenuItem mnSalir;
        private System.Windows.Forms.ToolStripMenuItem mnValoresDePrueba;
        private System.Windows.Forms.ToolStripMenuItem mnReportesValoresDePrueba;
    }
}