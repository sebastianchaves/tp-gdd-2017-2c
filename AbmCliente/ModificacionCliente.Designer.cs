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
            this.resultadosGrid = new System.Windows.Forms.DataGridView();
            this.clientesEncontradosLabel = new System.Windows.Forms.Label();
            this.modificacionClienteLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.datosClienteGroupBox.SuspendLayout();
            this.domicilioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).BeginInit();
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
            this.datosClienteGroupBox.Location = new System.Drawing.Point(264, 58);
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
            this.departamentoInput.Location = new System.Drawing.Point(281, 73);
            this.departamentoInput.Name = "departamentoInput";
            this.departamentoInput.Size = new System.Drawing.Size(37, 20);
            this.departamentoInput.TabIndex = 14;
            // 
            // localidadInput
            // 
            this.localidadInput.Location = new System.Drawing.Point(83, 73);
            this.localidadInput.Name = "localidadInput";
            this.localidadInput.Size = new System.Drawing.Size(100, 20);
            this.localidadInput.TabIndex = 11;
            // 
            // pisoInput
            // 
            this.pisoInput.Location = new System.Drawing.Point(281, 47);
            this.pisoInput.Name = "pisoInput";
            this.pisoInput.Size = new System.Drawing.Size(37, 20);
            this.pisoInput.TabIndex = 13;
            // 
            // numeroDomicilioInput
            // 
            this.numeroDomicilioInput.Location = new System.Drawing.Point(83, 47);
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
            this.codigoPostalInput.Location = new System.Drawing.Point(281, 21);
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
            this.calleInput.Location = new System.Drawing.Point(83, 21);
            this.calleInput.Name = "calleInput";
            this.calleInput.Size = new System.Drawing.Size(100, 20);
            this.calleInput.TabIndex = 9;
            // 
            // fechaDeNacimientoInput
            // 
            this.fechaDeNacimientoInput.Location = new System.Drawing.Point(104, 127);
            this.fechaDeNacimientoInput.Name = "fechaDeNacimientoInput";
            this.fechaDeNacimientoInput.Size = new System.Drawing.Size(235, 20);
            this.fechaDeNacimientoInput.TabIndex = 7;
            // 
            // dniInput
            // 
            this.dniInput.Location = new System.Drawing.Point(104, 75);
            this.dniInput.Name = "dniInput";
            this.dniInput.Size = new System.Drawing.Size(235, 20);
            this.dniInput.TabIndex = 5;
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(104, 23);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(235, 20);
            this.nombreInput.TabIndex = 3;
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
            this.apellidoInput.Location = new System.Drawing.Point(104, 49);
            this.apellidoInput.Name = "apellidoInput";
            this.apellidoInput.Size = new System.Drawing.Size(235, 20);
            this.apellidoInput.TabIndex = 4;
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
            this.telefonoInput.Location = new System.Drawing.Point(104, 153);
            this.telefonoInput.Name = "telefonoInput";
            this.telefonoInput.Size = new System.Drawing.Size(235, 20);
            this.telefonoInput.TabIndex = 8;
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
            this.mailInput.Location = new System.Drawing.Point(104, 101);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(235, 20);
            this.mailInput.TabIndex = 6;
            // 
            // resultadosGrid
            // 
            this.resultadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosGrid.Location = new System.Drawing.Point(15, 74);
            this.resultadosGrid.Name = "resultadosGrid";
            this.resultadosGrid.Size = new System.Drawing.Size(231, 321);
            this.resultadosGrid.TabIndex = 8;
            // 
            // clientesEncontradosLabel
            // 
            this.clientesEncontradosLabel.AutoSize = true;
            this.clientesEncontradosLabel.Location = new System.Drawing.Point(12, 58);
            this.clientesEncontradosLabel.Name = "clientesEncontradosLabel";
            this.clientesEncontradosLabel.Size = new System.Drawing.Size(110, 13);
            this.clientesEncontradosLabel.TabIndex = 9;
            this.clientesEncontradosLabel.Text = "Clientes Encontrados:";
            // 
            // modificacionClienteLabel
            // 
            this.modificacionClienteLabel.AutoSize = true;
            this.modificacionClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionClienteLabel.Location = new System.Drawing.Point(244, 18);
            this.modificacionClienteLabel.Name = "modificacionClienteLabel";
            this.modificacionClienteLabel.Size = new System.Drawing.Size(149, 24);
            this.modificacionClienteLabel.TabIndex = 14;
            this.modificacionClienteLabel.Text = "Modificar Cliente";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(39, 401);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 0;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(343, 407);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(97, 28);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(461, 407);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(97, 28);
            this.botonCancelar.TabIndex = 2;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Enabled = false;
            this.botonSeleccionar.Location = new System.Drawing.Point(135, 401);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(90, 30);
            this.botonSeleccionar.TabIndex = 15;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // ModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 460);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.modificacionClienteLabel);
            this.Controls.Add(this.clientesEncontradosLabel);
            this.Controls.Add(this.resultadosGrid);
            this.Controls.Add(this.datosClienteGroupBox);
            this.Name = "ModificacionCliente";
            this.Text = "Modificar Cliente";
            this.datosClienteGroupBox.ResumeLayout(false);
            this.datosClienteGroupBox.PerformLayout();
            this.domicilioGroupBox.ResumeLayout(false);
            this.domicilioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView resultadosGrid;
        private System.Windows.Forms.Label clientesEncontradosLabel;
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
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonSeleccionar;
    }
}