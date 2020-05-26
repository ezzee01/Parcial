namespace Carranza.Ezequiel
{
    partial class FrmAlta
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.dtmHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtmHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAlta = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblPrecioCuota = new System.Windows.Forms.Label();
            this.txtPrecioCuota = new System.Windows.Forms.TextBox();
            this.lblTelResponsable = new System.Windows.Forms.Label();
            this.txtTelResponsable = new System.Windows.Forms.TextBox();
            this.lblNombreResponsable = new System.Windows.Forms.Label();
            this.lblDNIResponsable = new System.Windows.Forms.Label();
            this.lblApellidoResponsable = new System.Windows.Forms.Label();
            this.cmbSexoResponsable = new System.Windows.Forms.ComboBox();
            this.txtDNIResponsable = new System.Windows.Forms.TextBox();
            this.txtApellidoResponsable = new System.Windows.Forms.TextBox();
            this.txtNombreResponsable = new System.Windows.Forms.TextBox();
            this.cmbParentescoResponsable = new System.Windows.Forms.ComboBox();
            this.gpbResponsable = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(47, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 24);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(214, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 24);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(380, 52);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 24);
            this.txtDni.TabIndex = 2;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(214, 133);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 24);
            this.txtValorHora.TabIndex = 3;
            this.txtValorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorHora_KeyPress);
            // 
            // dtmHoraEntrada
            // 
            this.dtmHoraEntrada.CustomFormat = "HH:mm";
            this.dtmHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmHoraEntrada.Location = new System.Drawing.Point(47, 212);
            this.dtmHoraEntrada.Name = "dtmHoraEntrada";
            this.dtmHoraEntrada.Size = new System.Drawing.Size(200, 24);
            this.dtmHoraEntrada.TabIndex = 4;
            this.dtmHoraEntrada.Value = new System.DateTime(2020, 5, 12, 4, 42, 44, 0);
            // 
            // dtmHoraSalida
            // 
            this.dtmHoraSalida.CustomFormat = "HH:mm";
            this.dtmHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmHoraSalida.Location = new System.Drawing.Point(281, 211);
            this.dtmHoraSalida.Name = "dtmHoraSalida";
            this.dtmHoraSalida.Size = new System.Drawing.Size(200, 24);
            this.dtmHoraSalida.TabIndex = 5;
            this.dtmHoraSalida.Value = new System.DateTime(2020, 5, 12, 4, 42, 54, 0);
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(47, 133);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 26);
            this.cmbSexo.TabIndex = 6;
            this.cmbSexo.Text = "Masculino";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(214, 31);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDni.Location = new System.Drawing.Point(380, 31);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 18);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHoraEntrada.Location = new System.Drawing.Point(47, 190);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(114, 18);
            this.lblHoraEntrada.TabIndex = 10;
            this.lblHoraEntrada.Text = "Hora de entrada";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorHora.Location = new System.Drawing.Point(211, 112);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(79, 18);
            this.lblValorHora.TabIndex = 11;
            this.lblValorHora.Text = "Valor Hora";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHoraSalida.Location = new System.Drawing.Point(278, 190);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(103, 18);
            this.lblHoraSalida.TabIndex = 12;
            this.lblHoraSalida.Text = "Hora de salida";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(47, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(348, 339);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 34);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(84, 339);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlta.Location = new System.Drawing.Point(4, 0);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(129, 20);
            this.lblAlta.TabIndex = 19;
            this.lblAlta.Text = "Alta de docentes";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCargo.Location = new System.Drawing.Point(47, 263);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 18);
            this.lblCargo.TabIndex = 21;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Portería",
            "Cocina",
            "Secretaría",
            "Tesorería",
            "Dirección"});
            this.cmbCargo.Location = new System.Drawing.Point(47, 284);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(121, 26);
            this.cmbCargo.TabIndex = 23;
            this.cmbCargo.Text = "Cargo";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLegajo.Location = new System.Drawing.Point(380, 112);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(52, 18);
            this.lblLegajo.TabIndex = 25;
            this.lblLegajo.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.Location = new System.Drawing.Point(380, 133);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 24);
            this.txtLegajo.TabIndex = 24;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // lblPrecioCuota
            // 
            this.lblPrecioCuota.AutoSize = true;
            this.lblPrecioCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecioCuota.Location = new System.Drawing.Point(214, 112);
            this.lblPrecioCuota.Name = "lblPrecioCuota";
            this.lblPrecioCuota.Size = new System.Drawing.Size(112, 18);
            this.lblPrecioCuota.TabIndex = 27;
            this.lblPrecioCuota.Text = "Precio de cuota";
            // 
            // txtPrecioCuota
            // 
            this.txtPrecioCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCuota.Location = new System.Drawing.Point(214, 133);
            this.txtPrecioCuota.Name = "txtPrecioCuota";
            this.txtPrecioCuota.Size = new System.Drawing.Size(100, 24);
            this.txtPrecioCuota.TabIndex = 26;
            this.txtPrecioCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCuota_KeyPress);
            // 
            // lblTelResponsable
            // 
            this.lblTelResponsable.AutoSize = true;
            this.lblTelResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelResponsable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelResponsable.Location = new System.Drawing.Point(217, 274);
            this.lblTelResponsable.Name = "lblTelResponsable";
            this.lblTelResponsable.Size = new System.Drawing.Size(66, 18);
            this.lblTelResponsable.TabIndex = 40;
            this.lblTelResponsable.Text = "Teléfono";
            // 
            // txtTelResponsable
            // 
            this.txtTelResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelResponsable.Location = new System.Drawing.Point(217, 295);
            this.txtTelResponsable.Name = "txtTelResponsable";
            this.txtTelResponsable.Size = new System.Drawing.Size(100, 24);
            this.txtTelResponsable.TabIndex = 39;
            // 
            // lblNombreResponsable
            // 
            this.lblNombreResponsable.AutoSize = true;
            this.lblNombreResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreResponsable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreResponsable.Location = new System.Drawing.Point(50, 193);
            this.lblNombreResponsable.Name = "lblNombreResponsable";
            this.lblNombreResponsable.Size = new System.Drawing.Size(62, 18);
            this.lblNombreResponsable.TabIndex = 36;
            this.lblNombreResponsable.Text = "Nombre";
            // 
            // lblDNIResponsable
            // 
            this.lblDNIResponsable.AutoSize = true;
            this.lblDNIResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIResponsable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDNIResponsable.Location = new System.Drawing.Point(383, 193);
            this.lblDNIResponsable.Name = "lblDNIResponsable";
            this.lblDNIResponsable.Size = new System.Drawing.Size(33, 18);
            this.lblDNIResponsable.TabIndex = 33;
            this.lblDNIResponsable.Text = "DNI";
            // 
            // lblApellidoResponsable
            // 
            this.lblApellidoResponsable.AutoSize = true;
            this.lblApellidoResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoResponsable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidoResponsable.Location = new System.Drawing.Point(217, 193);
            this.lblApellidoResponsable.Name = "lblApellidoResponsable";
            this.lblApellidoResponsable.Size = new System.Drawing.Size(59, 18);
            this.lblApellidoResponsable.TabIndex = 34;
            this.lblApellidoResponsable.Text = "Apellido";
            // 
            // cmbSexoResponsable
            // 
            this.cmbSexoResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexoResponsable.FormattingEnabled = true;
            this.cmbSexoResponsable.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexoResponsable.Location = new System.Drawing.Point(50, 295);
            this.cmbSexoResponsable.Name = "cmbSexoResponsable";
            this.cmbSexoResponsable.Size = new System.Drawing.Size(121, 26);
            this.cmbSexoResponsable.TabIndex = 32;
            this.cmbSexoResponsable.Text = "Masculino";
            // 
            // txtDNIResponsable
            // 
            this.txtDNIResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIResponsable.Location = new System.Drawing.Point(383, 214);
            this.txtDNIResponsable.Name = "txtDNIResponsable";
            this.txtDNIResponsable.Size = new System.Drawing.Size(100, 24);
            this.txtDNIResponsable.TabIndex = 30;
            this.txtDNIResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIResponsable_KeyPress);
            // 
            // txtApellidoResponsable
            // 
            this.txtApellidoResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoResponsable.Location = new System.Drawing.Point(217, 214);
            this.txtApellidoResponsable.Name = "txtApellidoResponsable";
            this.txtApellidoResponsable.Size = new System.Drawing.Size(100, 24);
            this.txtApellidoResponsable.TabIndex = 29;
            this.txtApellidoResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoResponsable_KeyPress);
            // 
            // txtNombreResponsable
            // 
            this.txtNombreResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreResponsable.Location = new System.Drawing.Point(50, 214);
            this.txtNombreResponsable.Name = "txtNombreResponsable";
            this.txtNombreResponsable.Size = new System.Drawing.Size(100, 24);
            this.txtNombreResponsable.TabIndex = 28;
            this.txtNombreResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreResponsable_KeyPress);
            // 
            // cmbParentescoResponsable
            // 
            this.cmbParentescoResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParentescoResponsable.FormattingEnabled = true;
            this.cmbParentescoResponsable.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Tia",
            "Tio",
            "Abuela",
            "Abuelo",
            "Otro"});
            this.cmbParentescoResponsable.Location = new System.Drawing.Point(383, 295);
            this.cmbParentescoResponsable.Name = "cmbParentescoResponsable";
            this.cmbParentescoResponsable.Size = new System.Drawing.Size(121, 26);
            this.cmbParentescoResponsable.TabIndex = 42;
            this.cmbParentescoResponsable.Text = "Madre";
            // 
            // gpbResponsable
            // 
            this.gpbResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResponsable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbResponsable.Location = new System.Drawing.Point(13, 172);
            this.gpbResponsable.Name = "gpbResponsable";
            this.gpbResponsable.Size = new System.Drawing.Size(500, 160);
            this.gpbResponsable.TabIndex = 43;
            this.gpbResponsable.TabStop = false;
            this.gpbResponsable.Text = "Datos del responsable";
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.txtPrecioCuota);
            this.Controls.Add(this.cmbParentescoResponsable);
            this.Controls.Add(this.lblTelResponsable);
            this.Controls.Add(this.txtTelResponsable);
            this.Controls.Add(this.lblNombreResponsable);
            this.Controls.Add(this.lblDNIResponsable);
            this.Controls.Add(this.lblApellidoResponsable);
            this.Controls.Add(this.cmbSexoResponsable);
            this.Controls.Add(this.txtDNIResponsable);
            this.Controls.Add(this.txtApellidoResponsable);
            this.Controls.Add(this.txtNombreResponsable);
            this.Controls.Add(this.lblPrecioCuota);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gpbResponsable);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.dtmHoraEntrada);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.dtmHoraSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Docente";
            this.Load += new System.EventHandler(this.FrmAltaDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.DateTimePicker dtmHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtmHoraSalida;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblPrecioCuota;
        private System.Windows.Forms.TextBox txtPrecioCuota;
        private System.Windows.Forms.Label lblTelResponsable;
        private System.Windows.Forms.TextBox txtTelResponsable;
        private System.Windows.Forms.Label lblNombreResponsable;
        private System.Windows.Forms.Label lblDNIResponsable;
        private System.Windows.Forms.Label lblApellidoResponsable;
        private System.Windows.Forms.ComboBox cmbSexoResponsable;
        private System.Windows.Forms.TextBox txtDNIResponsable;
        private System.Windows.Forms.TextBox txtApellidoResponsable;
        private System.Windows.Forms.TextBox txtNombreResponsable;
        private System.Windows.Forms.ComboBox cmbParentescoResponsable;
        private System.Windows.Forms.GroupBox gpbResponsable;
    }
}