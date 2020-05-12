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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAltaDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAltaNoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAltaAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAltaAula = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInformacionPadres = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSueldoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSueldoNoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRecaudaciónPorAula = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRecaudacionTotal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMenu
            // 
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(800, 24);
            this.mnMenu.TabIndex = 0;
            this.mnMenu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAltaDocente,
            this.mnAltaNoDocente,
            this.mnAltaAlumno,
            this.mnAltaAula,
            this.mnSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
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
            // 
            // mnAltaAlumno
            // 
            this.mnAltaAlumno.Name = "mnAltaAlumno";
            this.mnAltaAlumno.Size = new System.Drawing.Size(174, 22);
            this.mnAltaAlumno.Text = "Alta de alumno";
            // 
            // mnAltaAula
            // 
            this.mnAltaAula.Name = "mnAltaAula";
            this.mnAltaAula.Size = new System.Drawing.Size(174, 22);
            this.mnAltaAula.Text = "Alta de aula";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnInformacionPadres,
            this.mnSueldoDocente,
            this.mnSueldoNoDocente,
            this.mnRecaudaciónPorAula,
            this.mnRecaudacionTotal});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnInformacionPadres
            // 
            this.mnInformacionPadres.Name = "mnInformacionPadres";
            this.mnInformacionPadres.Size = new System.Drawing.Size(221, 22);
            this.mnInformacionPadres.Text = "Información padres";
            // 
            // mnSueldoDocente
            // 
            this.mnSueldoDocente.Name = "mnSueldoDocente";
            this.mnSueldoDocente.Size = new System.Drawing.Size(221, 22);
            this.mnSueldoDocente.Text = "Sueldo docente";
            // 
            // mnSueldoNoDocente
            // 
            this.mnSueldoNoDocente.Name = "mnSueldoNoDocente";
            this.mnSueldoNoDocente.Size = new System.Drawing.Size(221, 22);
            this.mnSueldoNoDocente.Text = "Sueldo no docente";
            // 
            // mnRecaudaciónPorAula
            // 
            this.mnRecaudaciónPorAula.Name = "mnRecaudaciónPorAula";
            this.mnRecaudaciónPorAula.Size = new System.Drawing.Size(221, 22);
            this.mnRecaudaciónPorAula.Text = "Recaudación por aula";
            // 
            // mnRecaudacionTotal
            // 
            this.mnRecaudacionTotal.Name = "mnRecaudacionTotal";
            this.mnRecaudacionTotal.Size = new System.Drawing.Size(221, 22);
            this.mnRecaudacionTotal.Text = "Recaudación total del jardín";
            // 
            // mnSalir
            // 
            this.mnSalir.Name = "mnSalir";
            this.mnSalir.Size = new System.Drawing.Size(174, 22);
            this.mnSalir.Text = "Salir";
            this.mnSalir.Click += new System.EventHandler(this.mnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.mnMenu;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardín - Principal";
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnAltaDocente;
        private System.Windows.Forms.ToolStripMenuItem mnAltaNoDocente;
        private System.Windows.Forms.ToolStripMenuItem mnAltaAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnAltaAula;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnInformacionPadres;
        private System.Windows.Forms.ToolStripMenuItem mnSueldoDocente;
        private System.Windows.Forms.ToolStripMenuItem mnSueldoNoDocente;
        private System.Windows.Forms.ToolStripMenuItem mnRecaudaciónPorAula;
        private System.Windows.Forms.ToolStripMenuItem mnRecaudacionTotal;
        private System.Windows.Forms.ToolStripMenuItem mnSalir;
    }
}