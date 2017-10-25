namespace PagoAgilFrba.AbmCliente
{
    partial class AltaCliente
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
            this.components = new System.ComponentModel.Container();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.telefonoInput = new System.Windows.Forms.TextBox();
            this.calleInput = new System.Windows.Forms.TextBox();
            this.localidadInput = new System.Windows.Forms.TextBox();
            this.apellidoInput = new System.Windows.Forms.TextBox();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.dniInput = new System.Windows.Forms.TextBox();
            this.altaClienteLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.codigoPostalLabel = new System.Windows.Forms.Label();
            this.fechaDeNacimientoLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.pisoLabel = new System.Windows.Forms.Label();
            this.departamentoLabel = new System.Windows.Forms.Label();
            this.localidadLabel = new System.Windows.Forms.Label();
            this.datosDeContactoLabel = new System.Windows.Forms.Label();
            this.domicilioLabel = new System.Windows.Forms.Label();
            this.codigoPostalInput = new System.Windows.Forms.TextBox();
            this.pisoInput = new System.Windows.Forms.TextBox();
            this.departamentoInput = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.fechaDeNacimientoInput = new System.Windows.Forms.DateTimePicker();
            this.numeroDomicilioInput = new System.Windows.Forms.TextBox();
            this.numeroDomicilioLabel = new System.Windows.Forms.Label();
            this.datosPersonalesLabel = new System.Windows.Forms.Label();
            this.dniTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.fechaNacimientoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.codigoPostalTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.mailTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.numeroDomicilioTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pisoDomicilioTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(25, 87);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(107, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.TextChanged += new System.EventHandler(this.nombreInput_Leave);
            // 
            // telefonoInput
            // 
            this.telefonoInput.Location = new System.Drawing.Point(25, 212);
            this.telefonoInput.Name = "telefonoInput";
            this.telefonoInput.Size = new System.Drawing.Size(107, 20);
            this.telefonoInput.TabIndex = 4;
            this.telefonoInput.TextChanged += new System.EventHandler(this.telefonoInput_Leave);
            // 
            // calleInput
            // 
            this.calleInput.Location = new System.Drawing.Point(61, 283);
            this.calleInput.Name = "calleInput";
            this.calleInput.Size = new System.Drawing.Size(107, 20);
            this.calleInput.TabIndex = 6;
            this.calleInput.TextChanged += new System.EventHandler(this.calleInput_Leave);
            // 
            // localidadInput
            // 
            this.localidadInput.Location = new System.Drawing.Point(400, 283);
            this.localidadInput.Name = "localidadInput";
            this.localidadInput.Size = new System.Drawing.Size(107, 20);
            this.localidadInput.TabIndex = 8;
            this.localidadInput.TextChanged += new System.EventHandler(this.localidadInput_Leave);
            // 
            // apellidoInput
            // 
            this.apellidoInput.Location = new System.Drawing.Point(195, 87);
            this.apellidoInput.Name = "apellidoInput";
            this.apellidoInput.Size = new System.Drawing.Size(107, 20);
            this.apellidoInput.TabIndex = 1;
            this.apellidoInput.TextChanged += new System.EventHandler(this.apellidoInput_Leave);
            // 
            // mailInput
            // 
            this.mailInput.Location = new System.Drawing.Point(150, 212);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(107, 20);
            this.mailInput.TabIndex = 5;
            this.mailInput.TextChanged += new System.EventHandler(this.mailInput_Leave);
            // 
            // dniInput
            // 
            this.dniInput.Location = new System.Drawing.Point(365, 87);
            this.dniInput.Name = "dniInput";
            this.dniInput.Size = new System.Drawing.Size(107, 20);
            this.dniInput.TabIndex = 2;
            this.dniInput.TextChanged += new System.EventHandler(this.dniInput_Leave);
            // 
            // altaClienteLabel
            // 
            this.altaClienteLabel.AutoSize = true;
            this.altaClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaClienteLabel.Location = new System.Drawing.Point(207, 9);
            this.altaClienteLabel.Name = "altaClienteLabel";
            this.altaClienteLabel.Size = new System.Drawing.Size(104, 24);
            this.altaClienteLabel.TabIndex = 8;
            this.altaClienteLabel.Text = "Alta Cliente";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(22, 71);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 9;
            this.nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(192, 71);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(47, 13);
            this.apellidoLabel.TabIndex = 10;
            this.apellidoLabel.Text = "Apellido:";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(362, 71);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(29, 13);
            this.dniLabel.TabIndex = 11;
            this.dniLabel.Text = "DNI:";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(145, 196);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(29, 13);
            this.mailLabel.TabIndex = 12;
            this.mailLabel.Text = "Mail:";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(22, 196);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(52, 13);
            this.telefonoLabel.TabIndex = 13;
            this.telefonoLabel.Text = "Teléfono:";
            // 
            // codigoPostalLabel
            // 
            this.codigoPostalLabel.AutoSize = true;
            this.codigoPostalLabel.Location = new System.Drawing.Point(22, 330);
            this.codigoPostalLabel.Name = "codigoPostalLabel";
            this.codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            this.codigoPostalLabel.TabIndex = 14;
            this.codigoPostalLabel.Text = "Código Postal:";
            // 
            // fechaDeNacimientoLabel
            // 
            this.fechaDeNacimientoLabel.AutoSize = true;
            this.fechaDeNacimientoLabel.Location = new System.Drawing.Point(22, 131);
            this.fechaDeNacimientoLabel.Name = "fechaDeNacimientoLabel";
            this.fechaDeNacimientoLabel.Size = new System.Drawing.Size(111, 13);
            this.fechaDeNacimientoLabel.TabIndex = 15;
            this.fechaDeNacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(22, 286);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(33, 13);
            this.direccionLabel.TabIndex = 16;
            this.direccionLabel.Text = "Calle:";
            // 
            // pisoLabel
            // 
            this.pisoLabel.AutoSize = true;
            this.pisoLabel.Location = new System.Drawing.Point(170, 330);
            this.pisoLabel.Name = "pisoLabel";
            this.pisoLabel.Size = new System.Drawing.Size(30, 13);
            this.pisoLabel.TabIndex = 17;
            this.pisoLabel.Text = "Piso:";
            // 
            // departamentoLabel
            // 
            this.departamentoLabel.AutoSize = true;
            this.departamentoLabel.Location = new System.Drawing.Point(278, 330);
            this.departamentoLabel.Name = "departamentoLabel";
            this.departamentoLabel.Size = new System.Drawing.Size(77, 13);
            this.departamentoLabel.TabIndex = 18;
            this.departamentoLabel.Text = "Departamento:";
            // 
            // localidadLabel
            // 
            this.localidadLabel.AutoSize = true;
            this.localidadLabel.Location = new System.Drawing.Point(338, 286);
            this.localidadLabel.Name = "localidadLabel";
            this.localidadLabel.Size = new System.Drawing.Size(56, 13);
            this.localidadLabel.TabIndex = 19;
            this.localidadLabel.Text = "Localidad:";
            // 
            // datosDeContactoLabel
            // 
            this.datosDeContactoLabel.AutoSize = true;
            this.datosDeContactoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosDeContactoLabel.Location = new System.Drawing.Point(22, 164);
            this.datosDeContactoLabel.Name = "datosDeContactoLabel";
            this.datosDeContactoLabel.Size = new System.Drawing.Size(129, 17);
            this.datosDeContactoLabel.TabIndex = 21;
            this.datosDeContactoLabel.Text = "Datos de Contacto:";
            // 
            // domicilioLabel
            // 
            this.domicilioLabel.AutoSize = true;
            this.domicilioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilioLabel.Location = new System.Drawing.Point(22, 254);
            this.domicilioLabel.Name = "domicilioLabel";
            this.domicilioLabel.Size = new System.Drawing.Size(68, 17);
            this.domicilioLabel.TabIndex = 22;
            this.domicilioLabel.Text = "Domicilio:";
            // 
            // codigoPostalInput
            // 
            this.codigoPostalInput.Location = new System.Drawing.Point(103, 327);
            this.codigoPostalInput.Name = "codigoPostalInput";
            this.codigoPostalInput.Size = new System.Drawing.Size(37, 20);
            this.codigoPostalInput.TabIndex = 9;
            this.codigoPostalInput.TextChanged += new System.EventHandler(this.codigoPostalInput_Leave);
            // 
            // pisoInput
            // 
            this.pisoInput.Location = new System.Drawing.Point(211, 327);
            this.pisoInput.Name = "pisoInput";
            this.pisoInput.Size = new System.Drawing.Size(37, 20);
            this.pisoInput.TabIndex = 10;
            this.pisoInput.TextChanged += new System.EventHandler(this.pisoInput_Leave);
            // 
            // departamentoInput
            // 
            this.departamentoInput.Location = new System.Drawing.Point(361, 327);
            this.departamentoInput.Name = "departamentoInput";
            this.departamentoInput.Size = new System.Drawing.Size(31, 20);
            this.departamentoInput.TabIndex = 11;
            this.departamentoInput.TextChanged += new System.EventHandler(this.departamentoInput_Leave);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(170, 376);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(89, 29);
            this.botonAceptar.TabIndex = 12;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(276, 376);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(89, 29);
            this.botonCancelar.TabIndex = 13;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // fechaDeNacimientoInput
            // 
            this.fechaDeNacimientoInput.Location = new System.Drawing.Point(139, 125);
            this.fechaDeNacimientoInput.Name = "fechaDeNacimientoInput";
            this.fechaDeNacimientoInput.Size = new System.Drawing.Size(230, 20);
            this.fechaDeNacimientoInput.TabIndex = 3;
            this.fechaDeNacimientoInput.ValueChanged += new System.EventHandler(this.fechaDeNacimientoInput_Leave);
            // 
            // numeroDomicilioInput
            // 
            this.numeroDomicilioInput.Location = new System.Drawing.Point(232, 283);
            this.numeroDomicilioInput.Name = "numeroDomicilioInput";
            this.numeroDomicilioInput.Size = new System.Drawing.Size(100, 20);
            this.numeroDomicilioInput.TabIndex = 7;
            this.numeroDomicilioInput.TextChanged += new System.EventHandler(this.numeroDomicilioInput_Leave);
            // 
            // numeroDomicilioLabel
            // 
            this.numeroDomicilioLabel.AutoSize = true;
            this.numeroDomicilioLabel.Location = new System.Drawing.Point(179, 286);
            this.numeroDomicilioLabel.Name = "numeroDomicilioLabel";
            this.numeroDomicilioLabel.Size = new System.Drawing.Size(47, 13);
            this.numeroDomicilioLabel.TabIndex = 30;
            this.numeroDomicilioLabel.Text = "Número:";
            // 
            // datosPersonalesLabel
            // 
            this.datosPersonalesLabel.AutoSize = true;
            this.datosPersonalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosPersonalesLabel.Location = new System.Drawing.Point(22, 45);
            this.datosPersonalesLabel.Name = "datosPersonalesLabel";
            this.datosPersonalesLabel.Size = new System.Drawing.Size(124, 17);
            this.datosPersonalesLabel.TabIndex = 20;
            this.datosPersonalesLabel.Text = "Datos Personales:";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 417);
            this.Controls.Add(this.dniInput);
            this.Controls.Add(this.numeroDomicilioLabel);
            this.Controls.Add(this.numeroDomicilioInput);
            this.Controls.Add(this.fechaDeNacimientoInput);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.departamentoInput);
            this.Controls.Add(this.pisoInput);
            this.Controls.Add(this.codigoPostalInput);
            this.Controls.Add(this.domicilioLabel);
            this.Controls.Add(this.datosDeContactoLabel);
            this.Controls.Add(this.datosPersonalesLabel);
            this.Controls.Add(this.localidadLabel);
            this.Controls.Add(this.departamentoLabel);
            this.Controls.Add(this.pisoLabel);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.fechaDeNacimientoLabel);
            this.Controls.Add(this.codigoPostalLabel);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.altaClienteLabel);
            this.Controls.Add(this.mailInput);
            this.Controls.Add(this.apellidoInput);
            this.Controls.Add(this.localidadInput);
            this.Controls.Add(this.calleInput);
            this.Controls.Add(this.telefonoInput);
            this.Controls.Add(this.nombreInput);
            this.Name = "AltaCliente";
            this.Text = "Alta Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.TextBox telefonoInput;
        private System.Windows.Forms.TextBox calleInput;
        private System.Windows.Forms.TextBox localidadInput;
        private System.Windows.Forms.TextBox apellidoInput;
        private System.Windows.Forms.TextBox mailInput;
        private System.Windows.Forms.TextBox dniInput;
        private System.Windows.Forms.Label altaClienteLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label codigoPostalLabel;
        private System.Windows.Forms.Label fechaDeNacimientoLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label pisoLabel;
        private System.Windows.Forms.Label departamentoLabel;
        private System.Windows.Forms.Label localidadLabel;
        private System.Windows.Forms.Label datosDeContactoLabel;
        private System.Windows.Forms.Label domicilioLabel;
        private System.Windows.Forms.TextBox codigoPostalInput;
        private System.Windows.Forms.TextBox pisoInput;
        private System.Windows.Forms.TextBox departamentoInput;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.DateTimePicker fechaDeNacimientoInput;
        private System.Windows.Forms.TextBox numeroDomicilioInput;
        private System.Windows.Forms.Label numeroDomicilioLabel;
        private System.Windows.Forms.Label datosPersonalesLabel;
        private System.Windows.Forms.ToolTip dniTooltip;
        private System.Windows.Forms.ToolTip fechaNacimientoTooltip;
        private System.Windows.Forms.ToolTip codigoPostalTooltip;
        private System.Windows.Forms.ToolTip mailTooltip;
        private System.Windows.Forms.ToolTip numeroDomicilioTooltip;
        private System.Windows.Forms.ToolTip pisoDomicilioTooltip;
    }
}