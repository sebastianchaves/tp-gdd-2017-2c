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
            this.codigoPostalInput = new System.Windows.Forms.TextBox();
            this.pisoInput = new System.Windows.Forms.TextBox();
            this.departamentoInput = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.fechaDeNacimientoInput = new System.Windows.Forms.DateTimePicker();
            this.numeroDomicilioInput = new System.Windows.Forms.TextBox();
            this.numeroDomicilioLabel = new System.Windows.Forms.Label();
            this.dniTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.fechaNacimientoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.codigoPostalTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.mailTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.numeroDomicilioTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pisoDomicilioTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.datosPersonalesGroupbox = new System.Windows.Forms.GroupBox();
            this.datosContactoGroupbox = new System.Windows.Forms.GroupBox();
            this.datosDireccionGroupbox = new System.Windows.Forms.GroupBox();
            this.datosPersonalesGroupbox.SuspendLayout();
            this.datosContactoGroupbox.SuspendLayout();
            this.datosDireccionGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(79, 19);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(213, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.TextChanged += new System.EventHandler(this.nombreInput_Leave);
            // 
            // telefonoInput
            // 
            this.telefonoInput.Location = new System.Drawing.Point(64, 19);
            this.telefonoInput.Name = "telefonoInput";
            this.telefonoInput.Size = new System.Drawing.Size(107, 20);
            this.telefonoInput.TabIndex = 4;
            this.telefonoInput.TextChanged += new System.EventHandler(this.telefonoInput_Leave);
            // 
            // calleInput
            // 
            this.calleInput.Location = new System.Drawing.Point(45, 19);
            this.calleInput.Name = "calleInput";
            this.calleInput.Size = new System.Drawing.Size(99, 20);
            this.calleInput.TabIndex = 6;
            // 
            // localidadInput
            // 
            this.localidadInput.Location = new System.Drawing.Point(391, 19);
            this.localidadInput.Name = "localidadInput";
            this.localidadInput.Size = new System.Drawing.Size(99, 20);
            this.localidadInput.TabIndex = 8;
            // 
            // apellidoInput
            // 
            this.apellidoInput.Location = new System.Drawing.Point(79, 45);
            this.apellidoInput.Name = "apellidoInput";
            this.apellidoInput.Size = new System.Drawing.Size(213, 20);
            this.apellidoInput.TabIndex = 1;
            this.apellidoInput.TextChanged += new System.EventHandler(this.apellidoInput_Leave);
            // 
            // mailInput
            // 
            this.mailInput.Location = new System.Drawing.Point(64, 45);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(107, 20);
            this.mailInput.TabIndex = 5;
            this.mailInput.TextChanged += new System.EventHandler(this.mailInput_Leave);
            // 
            // dniInput
            // 
            this.dniInput.Location = new System.Drawing.Point(77, 71);
            this.dniInput.Name = "dniInput";
            this.dniInput.Size = new System.Drawing.Size(213, 20);
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
            this.nombreLabel.Location = new System.Drawing.Point(10, 22);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 9;
            this.nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(10, 48);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(47, 13);
            this.apellidoLabel.TabIndex = 10;
            this.apellidoLabel.Text = "Apellido:";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(10, 74);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(29, 13);
            this.dniLabel.TabIndex = 11;
            this.dniLabel.Text = "DNI:";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(6, 48);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(29, 13);
            this.mailLabel.TabIndex = 12;
            this.mailLabel.Text = "Mail:";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(6, 22);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(52, 13);
            this.telefonoLabel.TabIndex = 13;
            this.telefonoLabel.Text = "Teléfono:";
            // 
            // codigoPostalLabel
            // 
            this.codigoPostalLabel.AutoSize = true;
            this.codigoPostalLabel.Location = new System.Drawing.Point(9, 56);
            this.codigoPostalLabel.Name = "codigoPostalLabel";
            this.codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            this.codigoPostalLabel.TabIndex = 14;
            this.codigoPostalLabel.Text = "Código Postal:";
            // 
            // fechaDeNacimientoLabel
            // 
            this.fechaDeNacimientoLabel.AutoSize = true;
            this.fechaDeNacimientoLabel.Location = new System.Drawing.Point(10, 103);
            this.fechaDeNacimientoLabel.Name = "fechaDeNacimientoLabel";
            this.fechaDeNacimientoLabel.Size = new System.Drawing.Size(63, 13);
            this.fechaDeNacimientoLabel.TabIndex = 15;
            this.fechaDeNacimientoLabel.Text = "Nacimiento:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(6, 22);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(33, 13);
            this.direccionLabel.TabIndex = 16;
            this.direccionLabel.Text = "Calle:";
            // 
            // pisoLabel
            // 
            this.pisoLabel.AutoSize = true;
            this.pisoLabel.Location = new System.Drawing.Point(159, 56);
            this.pisoLabel.Name = "pisoLabel";
            this.pisoLabel.Size = new System.Drawing.Size(30, 13);
            this.pisoLabel.TabIndex = 17;
            this.pisoLabel.Text = "Piso:";
            // 
            // departamentoLabel
            // 
            this.departamentoLabel.AutoSize = true;
            this.departamentoLabel.Location = new System.Drawing.Point(329, 56);
            this.departamentoLabel.Name = "departamentoLabel";
            this.departamentoLabel.Size = new System.Drawing.Size(77, 13);
            this.departamentoLabel.TabIndex = 18;
            this.departamentoLabel.Text = "Departamento:";
            // 
            // localidadLabel
            // 
            this.localidadLabel.AutoSize = true;
            this.localidadLabel.Location = new System.Drawing.Point(329, 22);
            this.localidadLabel.Name = "localidadLabel";
            this.localidadLabel.Size = new System.Drawing.Size(56, 13);
            this.localidadLabel.TabIndex = 19;
            this.localidadLabel.Text = "Localidad:";
            // 
            // codigoPostalInput
            // 
            this.codigoPostalInput.Location = new System.Drawing.Point(90, 53);
            this.codigoPostalInput.Name = "codigoPostalInput";
            this.codigoPostalInput.Size = new System.Drawing.Size(54, 20);
            this.codigoPostalInput.TabIndex = 9;
            this.codigoPostalInput.TextChanged += new System.EventHandler(this.codigoPostalInput_Leave);
            // 
            // pisoInput
            // 
            this.pisoInput.Location = new System.Drawing.Point(212, 53);
            this.pisoInput.Name = "pisoInput";
            this.pisoInput.Size = new System.Drawing.Size(52, 20);
            this.pisoInput.TabIndex = 10;
            // 
            // departamentoInput
            // 
            this.departamentoInput.Location = new System.Drawing.Point(412, 53);
            this.departamentoInput.Name = "departamentoInput";
            this.departamentoInput.Size = new System.Drawing.Size(78, 20);
            this.departamentoInput.TabIndex = 11;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(169, 271);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(89, 29);
            this.botonAceptar.TabIndex = 12;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(264, 271);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 29);
            this.botonVolver.TabIndex = 13;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // fechaDeNacimientoInput
            // 
            this.fechaDeNacimientoInput.CustomFormat = "";
            this.fechaDeNacimientoInput.Location = new System.Drawing.Point(79, 97);
            this.fechaDeNacimientoInput.Name = "fechaDeNacimientoInput";
            this.fechaDeNacimientoInput.Size = new System.Drawing.Size(213, 20);
            this.fechaDeNacimientoInput.TabIndex = 3;
            this.fechaDeNacimientoInput.ValueChanged += new System.EventHandler(this.fechaDeNacimientoInput_Leave);
            // 
            // numeroDomicilioInput
            // 
            this.numeroDomicilioInput.Location = new System.Drawing.Point(212, 19);
            this.numeroDomicilioInput.Name = "numeroDomicilioInput";
            this.numeroDomicilioInput.Size = new System.Drawing.Size(99, 20);
            this.numeroDomicilioInput.TabIndex = 7;
            // 
            // numeroDomicilioLabel
            // 
            this.numeroDomicilioLabel.AutoSize = true;
            this.numeroDomicilioLabel.Location = new System.Drawing.Point(159, 22);
            this.numeroDomicilioLabel.Name = "numeroDomicilioLabel";
            this.numeroDomicilioLabel.Size = new System.Drawing.Size(47, 13);
            this.numeroDomicilioLabel.TabIndex = 30;
            this.numeroDomicilioLabel.Text = "Número:";
            // 
            // datosPersonalesGroupbox
            // 
            this.datosPersonalesGroupbox.Controls.Add(this.nombreInput);
            this.datosPersonalesGroupbox.Controls.Add(this.dniInput);
            this.datosPersonalesGroupbox.Controls.Add(this.nombreLabel);
            this.datosPersonalesGroupbox.Controls.Add(this.apellidoInput);
            this.datosPersonalesGroupbox.Controls.Add(this.fechaDeNacimientoInput);
            this.datosPersonalesGroupbox.Controls.Add(this.apellidoLabel);
            this.datosPersonalesGroupbox.Controls.Add(this.dniLabel);
            this.datosPersonalesGroupbox.Controls.Add(this.fechaDeNacimientoLabel);
            this.datosPersonalesGroupbox.Location = new System.Drawing.Point(12, 36);
            this.datosPersonalesGroupbox.Name = "datosPersonalesGroupbox";
            this.datosPersonalesGroupbox.Size = new System.Drawing.Size(306, 134);
            this.datosPersonalesGroupbox.TabIndex = 31;
            this.datosPersonalesGroupbox.TabStop = false;
            this.datosPersonalesGroupbox.Text = "Datos personales";
            // 
            // datosContactoGroupbox
            // 
            this.datosContactoGroupbox.Controls.Add(this.telefonoInput);
            this.datosContactoGroupbox.Controls.Add(this.telefonoLabel);
            this.datosContactoGroupbox.Controls.Add(this.mailLabel);
            this.datosContactoGroupbox.Controls.Add(this.mailInput);
            this.datosContactoGroupbox.Location = new System.Drawing.Point(324, 36);
            this.datosContactoGroupbox.Name = "datosContactoGroupbox";
            this.datosContactoGroupbox.Size = new System.Drawing.Size(185, 81);
            this.datosContactoGroupbox.TabIndex = 12;
            this.datosContactoGroupbox.TabStop = false;
            this.datosContactoGroupbox.Text = "Datos de contacto";
            // 
            // datosDireccionGroupbox
            // 
            this.datosDireccionGroupbox.Controls.Add(this.calleInput);
            this.datosDireccionGroupbox.Controls.Add(this.direccionLabel);
            this.datosDireccionGroupbox.Controls.Add(this.numeroDomicilioLabel);
            this.datosDireccionGroupbox.Controls.Add(this.numeroDomicilioInput);
            this.datosDireccionGroupbox.Controls.Add(this.localidadLabel);
            this.datosDireccionGroupbox.Controls.Add(this.departamentoInput);
            this.datosDireccionGroupbox.Controls.Add(this.localidadInput);
            this.datosDireccionGroupbox.Controls.Add(this.departamentoLabel);
            this.datosDireccionGroupbox.Controls.Add(this.pisoInput);
            this.datosDireccionGroupbox.Controls.Add(this.codigoPostalLabel);
            this.datosDireccionGroupbox.Controls.Add(this.codigoPostalInput);
            this.datosDireccionGroupbox.Controls.Add(this.pisoLabel);
            this.datosDireccionGroupbox.Location = new System.Drawing.Point(13, 176);
            this.datosDireccionGroupbox.Name = "datosDireccionGroupbox";
            this.datosDireccionGroupbox.Size = new System.Drawing.Size(496, 89);
            this.datosDireccionGroupbox.TabIndex = 32;
            this.datosDireccionGroupbox.TabStop = false;
            this.datosDireccionGroupbox.Text = "Datos direccion";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 312);
            this.Controls.Add(this.datosDireccionGroupbox);
            this.Controls.Add(this.datosContactoGroupbox);
            this.Controls.Add(this.datosPersonalesGroupbox);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.altaClienteLabel);
            this.Name = "AltaCliente";
            this.Text = "Alta Cliente";
            this.datosPersonalesGroupbox.ResumeLayout(false);
            this.datosPersonalesGroupbox.PerformLayout();
            this.datosContactoGroupbox.ResumeLayout(false);
            this.datosContactoGroupbox.PerformLayout();
            this.datosDireccionGroupbox.ResumeLayout(false);
            this.datosDireccionGroupbox.PerformLayout();
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
        private System.Windows.Forms.TextBox codigoPostalInput;
        private System.Windows.Forms.TextBox pisoInput;
        private System.Windows.Forms.TextBox departamentoInput;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DateTimePicker fechaDeNacimientoInput;
        private System.Windows.Forms.TextBox numeroDomicilioInput;
        private System.Windows.Forms.Label numeroDomicilioLabel;
        private System.Windows.Forms.ToolTip dniTooltip;
        private System.Windows.Forms.ToolTip fechaNacimientoTooltip;
        private System.Windows.Forms.ToolTip codigoPostalTooltip;
        private System.Windows.Forms.ToolTip mailTooltip;
        private System.Windows.Forms.ToolTip numeroDomicilioTooltip;
        private System.Windows.Forms.ToolTip pisoDomicilioTooltip;
        private System.Windows.Forms.GroupBox datosPersonalesGroupbox;
        private System.Windows.Forms.GroupBox datosContactoGroupbox;
        private System.Windows.Forms.GroupBox datosDireccionGroupbox;
    }
}