namespace PagoAgilFrba.Busquedas
{
    partial class BusquedaSucursal
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
            this.busquedaSucursalGroupBox = new System.Windows.Forms.GroupBox();
            this.codigoPostalInput = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.codigoPostalLabel = new System.Windows.Forms.Label();
            this.descripcionBuscarLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.direccionInput = new System.Windows.Forms.TextBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.codigoPostalTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.busquedaSucursalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // busquedaSucursalGroupBox
            // 
            this.busquedaSucursalGroupBox.Controls.Add(this.codigoPostalInput);
            this.busquedaSucursalGroupBox.Controls.Add(this.botonVolver);
            this.busquedaSucursalGroupBox.Controls.Add(this.nombreLabel);
            this.busquedaSucursalGroupBox.Controls.Add(this.direccionLabel);
            this.busquedaSucursalGroupBox.Controls.Add(this.codigoPostalLabel);
            this.busquedaSucursalGroupBox.Controls.Add(this.descripcionBuscarLabel);
            this.busquedaSucursalGroupBox.Controls.Add(this.botonBuscar);
            this.busquedaSucursalGroupBox.Controls.Add(this.direccionInput);
            this.busquedaSucursalGroupBox.Controls.Add(this.nombreInput);
            this.busquedaSucursalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.busquedaSucursalGroupBox.Name = "busquedaSucursalGroupBox";
            this.busquedaSucursalGroupBox.Size = new System.Drawing.Size(412, 163);
            this.busquedaSucursalGroupBox.TabIndex = 7;
            this.busquedaSucursalGroupBox.TabStop = false;
            this.busquedaSucursalGroupBox.Text = "Busqueda de Sucursal";
            // 
            // codigoPostalInput
            // 
            this.codigoPostalInput.Location = new System.Drawing.Point(116, 128);
            this.codigoPostalInput.Name = "codigoPostalInput";
            this.codigoPostalInput.Size = new System.Drawing.Size(187, 20);
            this.codigoPostalInput.TabIndex = 8;
            this.codigoPostalInput.Leave += new System.EventHandler(this.codigoPostalInput_Leave);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(322, 93);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(84, 29);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(30, 63);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 5;
            this.nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(30, 97);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 6;
            this.direccionLabel.Text = "Dirección:";
            // 
            // codigoPostalLabel
            // 
            this.codigoPostalLabel.AutoSize = true;
            this.codigoPostalLabel.Location = new System.Drawing.Point(30, 131);
            this.codigoPostalLabel.Name = "codigoPostalLabel";
            this.codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            this.codigoPostalLabel.TabIndex = 7;
            this.codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // descripcionBuscarLabel
            // 
            this.descripcionBuscarLabel.AutoSize = true;
            this.descripcionBuscarLabel.Location = new System.Drawing.Point(21, 29);
            this.descripcionBuscarLabel.Name = "descripcionBuscarLabel";
            this.descripcionBuscarLabel.Size = new System.Drawing.Size(213, 13);
            this.descripcionBuscarLabel.TabIndex = 3;
            this.descripcionBuscarLabel.Text = "Busque filtrando con los siguientes campos:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(322, 128);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(84, 29);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // direccionInput
            // 
            this.direccionInput.Location = new System.Drawing.Point(116, 94);
            this.direccionInput.Name = "direccionInput";
            this.direccionInput.Size = new System.Drawing.Size(187, 20);
            this.direccionInput.TabIndex = 1;
            this.direccionInput.Leave += new System.EventHandler(this.direccionInput_Leave);
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(116, 60);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(187, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.Leave += new System.EventHandler(this.nombreInput_Leave);
            // 
            // BusquedaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 185);
            this.Controls.Add(this.busquedaSucursalGroupBox);
            this.Name = "BusquedaSucursal";
            this.Text = "Busqueda Sucursal";
            this.busquedaSucursalGroupBox.ResumeLayout(false);
            this.busquedaSucursalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox busquedaSucursalGroupBox;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label codigoPostalLabel;
        private System.Windows.Forms.Label descripcionBuscarLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox direccionInput;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.TextBox codigoPostalInput;
        private System.Windows.Forms.ToolTip codigoPostalTooltip;
    }
}