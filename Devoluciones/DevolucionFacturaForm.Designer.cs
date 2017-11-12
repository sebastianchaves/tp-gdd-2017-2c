﻿namespace PagoAgilFrba.Devoluciones
{
    partial class DevolucionFacturaForm
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
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonDevolver = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.datosFacturaGroupbox = new System.Windows.Forms.GroupBox();
            this.motivoLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.facturaLabel = new System.Windows.Forms.Label();
            this.facturaInput = new System.Windows.Forms.TextBox();
            this.motivoInput = new System.Windows.Forms.RichTextBox();
            this.fechaInput = new System.Windows.Forms.DateTimePicker();
            this.devolucionFacturaLabel = new System.Windows.Forms.Label();
            this.datosFacturaGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(42, 287);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 0;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonDevolver
            // 
            this.botonDevolver.Enabled = false;
            this.botonDevolver.Location = new System.Drawing.Point(138, 287);
            this.botonDevolver.Name = "botonDevolver";
            this.botonDevolver.Size = new System.Drawing.Size(90, 30);
            this.botonDevolver.TabIndex = 1;
            this.botonDevolver.Text = "&Devolver";
            this.botonDevolver.UseVisualStyleBackColor = true;
            this.botonDevolver.Click += new System.EventHandler(this.botonDevolver_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(234, 287);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // datosFacturaGroupbox
            // 
            this.datosFacturaGroupbox.Controls.Add(this.motivoLabel);
            this.datosFacturaGroupbox.Controls.Add(this.fechaLabel);
            this.datosFacturaGroupbox.Controls.Add(this.facturaLabel);
            this.datosFacturaGroupbox.Controls.Add(this.facturaInput);
            this.datosFacturaGroupbox.Controls.Add(this.motivoInput);
            this.datosFacturaGroupbox.Controls.Add(this.fechaInput);
            this.datosFacturaGroupbox.Location = new System.Drawing.Point(12, 44);
            this.datosFacturaGroupbox.Name = "datosFacturaGroupbox";
            this.datosFacturaGroupbox.Size = new System.Drawing.Size(338, 237);
            this.datosFacturaGroupbox.TabIndex = 7;
            this.datosFacturaGroupbox.TabStop = false;
            this.datosFacturaGroupbox.Text = "Datos factura";
            // 
            // motivoLabel
            // 
            this.motivoLabel.AutoSize = true;
            this.motivoLabel.Location = new System.Drawing.Point(14, 94);
            this.motivoLabel.Name = "motivoLabel";
            this.motivoLabel.Size = new System.Drawing.Size(42, 13);
            this.motivoLabel.TabIndex = 13;
            this.motivoLabel.Text = "Motivo:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(14, 64);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(40, 13);
            this.fechaLabel.TabIndex = 12;
            this.fechaLabel.Text = "Fecha:";
            // 
            // facturaLabel
            // 
            this.facturaLabel.AutoSize = true;
            this.facturaLabel.Location = new System.Drawing.Point(14, 28);
            this.facturaLabel.Name = "facturaLabel";
            this.facturaLabel.Size = new System.Drawing.Size(46, 13);
            this.facturaLabel.TabIndex = 11;
            this.facturaLabel.Text = "Factura:";
            // 
            // facturaInput
            // 
            this.facturaInput.Enabled = false;
            this.facturaInput.Location = new System.Drawing.Point(88, 25);
            this.facturaInput.Name = "facturaInput";
            this.facturaInput.ReadOnly = true;
            this.facturaInput.Size = new System.Drawing.Size(237, 20);
            this.facturaInput.TabIndex = 10;
            // 
            // motivoInput
            // 
            this.motivoInput.Location = new System.Drawing.Point(88, 91);
            this.motivoInput.Name = "motivoInput";
            this.motivoInput.Size = new System.Drawing.Size(237, 140);
            this.motivoInput.TabIndex = 9;
            this.motivoInput.Text = "";
            this.motivoInput.Leave += new System.EventHandler(this.motivoInput_Leave);
            // 
            // fechaInput
            // 
            this.fechaInput.Enabled = false;
            this.fechaInput.Location = new System.Drawing.Point(88, 58);
            this.fechaInput.Name = "fechaInput";
            this.fechaInput.Size = new System.Drawing.Size(237, 20);
            this.fechaInput.TabIndex = 8;
            this.fechaInput.Leave += new System.EventHandler(this.fechaInput_Leave);
            // 
            // devolucionFacturaLabel
            // 
            this.devolucionFacturaLabel.AutoSize = true;
            this.devolucionFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devolucionFacturaLabel.Location = new System.Drawing.Point(107, 9);
            this.devolucionFacturaLabel.Name = "devolucionFacturaLabel";
            this.devolucionFacturaLabel.Size = new System.Drawing.Size(146, 20);
            this.devolucionFacturaLabel.TabIndex = 1;
            this.devolucionFacturaLabel.Text = "Devolucion Factura";
            // 
            // DevolucionFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 329);
            this.Controls.Add(this.devolucionFacturaLabel);
            this.Controls.Add(this.datosFacturaGroupbox);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonDevolver);
            this.Controls.Add(this.botonBuscar);
            this.Name = "DevolucionFacturaForm";
            this.Text = "Devolucion Factura";
            this.datosFacturaGroupbox.ResumeLayout(false);
            this.datosFacturaGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonDevolver;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox datosFacturaGroupbox;
        private System.Windows.Forms.Label devolucionFacturaLabel;
        private System.Windows.Forms.RichTextBox motivoInput;
        private System.Windows.Forms.DateTimePicker fechaInput;
        private System.Windows.Forms.Label motivoLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label facturaLabel;
        private System.Windows.Forms.TextBox facturaInput;
    }
}