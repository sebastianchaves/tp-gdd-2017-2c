namespace PagoAgilFrba.AbmFactura
{
    partial class ModificacionFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionFactura));
            this.modificacionFacturaLabel = new System.Windows.Forms.Label();
            this.datosClienteGroupbox = new System.Windows.Forms.GroupBox();
            this.clienteInput = new System.Windows.Forms.TextBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.datosEmpresaGroupbox = new System.Windows.Forms.GroupBox();
            this.empresaInput = new System.Windows.Forms.TextBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.datosItemGroupbox = new System.Windows.Forms.GroupBox();
            this.cantidadInput = new System.Windows.Forms.TextBox();
            this.montoInput = new System.Windows.Forms.TextBox();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.montoLabel = new System.Windows.Forms.Label();
            this.datosFacturaGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.fechaVencimientoInput = new System.Windows.Forms.DateTimePicker();
            this.fechaAltaInput = new System.Windows.Forms.DateTimePicker();
            this.numeroInput = new System.Windows.Forms.TextBox();
            this.fechaVencimientoLabel = new System.Windows.Forms.Label();
            this.fechaAltaLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.datosClienteGroupbox.SuspendLayout();
            this.datosEmpresaGroupbox.SuspendLayout();
            this.datosItemGroupbox.SuspendLayout();
            this.datosFacturaGroupbox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // modificacionFacturaLabel
            // 
            this.modificacionFacturaLabel.AutoSize = true;
            this.modificacionFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionFacturaLabel.Location = new System.Drawing.Point(216, 9);
            this.modificacionFacturaLabel.Name = "modificacionFacturaLabel";
            this.modificacionFacturaLabel.Size = new System.Drawing.Size(156, 20);
            this.modificacionFacturaLabel.TabIndex = 1;
            this.modificacionFacturaLabel.Text = "Modificacion Factura";
            // 
            // datosClienteGroupbox
            // 
            this.datosClienteGroupbox.Controls.Add(this.clienteInput);
            this.datosClienteGroupbox.Controls.Add(this.clienteLabel);
            this.datosClienteGroupbox.Location = new System.Drawing.Point(12, 40);
            this.datosClienteGroupbox.Name = "datosClienteGroupbox";
            this.datosClienteGroupbox.Size = new System.Drawing.Size(213, 100);
            this.datosClienteGroupbox.TabIndex = 4;
            this.datosClienteGroupbox.TabStop = false;
            this.datosClienteGroupbox.Text = "Datos Cliente:";
            // 
            // clienteInput
            // 
            this.clienteInput.Location = new System.Drawing.Point(10, 55);
            this.clienteInput.Name = "clienteInput";
            this.clienteInput.ReadOnly = true;
            this.clienteInput.Size = new System.Drawing.Size(197, 20);
            this.clienteInput.TabIndex = 1;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(7, 29);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(42, 13);
            this.clienteLabel.TabIndex = 0;
            this.clienteLabel.Text = "Cliente:";
            // 
            // datosEmpresaGroupbox
            // 
            this.datosEmpresaGroupbox.Controls.Add(this.empresaInput);
            this.datosEmpresaGroupbox.Controls.Add(this.empresaLabel);
            this.datosEmpresaGroupbox.Location = new System.Drawing.Point(12, 146);
            this.datosEmpresaGroupbox.Name = "datosEmpresaGroupbox";
            this.datosEmpresaGroupbox.Size = new System.Drawing.Size(211, 100);
            this.datosEmpresaGroupbox.TabIndex = 5;
            this.datosEmpresaGroupbox.TabStop = false;
            this.datosEmpresaGroupbox.Text = "Datos Empresa:";
            // 
            // empresaInput
            // 
            this.empresaInput.Location = new System.Drawing.Point(8, 57);
            this.empresaInput.Name = "empresaInput";
            this.empresaInput.ReadOnly = true;
            this.empresaInput.Size = new System.Drawing.Size(197, 20);
            this.empresaInput.TabIndex = 2;
            // 
            // empresaLabel
            // 
            this.empresaLabel.Location = new System.Drawing.Point(10, 31);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(100, 23);
            this.empresaLabel.TabIndex = 0;
            this.empresaLabel.Text = "Empresa:";
            // 
            // datosItemGroupbox
            // 
            this.datosItemGroupbox.Controls.Add(this.cantidadInput);
            this.datosItemGroupbox.Controls.Add(this.montoInput);
            this.datosItemGroupbox.Controls.Add(this.cantidadLabel);
            this.datosItemGroupbox.Controls.Add(this.montoLabel);
            this.datosItemGroupbox.Location = new System.Drawing.Point(12, 252);
            this.datosItemGroupbox.Name = "datosItemGroupbox";
            this.datosItemGroupbox.Size = new System.Drawing.Size(213, 100);
            this.datosItemGroupbox.TabIndex = 6;
            this.datosItemGroupbox.TabStop = false;
            this.datosItemGroupbox.Text = "Datos Items:";
            // 
            // cantidadInput
            // 
            this.cantidadInput.Location = new System.Drawing.Point(67, 65);
            this.cantidadInput.Name = "cantidadInput";
            this.cantidadInput.ReadOnly = true;
            this.cantidadInput.Size = new System.Drawing.Size(138, 20);
            this.cantidadInput.TabIndex = 3;
            // 
            // montoInput
            // 
            this.montoInput.Location = new System.Drawing.Point(67, 27);
            this.montoInput.Name = "montoInput";
            this.montoInput.ReadOnly = true;
            this.montoInput.Size = new System.Drawing.Size(138, 20);
            this.montoInput.TabIndex = 2;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(10, 68);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(52, 13);
            this.cantidadLabel.TabIndex = 1;
            this.cantidadLabel.Text = "Cantidad:";
            // 
            // montoLabel
            // 
            this.montoLabel.AutoSize = true;
            this.montoLabel.Location = new System.Drawing.Point(10, 30);
            this.montoLabel.Name = "montoLabel";
            this.montoLabel.Size = new System.Drawing.Size(40, 13);
            this.montoLabel.TabIndex = 0;
            this.montoLabel.Text = "Monto:";
            // 
            // datosFacturaGroupbox
            // 
            this.datosFacturaGroupbox.Controls.Add(this.groupBox5);
            this.datosFacturaGroupbox.Controls.Add(this.fechaVencimientoInput);
            this.datosFacturaGroupbox.Controls.Add(this.fechaAltaInput);
            this.datosFacturaGroupbox.Controls.Add(this.numeroInput);
            this.datosFacturaGroupbox.Controls.Add(this.fechaVencimientoLabel);
            this.datosFacturaGroupbox.Controls.Add(this.fechaAltaLabel);
            this.datosFacturaGroupbox.Controls.Add(this.numeroLabel);
            this.datosFacturaGroupbox.Location = new System.Drawing.Point(231, 40);
            this.datosFacturaGroupbox.Name = "datosFacturaGroupbox";
            this.datosFacturaGroupbox.Size = new System.Drawing.Size(363, 312);
            this.datosFacturaGroupbox.TabIndex = 7;
            this.datosFacturaGroupbox.TabStop = false;
            this.datosFacturaGroupbox.Text = "Datos Factura:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.itemsGrid);
            this.groupBox5.Location = new System.Drawing.Point(6, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 199);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Items:";
            // 
            // itemsGrid
            // 
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Location = new System.Drawing.Point(6, 19);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.Size = new System.Drawing.Size(339, 174);
            this.itemsGrid.TabIndex = 8;
            // 
            // fechaVencimientoInput
            // 
            this.fechaVencimientoInput.Location = new System.Drawing.Point(133, 79);
            this.fechaVencimientoInput.Name = "fechaVencimientoInput";
            this.fechaVencimientoInput.Size = new System.Drawing.Size(224, 20);
            this.fechaVencimientoInput.TabIndex = 5;
            // 
            // fechaAltaInput
            // 
            this.fechaAltaInput.Location = new System.Drawing.Point(133, 49);
            this.fechaAltaInput.Name = "fechaAltaInput";
            this.fechaAltaInput.Size = new System.Drawing.Size(224, 20);
            this.fechaAltaInput.TabIndex = 4;
            // 
            // numeroInput
            // 
            this.numeroInput.Location = new System.Drawing.Point(133, 22);
            this.numeroInput.Name = "numeroInput";
            this.numeroInput.ReadOnly = true;
            this.numeroInput.Size = new System.Drawing.Size(224, 20);
            this.numeroInput.TabIndex = 3;
            // 
            // fechaVencimientoLabel
            // 
            this.fechaVencimientoLabel.AutoSize = true;
            this.fechaVencimientoLabel.Location = new System.Drawing.Point(11, 85);
            this.fechaVencimientoLabel.Name = "fechaVencimientoLabel";
            this.fechaVencimientoLabel.Size = new System.Drawing.Size(115, 13);
            this.fechaVencimientoLabel.TabIndex = 2;
            this.fechaVencimientoLabel.Text = "Fecha de vencimiento:";
            // 
            // fechaAltaLabel
            // 
            this.fechaAltaLabel.AutoSize = true;
            this.fechaAltaLabel.Location = new System.Drawing.Point(51, 55);
            this.fechaAltaLabel.Name = "fechaAltaLabel";
            this.fechaAltaLabel.Size = new System.Drawing.Size(75, 13);
            this.fechaAltaLabel.TabIndex = 1;
            this.fechaAltaLabel.Text = "Fecha de alta:";
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(79, 25);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(47, 13);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "Número:";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(352, 358);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 8;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.Enabled = false;
            this.botonActualizar.Location = new System.Drawing.Point(256, 358);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(90, 30);
            this.botonActualizar.TabIndex = 9;
            this.botonActualizar.Text = "&Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(160, 358);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 10;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // ModificacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 397);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.datosItemGroupbox);
            this.Controls.Add(this.datosFacturaGroupbox);
            this.Controls.Add(this.datosEmpresaGroupbox);
            this.Controls.Add(this.datosClienteGroupbox);
            this.Controls.Add(this.modificacionFacturaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificacionFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Factura";
            this.datosClienteGroupbox.ResumeLayout(false);
            this.datosClienteGroupbox.PerformLayout();
            this.datosEmpresaGroupbox.ResumeLayout(false);
            this.datosEmpresaGroupbox.PerformLayout();
            this.datosItemGroupbox.ResumeLayout(false);
            this.datosItemGroupbox.PerformLayout();
            this.datosFacturaGroupbox.ResumeLayout(false);
            this.datosFacturaGroupbox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modificacionFacturaLabel;
        private System.Windows.Forms.GroupBox datosClienteGroupbox;
        private System.Windows.Forms.GroupBox datosEmpresaGroupbox;
        private System.Windows.Forms.GroupBox datosItemGroupbox;
        private System.Windows.Forms.GroupBox datosFacturaGroupbox;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.TextBox clienteInput;
        private System.Windows.Forms.TextBox empresaInput;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.TextBox cantidadInput;
        private System.Windows.Forms.TextBox montoInput;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.Label fechaVencimientoLabel;
        private System.Windows.Forms.Label fechaAltaLabel;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.DateTimePicker fechaVencimientoInput;
        private System.Windows.Forms.DateTimePicker fechaAltaInput;
        private System.Windows.Forms.TextBox numeroInput;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView itemsGrid;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Button botonBuscar;
    }
}