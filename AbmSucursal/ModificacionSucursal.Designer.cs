namespace PagoAgilFrba.AbmSucursal
{
    partial class ModificacionSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionSucursal));
            this.modificacionSucursalLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.codigoPostalLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.habilitadaRadioButtion = new System.Windows.Forms.RadioButton();
            this.deshabilitadaRadioButton = new System.Windows.Forms.RadioButton();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.direccionInput = new System.Windows.Forms.TextBox();
            this.codigoPostalInput = new System.Windows.Forms.TextBox();
            this.datosSucursalGroupbox = new System.Windows.Forms.GroupBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.datosSucursalGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificacionSucursalLabel
            // 
            this.modificacionSucursalLabel.AutoSize = true;
            this.modificacionSucursalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionSucursalLabel.Location = new System.Drawing.Point(89, 9);
            this.modificacionSucursalLabel.Name = "modificacionSucursalLabel";
            this.modificacionSucursalLabel.Size = new System.Drawing.Size(163, 20);
            this.modificacionSucursalLabel.TabIndex = 1;
            this.modificacionSucursalLabel.Text = "Modificacion Sucursal";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(29, 237);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 5;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(14, 33);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 6;
            this.nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(14, 74);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 7;
            this.direccionLabel.Text = "Dirección:";
            // 
            // codigoPostalLabel
            // 
            this.codigoPostalLabel.AutoSize = true;
            this.codigoPostalLabel.Location = new System.Drawing.Point(14, 116);
            this.codigoPostalLabel.Name = "codigoPostalLabel";
            this.codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            this.codigoPostalLabel.TabIndex = 8;
            this.codigoPostalLabel.Text = "Código Postal:";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(14, 158);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(43, 13);
            this.estadoLabel.TabIndex = 9;
            this.estadoLabel.Text = "Estado:";
            // 
            // habilitadaRadioButtion
            // 
            this.habilitadaRadioButtion.AutoSize = true;
            this.habilitadaRadioButtion.Enabled = false;
            this.habilitadaRadioButtion.Location = new System.Drawing.Point(94, 156);
            this.habilitadaRadioButtion.Name = "habilitadaRadioButtion";
            this.habilitadaRadioButtion.Size = new System.Drawing.Size(72, 17);
            this.habilitadaRadioButtion.TabIndex = 3;
            this.habilitadaRadioButtion.TabStop = true;
            this.habilitadaRadioButtion.Text = "Habilitada";
            this.habilitadaRadioButtion.UseVisualStyleBackColor = true;
            this.habilitadaRadioButtion.CheckedChanged += new System.EventHandler(this.habilitadaRadioButtion_CheckedChanged);
            // 
            // deshabilitadaRadioButton
            // 
            this.deshabilitadaRadioButton.AutoSize = true;
            this.deshabilitadaRadioButton.Enabled = false;
            this.deshabilitadaRadioButton.Location = new System.Drawing.Point(211, 156);
            this.deshabilitadaRadioButton.Name = "deshabilitadaRadioButton";
            this.deshabilitadaRadioButton.Size = new System.Drawing.Size(89, 17);
            this.deshabilitadaRadioButton.TabIndex = 4;
            this.deshabilitadaRadioButton.TabStop = true;
            this.deshabilitadaRadioButton.Text = "Deshabilitada";
            this.deshabilitadaRadioButton.UseVisualStyleBackColor = true;
            this.deshabilitadaRadioButton.CheckedChanged += new System.EventHandler(this.deshabilitadaRadioButton_CheckedChanged);
            // 
            // nombreInput
            // 
            this.nombreInput.Enabled = false;
            this.nombreInput.Location = new System.Drawing.Point(94, 30);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(206, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.Leave += new System.EventHandler(this.nombreInput_Leave);
            // 
            // direccionInput
            // 
            this.direccionInput.Enabled = false;
            this.direccionInput.Location = new System.Drawing.Point(93, 71);
            this.direccionInput.Name = "direccionInput";
            this.direccionInput.Size = new System.Drawing.Size(206, 20);
            this.direccionInput.TabIndex = 1;
            this.direccionInput.Leave += new System.EventHandler(this.direccionInput_Leave);
            // 
            // codigoPostalInput
            // 
            this.codigoPostalInput.Enabled = false;
            this.codigoPostalInput.Location = new System.Drawing.Point(94, 113);
            this.codigoPostalInput.Name = "codigoPostalInput";
            this.codigoPostalInput.Size = new System.Drawing.Size(205, 20);
            this.codigoPostalInput.TabIndex = 2;
            this.codigoPostalInput.Leave += new System.EventHandler(this.codigoPostalInput_Leave);
            // 
            // datosSucursalGroupbox
            // 
            this.datosSucursalGroupbox.Controls.Add(this.nombreLabel);
            this.datosSucursalGroupbox.Controls.Add(this.direccionLabel);
            this.datosSucursalGroupbox.Controls.Add(this.codigoPostalLabel);
            this.datosSucursalGroupbox.Controls.Add(this.codigoPostalInput);
            this.datosSucursalGroupbox.Controls.Add(this.estadoLabel);
            this.datosSucursalGroupbox.Controls.Add(this.direccionInput);
            this.datosSucursalGroupbox.Controls.Add(this.habilitadaRadioButtion);
            this.datosSucursalGroupbox.Controls.Add(this.nombreInput);
            this.datosSucursalGroupbox.Controls.Add(this.deshabilitadaRadioButton);
            this.datosSucursalGroupbox.Location = new System.Drawing.Point(12, 40);
            this.datosSucursalGroupbox.Name = "datosSucursalGroupbox";
            this.datosSucursalGroupbox.Size = new System.Drawing.Size(315, 191);
            this.datosSucursalGroupbox.TabIndex = 15;
            this.datosSucursalGroupbox.TabStop = false;
            this.datosSucursalGroupbox.Text = "Datos de la sucursal:";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(221, 237);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 7;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.Enabled = false;
            this.botonActualizar.Location = new System.Drawing.Point(125, 237);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(90, 30);
            this.botonActualizar.TabIndex = 8;
            this.botonActualizar.Text = "&Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // ModificacionSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 281);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.modificacionSucursalLabel);
            this.Controls.Add(this.datosSucursalGroupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificacionSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Sucursal";
            this.datosSucursalGroupbox.ResumeLayout(false);
            this.datosSucursalGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modificacionSucursalLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label codigoPostalLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.RadioButton habilitadaRadioButtion;
        private System.Windows.Forms.RadioButton deshabilitadaRadioButton;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.TextBox direccionInput;
        private System.Windows.Forms.TextBox codigoPostalInput;
        private System.Windows.Forms.GroupBox datosSucursalGroupbox;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonActualizar;
    }
}