namespace PagoAgilFrba.RegistroPago
{
    partial class RegistroPagoForm
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
            this.botonEliminar = new System.Windows.Forms.Button();
            this.formasPagoCombo = new System.Windows.Forms.ComboBox();
            this.formaPagoLabel = new System.Windows.Forms.Label();
            this.botonCargarFactura = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.buscarClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.clienteInput = new System.Windows.Forms.TextBox();
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.sucursalInput = new System.Windows.Forms.TextBox();
            this.sucursalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturasGrid)).BeginInit();
            this.agregeFacturasGroupBox.SuspendLayout();
            this.buscarClienteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registroPagoLabel
            // 
            this.registroPagoLabel.AutoSize = true;
            this.registroPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroPagoLabel.Location = new System.Drawing.Point(205, 9);
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
            this.facturasGrid.Size = new System.Drawing.Size(616, 132);
            this.facturasGrid.TabIndex = 1;
            // 
            // agregeFacturasGroupBox
            // 
            this.agregeFacturasGroupBox.Controls.Add(this.botonEliminar);
            this.agregeFacturasGroupBox.Controls.Add(this.formasPagoCombo);
            this.agregeFacturasGroupBox.Controls.Add(this.facturasGrid);
            this.agregeFacturasGroupBox.Controls.Add(this.formaPagoLabel);
            this.agregeFacturasGroupBox.Controls.Add(this.botonCargarFactura);
            this.agregeFacturasGroupBox.Location = new System.Drawing.Point(12, 32);
            this.agregeFacturasGroupBox.Name = "agregeFacturasGroupBox";
            this.agregeFacturasGroupBox.Size = new System.Drawing.Size(628, 196);
            this.agregeFacturasGroupBox.TabIndex = 2;
            this.agregeFacturasGroupBox.TabStop = false;
            this.agregeFacturasGroupBox.Text = "Agregue facturas a registrar";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(532, 157);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(90, 30);
            this.botonEliminar.TabIndex = 1;
            this.botonEliminar.Text = "&Eliminar Factura";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // formasPagoCombo
            // 
            this.formasPagoCombo.FormattingEnabled = true;
            this.formasPagoCombo.Location = new System.Drawing.Point(93, 163);
            this.formasPagoCombo.Name = "formasPagoCombo";
            this.formasPagoCombo.Size = new System.Drawing.Size(121, 21);
            this.formasPagoCombo.TabIndex = 3;
            // 
            // formaPagoLabel
            // 
            this.formaPagoLabel.AutoSize = true;
            this.formaPagoLabel.Location = new System.Drawing.Point(6, 166);
            this.formaPagoLabel.Name = "formaPagoLabel";
            this.formaPagoLabel.Size = new System.Drawing.Size(81, 13);
            this.formaPagoLabel.TabIndex = 4;
            this.formaPagoLabel.Text = "Forma de pago:";
            // 
            // botonCargarFactura
            // 
            this.botonCargarFactura.Location = new System.Drawing.Point(436, 157);
            this.botonCargarFactura.Name = "botonCargarFactura";
            this.botonCargarFactura.Size = new System.Drawing.Size(90, 30);
            this.botonCargarFactura.TabIndex = 0;
            this.botonCargarFactura.Text = "&Cargar Factura";
            this.botonCargarFactura.UseVisualStyleBackColor = true;
            this.botonCargarFactura.Click += new System.EventHandler(this.botonCargarFactura_Click);
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(454, 268);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(90, 30);
            this.botonRegistrar.TabIndex = 2;
            this.botonRegistrar.Text = "&Registrar Pago";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(550, 268);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // buscarClienteGroupBox
            // 
            this.buscarClienteGroupBox.Controls.Add(this.clienteInput);
            this.buscarClienteGroupBox.Controls.Add(this.botonBuscarCliente);
            this.buscarClienteGroupBox.Location = new System.Drawing.Point(12, 234);
            this.buscarClienteGroupBox.Name = "buscarClienteGroupBox";
            this.buscarClienteGroupBox.Size = new System.Drawing.Size(346, 58);
            this.buscarClienteGroupBox.TabIndex = 5;
            this.buscarClienteGroupBox.TabStop = false;
            this.buscarClienteGroupBox.Text = "Buscar cliente";
            // 
            // clienteInput
            // 
            this.clienteInput.Enabled = false;
            this.clienteInput.Location = new System.Drawing.Point(6, 25);
            this.clienteInput.Name = "clienteInput";
            this.clienteInput.Size = new System.Drawing.Size(227, 20);
            this.clienteInput.TabIndex = 9;
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.Location = new System.Drawing.Point(239, 19);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(90, 30);
            this.botonBuscarCliente.TabIndex = 16;
            this.botonBuscarCliente.Text = "&Buscar";
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // sucursalInput
            // 
            this.sucursalInput.Enabled = false;
            this.sucursalInput.Location = new System.Drawing.Point(420, 234);
            this.sucursalInput.Name = "sucursalInput";
            this.sucursalInput.Size = new System.Drawing.Size(214, 20);
            this.sucursalInput.TabIndex = 21;
            // 
            // sucursalLabel
            // 
            this.sucursalLabel.AutoSize = true;
            this.sucursalLabel.Location = new System.Drawing.Point(363, 237);
            this.sucursalLabel.Name = "sucursalLabel";
            this.sucursalLabel.Size = new System.Drawing.Size(51, 13);
            this.sucursalLabel.TabIndex = 22;
            this.sucursalLabel.Text = "Sucursal:";
            // 
            // RegistroPagoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 310);
            this.Controls.Add(this.sucursalInput);
            this.Controls.Add(this.sucursalLabel);
            this.Controls.Add(this.buscarClienteGroupBox);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.agregeFacturasGroupBox);
            this.Controls.Add(this.registroPagoLabel);
            this.Name = "RegistroPagoForm";
            this.Text = "Registro de Pago de Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.facturasGrid)).EndInit();
            this.agregeFacturasGroupBox.ResumeLayout(false);
            this.agregeFacturasGroupBox.PerformLayout();
            this.buscarClienteGroupBox.ResumeLayout(false);
            this.buscarClienteGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label formaPagoLabel;
        private System.Windows.Forms.ComboBox formasPagoCombo;
        private System.Windows.Forms.GroupBox buscarClienteGroupBox;
        private System.Windows.Forms.TextBox clienteInput;
        private System.Windows.Forms.Button botonBuscarCliente;
        private System.Windows.Forms.TextBox sucursalInput;
        private System.Windows.Forms.Label sucursalLabel;
    }
}