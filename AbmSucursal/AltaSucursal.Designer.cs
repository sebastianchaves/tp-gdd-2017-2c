namespace PagoAgilFrba.AbmSucursal
{
    partial class AltaSucursal
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
            this.altaSucursalLabel = new System.Windows.Forms.Label();
            this.datosSucursalGroupBox = new System.Windows.Forms.GroupBox();
            this.codigoPostalLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.direccionInput = new System.Windows.Forms.TextBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.codigoPostalInput = new System.Windows.Forms.TextBox();
            this.codigoPostalTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.datosSucursalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // altaSucursalLabel
            // 
            this.altaSucursalLabel.AutoSize = true;
            this.altaSucursalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaSucursalLabel.Location = new System.Drawing.Point(116, 9);
            this.altaSucursalLabel.Name = "altaSucursalLabel";
            this.altaSucursalLabel.Size = new System.Drawing.Size(103, 20);
            this.altaSucursalLabel.TabIndex = 0;
            this.altaSucursalLabel.Text = "Alta Sucursal";
            // 
            // datosSucursalGroupBox
            // 
            this.datosSucursalGroupBox.Controls.Add(this.codigoPostalInput);
            this.datosSucursalGroupBox.Controls.Add(this.codigoPostalLabel);
            this.datosSucursalGroupBox.Controls.Add(this.direccionLabel);
            this.datosSucursalGroupBox.Controls.Add(this.nombreLabel);
            this.datosSucursalGroupBox.Controls.Add(this.direccionInput);
            this.datosSucursalGroupBox.Controls.Add(this.nombreInput);
            this.datosSucursalGroupBox.Location = new System.Drawing.Point(12, 32);
            this.datosSucursalGroupBox.Name = "datosSucursalGroupBox";
            this.datosSucursalGroupBox.Size = new System.Drawing.Size(311, 141);
            this.datosSucursalGroupBox.TabIndex = 6;
            this.datosSucursalGroupBox.TabStop = false;
            this.datosSucursalGroupBox.Text = "Datos Sucursal";
            // 
            // codigoPostalLabel
            // 
            this.codigoPostalLabel.AutoSize = true;
            this.codigoPostalLabel.Location = new System.Drawing.Point(23, 108);
            this.codigoPostalLabel.Name = "codigoPostalLabel";
            this.codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            this.codigoPostalLabel.TabIndex = 7;
            this.codigoPostalLabel.Text = "Código Postal:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(23, 68);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 6;
            this.direccionLabel.Text = "Dirección:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(23, 28);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre:";
            // 
            // direccionInput
            // 
            this.direccionInput.Location = new System.Drawing.Point(126, 65);
            this.direccionInput.Name = "direccionInput";
            this.direccionInput.Size = new System.Drawing.Size(179, 20);
            this.direccionInput.TabIndex = 2;
            this.direccionInput.Leave += new System.EventHandler(this.direccionInput_Leave);
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(126, 25);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(179, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.Leave += new System.EventHandler(this.nombreInput_Leave);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(171, 179);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 8;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(75, 179);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(90, 30);
            this.botonAceptar.TabIndex = 7;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // codigoPostalInput
            // 
            this.codigoPostalInput.Location = new System.Drawing.Point(126, 105);
            this.codigoPostalInput.Name = "codigoPostalInput";
            this.codigoPostalInput.Size = new System.Drawing.Size(179, 20);
            this.codigoPostalInput.TabIndex = 8;
            this.codigoPostalInput.Leave += new System.EventHandler(this.codigoPostalInput_Leave);
            // 
            // AltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 219);
            this.Controls.Add(this.datosSucursalGroupBox);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.altaSucursalLabel);
            this.Name = "AltaSucursal";
            this.Text = "Alta Sucursal";
            this.datosSucursalGroupBox.ResumeLayout(false);
            this.datosSucursalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label altaSucursalLabel;
        private System.Windows.Forms.GroupBox datosSucursalGroupBox;
        private System.Windows.Forms.Label codigoPostalLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox direccionInput;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox codigoPostalInput;
        private System.Windows.Forms.ToolTip codigoPostalTooltip;
    }
}