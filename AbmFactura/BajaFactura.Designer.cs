namespace PagoAgilFrba.AbmFactura
{
    partial class BajaFactura
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
            this.bajaFacturaLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonBaja = new System.Windows.Forms.Button();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.numeroInput = new System.Windows.Forms.TextBox();
            this.datosFacturaGroupbox = new System.Windows.Forms.GroupBox();
            this.fechaAltaInput = new System.Windows.Forms.DateTimePicker();
            this.fechaVencimientoInput = new System.Windows.Forms.DateTimePicker();
            this.vencimientoLabel = new System.Windows.Forms.Label();
            this.fechaAltaLabel = new System.Windows.Forms.Label();
            this.datosFacturaGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bajaFacturaLabel
            // 
            this.bajaFacturaLabel.AutoSize = true;
            this.bajaFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaFacturaLabel.Location = new System.Drawing.Point(118, 9);
            this.bajaFacturaLabel.Name = "bajaFacturaLabel";
            this.bajaFacturaLabel.Size = new System.Drawing.Size(100, 20);
            this.bajaFacturaLabel.TabIndex = 1;
            this.bajaFacturaLabel.Text = "Baja Factura";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(38, 178);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 11;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(224, 179);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(84, 29);
            this.botonVolver.TabIndex = 12;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonBaja
            // 
            this.botonBaja.Enabled = false;
            this.botonBaja.Location = new System.Drawing.Point(134, 179);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(84, 29);
            this.botonBaja.TabIndex = 13;
            this.botonBaja.Text = "&Dar de Baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            this.botonBaja.Click += new System.EventHandler(this.botonBaja_Click);
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(16, 26);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(47, 13);
            this.numeroLabel.TabIndex = 15;
            this.numeroLabel.Text = "Numero:";
            // 
            // numeroInput
            // 
            this.numeroInput.Enabled = false;
            this.numeroInput.Location = new System.Drawing.Point(100, 23);
            this.numeroInput.Name = "numeroInput";
            this.numeroInput.Size = new System.Drawing.Size(199, 20);
            this.numeroInput.TabIndex = 14;
            // 
            // datosFacturaGroupbox
            // 
            this.datosFacturaGroupbox.Controls.Add(this.vencimientoLabel);
            this.datosFacturaGroupbox.Controls.Add(this.fechaAltaLabel);
            this.datosFacturaGroupbox.Controls.Add(this.fechaVencimientoInput);
            this.datosFacturaGroupbox.Controls.Add(this.fechaAltaInput);
            this.datosFacturaGroupbox.Controls.Add(this.numeroInput);
            this.datosFacturaGroupbox.Controls.Add(this.numeroLabel);
            this.datosFacturaGroupbox.Location = new System.Drawing.Point(12, 32);
            this.datosFacturaGroupbox.Name = "datosFacturaGroupbox";
            this.datosFacturaGroupbox.Size = new System.Drawing.Size(317, 141);
            this.datosFacturaGroupbox.TabIndex = 16;
            this.datosFacturaGroupbox.TabStop = false;
            this.datosFacturaGroupbox.Text = "Datos factura";
            // 
            // fechaAltaInput
            // 
            this.fechaAltaInput.Enabled = false;
            this.fechaAltaInput.Location = new System.Drawing.Point(100, 62);
            this.fechaAltaInput.Name = "fechaAltaInput";
            this.fechaAltaInput.Size = new System.Drawing.Size(199, 20);
            this.fechaAltaInput.TabIndex = 21;
            // 
            // fechaVencimientoInput
            // 
            this.fechaVencimientoInput.Enabled = false;
            this.fechaVencimientoInput.Location = new System.Drawing.Point(100, 101);
            this.fechaVencimientoInput.Name = "fechaVencimientoInput";
            this.fechaVencimientoInput.Size = new System.Drawing.Size(199, 20);
            this.fechaVencimientoInput.TabIndex = 22;
            // 
            // vencimientoLabel
            // 
            this.vencimientoLabel.AutoSize = true;
            this.vencimientoLabel.Location = new System.Drawing.Point(16, 107);
            this.vencimientoLabel.Name = "vencimientoLabel";
            this.vencimientoLabel.Size = new System.Drawing.Size(68, 13);
            this.vencimientoLabel.TabIndex = 24;
            this.vencimientoLabel.Text = "Vencimiento:";
            // 
            // fechaAltaLabel
            // 
            this.fechaAltaLabel.AutoSize = true;
            this.fechaAltaLabel.Location = new System.Drawing.Point(16, 68);
            this.fechaAltaLabel.Name = "fechaAltaLabel";
            this.fechaAltaLabel.Size = new System.Drawing.Size(75, 13);
            this.fechaAltaLabel.TabIndex = 23;
            this.fechaAltaLabel.Text = "Fecha de alta:";
            // 
            // BajaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 221);
            this.Controls.Add(this.datosFacturaGroupbox);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.bajaFacturaLabel);
            this.Name = "BajaFactura";
            this.Text = "Baja Factura";
            this.datosFacturaGroupbox.ResumeLayout(false);
            this.datosFacturaGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bajaFacturaLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.TextBox numeroInput;
        private System.Windows.Forms.GroupBox datosFacturaGroupbox;
        private System.Windows.Forms.DateTimePicker fechaVencimientoInput;
        private System.Windows.Forms.DateTimePicker fechaAltaInput;
        private System.Windows.Forms.Label vencimientoLabel;
        private System.Windows.Forms.Label fechaAltaLabel;
    }
}