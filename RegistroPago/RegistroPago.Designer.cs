namespace PagoAgilFrba.RegistroPago
{
    partial class RegistroPago
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
            this.registroPagoLabel = new System.Windows.Forms.Label();
            this.facturasGrid = new System.Windows.Forms.DataGridView();
            this.agregeFacturasGroupBox = new System.Windows.Forms.GroupBox();
            this.botonCargarFactura = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facturasGrid)).BeginInit();
            this.agregeFacturasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registroPagoLabel
            // 
            this.registroPagoLabel.AutoSize = true;
            this.registroPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroPagoLabel.Location = new System.Drawing.Point(149, 9);
            this.registroPagoLabel.Name = "registroPagoLabel";
            this.registroPagoLabel.Size = new System.Drawing.Size(221, 20);
            this.registroPagoLabel.TabIndex = 0;
            this.registroPagoLabel.Text = "Registro de Pago de Facturas";
            // 
            // facturasGrid
            // 
            this.facturasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasGrid.Location = new System.Drawing.Point(6, 19);
            this.facturasGrid.Name = "facturasGrid";
            this.facturasGrid.Size = new System.Drawing.Size(507, 223);
            this.facturasGrid.TabIndex = 1;
            // 
            // agregeFacturasGroupBox
            // 
            this.agregeFacturasGroupBox.Controls.Add(this.botonRegistrar);
            this.agregeFacturasGroupBox.Controls.Add(this.botonEliminar);
            this.agregeFacturasGroupBox.Controls.Add(this.facturasGrid);
            this.agregeFacturasGroupBox.Controls.Add(this.botonCargarFactura);
            this.agregeFacturasGroupBox.Location = new System.Drawing.Point(12, 32);
            this.agregeFacturasGroupBox.Name = "agregeFacturasGroupBox";
            this.agregeFacturasGroupBox.Size = new System.Drawing.Size(519, 284);
            this.agregeFacturasGroupBox.TabIndex = 2;
            this.agregeFacturasGroupBox.TabStop = false;
            this.agregeFacturasGroupBox.Text = "Agregue facturas a registrar";
            // 
            // botonCargarFactura
            // 
            this.botonCargarFactura.Location = new System.Drawing.Point(6, 248);
            this.botonCargarFactura.Name = "botonCargarFactura";
            this.botonCargarFactura.Size = new System.Drawing.Size(90, 30);
            this.botonCargarFactura.TabIndex = 0;
            this.botonCargarFactura.Text = "Cargar Factura";
            this.botonCargarFactura.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(102, 248);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(90, 30);
            this.botonEliminar.TabIndex = 1;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(441, 322);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(423, 248);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(90, 30);
            this.botonRegistrar.TabIndex = 2;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            // 
            // RegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 364);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.agregeFacturasGroupBox);
            this.Controls.Add(this.registroPagoLabel);
            this.Name = "RegistroPago";
            this.Text = "Registro de Pago de Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.facturasGrid)).EndInit();
            this.agregeFacturasGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registroPagoLabel;
        private System.Windows.Forms.DataGridView facturasGrid;
        private System.Windows.Forms.GroupBox agregeFacturasGroupBox;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonCargarFactura;
        private System.Windows.Forms.Button botonVolver;
    }
}