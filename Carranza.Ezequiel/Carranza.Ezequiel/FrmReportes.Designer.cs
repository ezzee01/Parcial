namespace Carranza.Ezequiel
{
    partial class FrmReportes
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
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.rtbReporte = new System.Windows.Forms.RichTextBox();
            this.lblTituloReporte = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(12, 308);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(90, 35);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "<< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(423, 308);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(90, 35);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // rtbReporte
            // 
            this.rtbReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReporte.Location = new System.Drawing.Point(12, 50);
            this.rtbReporte.Name = "rtbReporte";
            this.rtbReporte.ReadOnly = true;
            this.rtbReporte.Size = new System.Drawing.Size(501, 252);
            this.rtbReporte.TabIndex = 2;
            this.rtbReporte.Text = "";
            // 
            // lblTituloReporte
            // 
            this.lblTituloReporte.AutoSize = true;
            this.lblTituloReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloReporte.Location = new System.Drawing.Point(13, 13);
            this.lblTituloReporte.Name = "lblTituloReporte";
            this.lblTituloReporte.Size = new System.Drawing.Size(93, 20);
            this.lblTituloReporte.TabIndex = 3;
            this.lblTituloReporte.Text = "Reporte de ";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(153, 308);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(90, 35);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(281, 308);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(90, 35);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTituloReporte);
            this.Controls.Add(this.rtbReporte);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.RichTextBox rtbReporte;
        private System.Windows.Forms.Label lblTituloReporte;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMostrar;
    }
}