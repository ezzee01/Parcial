namespace Carranza.Ezequiel
{
    partial class FrmAltaAula
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
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblAltaAula = new System.Windows.Forms.Label();
            this.gpbAlumnoSinAsignar = new System.Windows.Forms.GroupBox();
            this.rtbSinAsignar = new System.Windows.Forms.RichTextBox();
            this.gpbAlumnosAsignados = new System.Windows.Forms.GroupBox();
            this.rtbAsignado = new System.Windows.Forms.RichTextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.gpbAlumnoSinAsignar.SuspendLayout();
            this.gpbAlumnosAsignados.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbColor
            // 
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Naranja",
            "Rojo",
            "Amarillo",
            "Verde"});
            this.cmbColor.Location = new System.Drawing.Point(12, 56);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 26);
            this.cmbColor.TabIndex = 0;
            this.cmbColor.Text = "Color";
            // 
            // cmbTurno
            // 
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cmbTurno.Location = new System.Drawing.Point(202, 56);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 26);
            this.cmbTurno.TabIndex = 1;
            this.cmbTurno.Text = "Turno";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(392, 56);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(121, 26);
            this.cmbProfesor.TabIndex = 2;
            this.cmbProfesor.Text = "Profesor";
            // 
            // lblAltaAula
            // 
            this.lblAltaAula.AutoSize = true;
            this.lblAltaAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaAula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAltaAula.Location = new System.Drawing.Point(12, 9);
            this.lblAltaAula.Name = "lblAltaAula";
            this.lblAltaAula.Size = new System.Drawing.Size(95, 20);
            this.lblAltaAula.TabIndex = 3;
            this.lblAltaAula.Text = "Alta de Aula";
            // 
            // gpbAlumnoSinAsignar
            // 
            this.gpbAlumnoSinAsignar.Controls.Add(this.rtbSinAsignar);
            this.gpbAlumnoSinAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAlumnoSinAsignar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbAlumnoSinAsignar.Location = new System.Drawing.Point(12, 98);
            this.gpbAlumnoSinAsignar.Name = "gpbAlumnoSinAsignar";
            this.gpbAlumnoSinAsignar.Size = new System.Drawing.Size(240, 225);
            this.gpbAlumnoSinAsignar.TabIndex = 4;
            this.gpbAlumnoSinAsignar.TabStop = false;
            this.gpbAlumnoSinAsignar.Text = "Sin asignar";
            // 
            // rtbSinAsignar
            // 
            this.rtbSinAsignar.Location = new System.Drawing.Point(6, 21);
            this.rtbSinAsignar.Name = "rtbSinAsignar";
            this.rtbSinAsignar.ReadOnly = true;
            this.rtbSinAsignar.Size = new System.Drawing.Size(228, 198);
            this.rtbSinAsignar.TabIndex = 0;
            this.rtbSinAsignar.Text = "";
            // 
            // gpbAlumnosAsignados
            // 
            this.gpbAlumnosAsignados.Controls.Add(this.rtbAsignado);
            this.gpbAlumnosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAlumnosAsignados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbAlumnosAsignados.Location = new System.Drawing.Point(273, 98);
            this.gpbAlumnosAsignados.Name = "gpbAlumnosAsignados";
            this.gpbAlumnosAsignados.Size = new System.Drawing.Size(240, 225);
            this.gpbAlumnosAsignados.TabIndex = 5;
            this.gpbAlumnosAsignados.TabStop = false;
            this.gpbAlumnosAsignados.Text = "Asignados";
            // 
            // rtbAsignado
            // 
            this.rtbAsignado.Location = new System.Drawing.Point(6, 21);
            this.rtbAsignado.Name = "rtbAsignado";
            this.rtbAsignado.ReadOnly = true;
            this.rtbAsignado.Size = new System.Drawing.Size(228, 198);
            this.rtbAsignado.TabIndex = 0;
            this.rtbAsignado.Text = "";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(58, 338);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(90, 35);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(392, 338);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 35);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(202, 338);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(50, 35);
            this.btnSacar.TabIndex = 8;
            this.btnSacar.Text = "<<";
            this.btnSacar.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(273, 338);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(50, 35);
            this.btnAsignar.TabIndex = 9;
            this.btnAsignar.Text = ">>";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gpbAlumnosAsignados);
            this.Controls.Add(this.gpbAlumnoSinAsignar);
            this.Controls.Add(this.lblAltaAula);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Aula";
            this.gpbAlumnoSinAsignar.ResumeLayout(false);
            this.gpbAlumnosAsignados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label lblAltaAula;
        private System.Windows.Forms.GroupBox gpbAlumnoSinAsignar;
        private System.Windows.Forms.GroupBox gpbAlumnosAsignados;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox rtbSinAsignar;
        private System.Windows.Forms.RichTextBox rtbAsignado;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnAsignar;
    }
}