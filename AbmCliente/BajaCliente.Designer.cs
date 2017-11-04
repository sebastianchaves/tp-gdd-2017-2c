namespace PagoAgilFrba.AbmCliente
{
    partial class BajaCliente
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
            this.botonDeshabilitar = new System.Windows.Forms.Button();
            this.datosClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.direccionInput = new System.Windows.Forms.TextBox();
            this.domicilioLabel = new System.Windows.Forms.Label();
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
            this.bajaClienteLabel = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.fechaNacimientoInput = new System.Windows.Forms.DateTimePicker();
            this.datosClienteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonDeshabilitar
            // 
            this.botonDeshabilitar.Enabled = false;
            this.botonDeshabilitar.Location = new System.Drawing.Point(142, 258);
            this.botonDeshabilitar.Name = "botonDeshabilitar";
            this.botonDeshabilitar.Size = new System.Drawing.Size(90, 30);
            this.botonDeshabilitar.TabIndex = 1;
            this.botonDeshabilitar.Text = "Deshabilitar";
            this.botonDeshabilitar.UseVisualStyleBackColor = true;
            this.botonDeshabilitar.Click += new System.EventHandler(this.botonDeshabilitar_Click);
            // 
            // datosClienteGroupBox
            // 
            this.datosClienteGroupBox.Controls.Add(this.fechaNacimientoInput);
            this.datosClienteGroupBox.Controls.Add(this.direccionInput);
            this.datosClienteGroupBox.Controls.Add(this.domicilioLabel);
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
            this.datosClienteGroupBox.Size = new System.Drawing.Size(353, 217);
            this.datosClienteGroupBox.TabIndex = 12;
            this.datosClienteGroupBox.TabStop = false;
            this.datosClienteGroupBox.Text = "Datos Cliente";
            // 
            // direccionInput
            // 
            this.direccionInput.Location = new System.Drawing.Point(104, 179);
            this.direccionInput.Name = "direccionInput";
            this.direccionInput.ReadOnly = true;
            this.direccionInput.Size = new System.Drawing.Size(235, 20);
            this.direccionInput.TabIndex = 60;
            // 
            // domicilioLabel
            // 
            this.domicilioLabel.AutoSize = true;
            this.domicilioLabel.Location = new System.Drawing.Point(18, 182);
            this.domicilioLabel.Name = "domicilioLabel";
            this.domicilioLabel.Size = new System.Drawing.Size(55, 13);
            this.domicilioLabel.TabIndex = 59;
            this.domicilioLabel.Text = "Direccion:";
            // 
            // dniInput
            // 
            this.dniInput.Location = new System.Drawing.Point(104, 75);
            this.dniInput.Name = "dniInput";
            this.dniInput.ReadOnly = true;
            this.dniInput.Size = new System.Drawing.Size(235, 20);
            this.dniInput.TabIndex = 37;
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(104, 23);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.ReadOnly = true;
            this.nombreInput.Size = new System.Drawing.Size(235, 20);
            this.nombreInput.TabIndex = 31;
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
            this.apellidoInput.ReadOnly = true;
            this.apellidoInput.Size = new System.Drawing.Size(235, 20);
            this.apellidoInput.TabIndex = 35;
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
            this.telefonoInput.ReadOnly = true;
            this.telefonoInput.Size = new System.Drawing.Size(235, 20);
            this.telefonoInput.TabIndex = 32;
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
            this.mailInput.ReadOnly = true;
            this.mailInput.Size = new System.Drawing.Size(235, 20);
            this.mailInput.TabIndex = 36;
            // 
            // bajaClienteLabel
            // 
            this.bajaClienteLabel.AutoSize = true;
            this.bajaClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaClienteLabel.Location = new System.Drawing.Point(137, 9);
            this.bajaClienteLabel.Name = "bajaClienteLabel";
            this.bajaClienteLabel.Size = new System.Drawing.Size(109, 24);
            this.bajaClienteLabel.TabIndex = 13;
            this.bajaClienteLabel.Text = "Baja Cliente";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(252, 258);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 14;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(32, 258);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 15;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // fechaNacimientoInput
            // 
            this.fechaNacimientoInput.Enabled = false;
            this.fechaNacimientoInput.Location = new System.Drawing.Point(104, 127);
            this.fechaNacimientoInput.Name = "fechaNacimientoInput";
            this.fechaNacimientoInput.Size = new System.Drawing.Size(235, 20);
            this.fechaNacimientoInput.TabIndex = 62;
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 304);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.bajaClienteLabel);
            this.Controls.Add(this.datosClienteGroupBox);
            this.Controls.Add(this.botonDeshabilitar);
            this.Name = "BajaCliente";
            this.Text = "Deshabilitar Cliente";
            this.datosClienteGroupBox.ResumeLayout(false);
            this.datosClienteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeshabilitar;
        private System.Windows.Forms.GroupBox datosClienteGroupBox;
        private System.Windows.Forms.TextBox direccionInput;
        private System.Windows.Forms.Label domicilioLabel;
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
        private System.Windows.Forms.Label bajaClienteLabel;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DateTimePicker fechaNacimientoInput;
    }
}