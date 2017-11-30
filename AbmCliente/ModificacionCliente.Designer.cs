namespace PagoAgilFrba.AbmCliente
{
    partial class ModificacionCliente
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
            this.datosClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.habilitacionLabel = new System.Windows.Forms.Label();
            this.deshabilitadoRadioButton = new System.Windows.Forms.RadioButton();
            this.habilitadoRadioButton = new System.Windows.Forms.RadioButton();
            this.domicilioGroupBox = new System.Windows.Forms.GroupBox();
            this.localidadLabel = new System.Windows.Forms.Label();
            this.departamentoInput = new System.Windows.Forms.TextBox();
            this.localidadInput = new System.Windows.Forms.TextBox();
            this.pisoInput = new System.Windows.Forms.TextBox();
            this.numeroDomicilioInput = new System.Windows.Forms.TextBox();
            this.departamentoLabel = new System.Windows.Forms.Label();
            this.numeroDomicilioLabel = new System.Windows.Forms.Label();
            this.codigoPostalInput = new System.Windows.Forms.TextBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.pisoLabel = new System.Windows.Forms.Label();
            this.codigoPostalLabel = new System.Windows.Forms.Label();
            this.calleInput = new System.Windows.Forms.TextBox();
            this.fechaDeNacimientoInput = new System.Windows.Forms.DateTimePicker();
            this.dniInput = new System.Windows.Forms.TextBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellidoInput = new System.Windows.Forms.TextBox();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaDeNacimientoLabel = new System.Windows.Forms.Label();
            this.telefonoInput = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.modificacionClienteLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.dniTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.fechaNacimientoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.datosClienteGroupBox.SuspendLayout();
            this.domicilioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // datosClienteGroupBox
            // 
            this.datosClienteGroupBox.Controls.Add(this.habilitacionLabel);
            this.datosClienteGroupBox.Controls.Add(this.deshabilitadoRadioButton);
            this.datosClienteGroupBox.Controls.Add(this.habilitadoRadioButton);
            this.datosClienteGroupBox.Controls.Add(this.domicilioGroupBox);
            this.datosClienteGroupBox.Controls.Add(this.fechaDeNacimientoInput);
            this.datosClienteGroupBox.Controls.Add(this.dniInput);
            this.datosClienteGroupBox.Controls.Add(this.nombreInput);
            this.datosClienteGroupBox.Controls.Add(this.label3);
            this.datosClienteGroupBox.Controls.Add(this.label2);
            this.datosClienteGroupBox.Controls.Add(this.apellidoInput);
            this.datosClienteGroupBox.Controls.Add(this.telefonoLabel);
            this.datosClienteGroupBox.Controls.Add(this.label1);
            this.datosClienteGroupBox.Controls.Add(this.fechaDeNacimientoLabel);
            this.datosClienteGroupBox.Controls.Add(this.telefonoInput);
            this.datosClienteGroupBox.Controls.Add(this.mailLabel);
            this.datosClienteGroupBox.Controls.Add(this.mailInput);
            this.datosClienteGroupBox.Location = new System.Drawing.Point(12, 36);
            this.datosClienteGroupBox.Name = "datosClienteGroupBox";
            this.datosClienteGroupBox.Size = new System.Drawing.Size(360, 337);
            this.datosClienteGroupBox.TabIndex = 6;
            this.datosClienteGroupBox.TabStop = false;
            this.datosClienteGroupBox.Text = "Datos Cliente";
            // 
            // habilitacionLabel
            // 
            this.habilitacionLabel.AutoSize = true;
            this.habilitacionLabel.Location = new System.Drawing.Point(18, 305);
            this.habilitacionLabel.Name = "habilitacionLabel";
            this.habilitacionLabel.Size = new System.Drawing.Size(65, 13);
            this.habilitacionLabel.TabIndex = 65;
            this.habilitacionLabel.Text = "Habilitación:";
            // 
            // deshabilitadoRadioButton
            // 
            this.deshabilitadoRadioButton.AutoSize = true;
            this.deshabilitadoRadioButton.Enabled = false;
            this.deshabilitadoRadioButton.Location = new System.Drawing.Point(250, 303);
            this.deshabilitadoRadioButton.Name = "deshabilitadoRadioButton";
            this.deshabilitadoRadioButton.Size = new System.Drawing.Size(89, 17);
            this.deshabilitadoRadioButton.TabIndex = 16;
            this.deshabilitadoRadioButton.TabStop = true;
            this.deshabilitadoRadioButton.Text = "Deshabilitado";
            this.deshabilitadoRadioButton.UseVisualStyleBackColor = true;
            this.deshabilitadoRadioButton.CheckedChanged += new System.EventHandler(this.deshabilitadoRadioButton_CheckedChanged);
            // 
            // habilitadoRadioButton
            // 
            this.habilitadoRadioButton.AutoSize = true;
            this.habilitadoRadioButton.Enabled = false;
            this.habilitadoRadioButton.Location = new System.Drawing.Point(104, 303);
            this.habilitadoRadioButton.Name = "habilitadoRadioButton";
            this.habilitadoRadioButton.Size = new System.Drawing.Size(72, 17);
            this.habilitadoRadioButton.TabIndex = 15;
            this.habilitadoRadioButton.TabStop = true;
            this.habilitadoRadioButton.Text = "Habilitado";
            this.habilitadoRadioButton.UseVisualStyleBackColor = true;
            this.habilitadoRadioButton.CheckedChanged += new System.EventHandler(this.habilitadoRadioButton_CheckedChanged);
            // 
            // domicilioGroupBox
            // 
            this.domicilioGroupBox.Controls.Add(this.localidadLabel);
            this.domicilioGroupBox.Controls.Add(this.departamentoInput);
            this.domicilioGroupBox.Controls.Add(this.localidadInput);
            this.domicilioGroupBox.Controls.Add(this.pisoInput);
            this.domicilioGroupBox.Controls.Add(this.numeroDomicilioInput);
            this.domicilioGroupBox.Controls.Add(this.departamentoLabel);
            this.domicilioGroupBox.Controls.Add(this.numeroDomicilioLabel);
            this.domicilioGroupBox.Controls.Add(this.codigoPostalInput);
            this.domicilioGroupBox.Controls.Add(this.direccionLabel);
            this.domicilioGroupBox.Controls.Add(this.pisoLabel);
            this.domicilioGroupBox.Controls.Add(this.codigoPostalLabel);
            this.domicilioGroupBox.Controls.Add(this.calleInput);
            this.domicilioGroupBox.Location = new System.Drawing.Point(21, 179);
            this.domicilioGroupBox.Name = "domicilioGroupBox";
            this.domicilioGroupBox.Size = new System.Drawing.Size(324, 108);
            this.domicilioGroupBox.TabIndex = 62;
            this.domicilioGroupBox.TabStop = false;
            this.domicilioGroupBox.Text = "Domicilio";
            // 
            // localidadLabel
            // 
            this.localidadLabel.AutoSize = true;
            this.localidadLabel.Location = new System.Drawing.Point(6, 76);
            this.localidadLabel.Name = "localidadLabel";
            this.localidadLabel.Size = new System.Drawing.Size(56, 13);
            this.localidadLabel.TabIndex = 37;
            this.localidadLabel.Text = "Localidad:";
            // 
            // departamentoInput
            // 
            this.departamentoInput.Enabled = false;
            this.departamentoInput.Location = new System.Drawing.Point(281, 73);
            this.departamentoInput.MaxLength = 10;
            this.departamentoInput.Name = "departamentoInput";
            this.departamentoInput.Size = new System.Drawing.Size(37, 20);
            this.departamentoInput.TabIndex = 14;
            // 
            // localidadInput
            // 
            this.localidadInput.Enabled = false;
            this.localidadInput.Location = new System.Drawing.Point(83, 73);
            this.localidadInput.MaxLength = 50;
            this.localidadInput.Name = "localidadInput";
            this.localidadInput.Size = new System.Drawing.Size(100, 20);
            this.localidadInput.TabIndex = 11;
            // 
            // pisoInput
            // 
            this.pisoInput.Enabled = false;
            this.pisoInput.Location = new System.Drawing.Point(281, 47);
            this.pisoInput.MaxLength = 10;
            this.pisoInput.Name = "pisoInput";
            this.pisoInput.Size = new System.Drawing.Size(37, 20);
            this.pisoInput.TabIndex = 13;
            // 
            // numeroDomicilioInput
            // 
            this.numeroDomicilioInput.Enabled = false;
            this.numeroDomicilioInput.Location = new System.Drawing.Point(83, 47);
            this.numeroDomicilioInput.MaxLength = 20;
            this.numeroDomicilioInput.Name = "numeroDomicilioInput";
            this.numeroDomicilioInput.Size = new System.Drawing.Size(100, 20);
            this.numeroDomicilioInput.TabIndex = 10;
            // 
            // departamentoLabel
            // 
            this.departamentoLabel.AutoSize = true;
            this.departamentoLabel.Location = new System.Drawing.Point(198, 76);
            this.departamentoLabel.Name = "departamentoLabel";
            this.departamentoLabel.Size = new System.Drawing.Size(77, 13);
            this.departamentoLabel.TabIndex = 36;
            this.departamentoLabel.Text = "Departamento:";
            // 
            // numeroDomicilioLabel
            // 
            this.numeroDomicilioLabel.AutoSize = true;
            this.numeroDomicilioLabel.Location = new System.Drawing.Point(6, 50);
            this.numeroDomicilioLabel.Name = "numeroDomicilioLabel";
            this.numeroDomicilioLabel.Size = new System.Drawing.Size(47, 13);
            this.numeroDomicilioLabel.TabIndex = 42;
            this.numeroDomicilioLabel.Text = "Número:";
            // 
            // codigoPostalInput
            // 
            this.codigoPostalInput.Enabled = false;
            this.codigoPostalInput.Location = new System.Drawing.Point(281, 21);
            this.codigoPostalInput.MaxLength = 20;
            this.codigoPostalInput.Name = "codigoPostalInput";
            this.codigoPostalInput.Size = new System.Drawing.Size(37, 20);
            this.codigoPostalInput.TabIndex = 12;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(6, 24);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(33, 13);
            this.direccionLabel.TabIndex = 34;
            this.direccionLabel.Text = "Calle:";
            // 
            // pisoLabel
            // 
            this.pisoLabel.AutoSize = true;
            this.pisoLabel.Location = new System.Drawing.Point(198, 50);
            this.pisoLabel.Name = "pisoLabel";
            this.pisoLabel.Size = new System.Drawing.Size(30, 13);
            this.pisoLabel.TabIndex = 35;
            this.pisoLabel.Text = "Piso:";
            // 
            // codigoPostalLabel
            // 
            this.codigoPostalLabel.AutoSize = true;
            this.codigoPostalLabel.Location = new System.Drawing.Point(198, 24);
            this.codigoPostalLabel.Name = "codigoPostalLabel";
            this.codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            this.codigoPostalLabel.TabIndex = 33;
            this.codigoPostalLabel.Text = "Código Postal:";
            // 
            // calleInput
            // 
            this.calleInput.Enabled = false;
            this.calleInput.Location = new System.Drawing.Point(83, 21);
            this.calleInput.MaxLength = 80;
            this.calleInput.Name = "calleInput";
            this.calleInput.Size = new System.Drawing.Size(100, 20);
            this.calleInput.TabIndex = 9;
            // 
            // fechaDeNacimientoInput
            // 
            this.fechaDeNacimientoInput.Enabled = false;
            this.fechaDeNacimientoInput.Location = new System.Drawing.Point(104, 127);
            this.fechaDeNacimientoInput.Name = "fechaDeNacimientoInput";
            this.fechaDeNacimientoInput.Size = new System.Drawing.Size(235, 20);
            this.fechaDeNacimientoInput.TabIndex = 7;
            this.fechaDeNacimientoInput.Leave += new System.EventHandler(this.fechaDeNacimientoInput_Leave);
            // 
            // dniInput
            // 
            this.dniInput.Enabled = false;
            this.dniInput.Location = new System.Drawing.Point(104, 75);
            this.dniInput.MaxLength = 9;
            this.dniInput.Name = "dniInput";
            this.dniInput.Size = new System.Drawing.Size(235, 20);
            this.dniInput.TabIndex = 5;
            this.dniInput.Leave += new System.EventHandler(this.dniInput_Leave);
            // 
            // nombreInput
            // 
            this.nombreInput.Enabled = false;
            this.nombreInput.Location = new System.Drawing.Point(104, 23);
            this.nombreInput.MaxLength = 255;
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(235, 20);
            this.nombreInput.TabIndex = 3;
            this.nombreInput.Leave += new System.EventHandler(this.nombreInput_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Apellido:";
            // 
            // apellidoInput
            // 
            this.apellidoInput.Enabled = false;
            this.apellidoInput.Location = new System.Drawing.Point(104, 49);
            this.apellidoInput.MaxLength = 255;
            this.apellidoInput.Name = "apellidoInput";
            this.apellidoInput.Size = new System.Drawing.Size(235, 20);
            this.apellidoInput.TabIndex = 4;
            this.apellidoInput.Leave += new System.EventHandler(this.apellidoInput_Leave);
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(18, 156);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(52, 13);
            this.telefonoLabel.TabIndex = 43;
            this.telefonoLabel.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "DNI:";
            // 
            // fechaDeNacimientoLabel
            // 
            this.fechaDeNacimientoLabel.AutoSize = true;
            this.fechaDeNacimientoLabel.Location = new System.Drawing.Point(18, 130);
            this.fechaDeNacimientoLabel.Name = "fechaDeNacimientoLabel";
            this.fechaDeNacimientoLabel.Size = new System.Drawing.Size(81, 13);
            this.fechaDeNacimientoLabel.TabIndex = 45;
            this.fechaDeNacimientoLabel.Text = "Fecha de Nac.:";
            // 
            // telefonoInput
            // 
            this.telefonoInput.Enabled = false;
            this.telefonoInput.Location = new System.Drawing.Point(104, 153);
            this.telefonoInput.MaxLength = 20;
            this.telefonoInput.Name = "telefonoInput";
            this.telefonoInput.Size = new System.Drawing.Size(235, 20);
            this.telefonoInput.TabIndex = 8;
            this.telefonoInput.Leave += new System.EventHandler(this.telefonoInput_Leave);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(18, 104);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(29, 13);
            this.mailLabel.TabIndex = 42;
            this.mailLabel.Text = "Mail:";
            // 
            // mailInput
            // 
            this.mailInput.Enabled = false;
            this.mailInput.Location = new System.Drawing.Point(104, 101);
            this.mailInput.MaxLength = 255;
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(235, 20);
            this.mailInput.TabIndex = 6;
            this.mailInput.Leave += new System.EventHandler(this.mailInput_Leave);
            // 
            // modificacionClienteLabel
            // 
            this.modificacionClienteLabel.AutoSize = true;
            this.modificacionClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionClienteLabel.Location = new System.Drawing.Point(135, 9);
            this.modificacionClienteLabel.Name = "modificacionClienteLabel";
            this.modificacionClienteLabel.Size = new System.Drawing.Size(126, 20);
            this.modificacionClienteLabel.TabIndex = 14;
            this.modificacionClienteLabel.Text = "Modificar Cliente";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(53, 379);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 0;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.Enabled = false;
            this.botonActualizar.Location = new System.Drawing.Point(149, 379);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(90, 30);
            this.botonActualizar.TabIndex = 1;
            this.botonActualizar.Text = "&Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(245, 379);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // ModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 419);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.modificacionClienteLabel);
            this.Controls.Add(this.datosClienteGroupBox);
            this.Name = "ModificacionCliente";
            this.Text = "Modificar Cliente";
            this.datosClienteGroupBox.ResumeLayout(false);
            this.datosClienteGroupBox.PerformLayout();
            this.domicilioGroupBox.ResumeLayout(false);
            this.domicilioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox datosClienteGroupBox;
        private System.Windows.Forms.TextBox dniInput;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidoInput;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fechaDeNacimientoLabel;
        private System.Windows.Forms.TextBox telefonoInput;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox mailInput;
        private System.Windows.Forms.Label modificacionClienteLabel;
        private System.Windows.Forms.DateTimePicker fechaDeNacimientoInput;
        private System.Windows.Forms.Label numeroDomicilioLabel;
        private System.Windows.Forms.TextBox numeroDomicilioInput;
        private System.Windows.Forms.TextBox departamentoInput;
        private System.Windows.Forms.TextBox pisoInput;
        private System.Windows.Forms.TextBox codigoPostalInput;
        private System.Windows.Forms.Label localidadLabel;
        private System.Windows.Forms.Label departamentoLabel;
        private System.Windows.Forms.Label pisoLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label codigoPostalLabel;
        private System.Windows.Forms.TextBox localidadInput;
        private System.Windows.Forms.TextBox calleInput;
        private System.Windows.Forms.GroupBox domicilioGroupBox;
        private System.Windows.Forms.Label habilitacionLabel;
        private System.Windows.Forms.RadioButton deshabilitadoRadioButton;
        private System.Windows.Forms.RadioButton habilitadoRadioButton;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.ToolTip dniTooltip;
        private System.Windows.Forms.ToolTip fechaNacimientoTooltip;
    }
}