namespace PagoAgilFrba.RegistroPago
{
    partial class CargaFactura
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
            this.numeroFacturaLabel = new System.Windows.Forms.Label();
            this.fechaCobroLabel = new System.Windows.Forms.Label();
            this.fechaVencimientoLabel = new System.Windows.Forms.Label();
            this.importeLabel = new System.Windows.Forms.Label();
            this.numeroInput = new System.Windows.Forms.TextBox();
            this.fechaCobroInput = new System.Windows.Forms.DateTimePicker();
            this.clienteInput = new System.Windows.Forms.TextBox();
            this.empresaInput = new System.Windows.Forms.TextBox();
            this.fechaVencimientoInput = new System.Windows.Forms.DateTimePicker();
            this.importeInput = new System.Windows.Forms.TextBox();
            this.cargaFacturaLabel = new System.Windows.Forms.Label();
            this.botonBuscarEmpresa = new System.Windows.Forms.Button();
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.buscarEmpresaGroupBox = new System.Windows.Forms.GroupBox();
            this.buscarClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.numeroTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.importeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarEmpresaGroupBox.SuspendLayout();
            this.buscarClienteGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroFacturaLabel
            // 
            this.numeroFacturaLabel.AutoSize = true;
            this.numeroFacturaLabel.Location = new System.Drawing.Point(20, 16);
            this.numeroFacturaLabel.Name = "numeroFacturaLabel";
            this.numeroFacturaLabel.Size = new System.Drawing.Size(83, 13);
            this.numeroFacturaLabel.TabIndex = 0;
            this.numeroFacturaLabel.Text = "Numero factura:";
            // 
            // fechaCobroLabel
            // 
            this.fechaCobroLabel.AutoSize = true;
            this.fechaCobroLabel.Location = new System.Drawing.Point(20, 54);
            this.fechaCobroLabel.Name = "fechaCobroLabel";
            this.fechaCobroLabel.Size = new System.Drawing.Size(85, 13);
            this.fechaCobroLabel.TabIndex = 1;
            this.fechaCobroLabel.Text = "Fecha de cobro:";
            // 
            // fechaVencimientoLabel
            // 
            this.fechaVencimientoLabel.AutoSize = true;
            this.fechaVencimientoLabel.Location = new System.Drawing.Point(20, 92);
            this.fechaVencimientoLabel.Name = "fechaVencimientoLabel";
            this.fechaVencimientoLabel.Size = new System.Drawing.Size(115, 13);
            this.fechaVencimientoLabel.TabIndex = 4;
            this.fechaVencimientoLabel.Text = "Fecha de vencimiento:";
            // 
            // importeLabel
            // 
            this.importeLabel.AutoSize = true;
            this.importeLabel.Location = new System.Drawing.Point(20, 130);
            this.importeLabel.Name = "importeLabel";
            this.importeLabel.Size = new System.Drawing.Size(84, 13);
            this.importeLabel.TabIndex = 5;
            this.importeLabel.Text = "Importe a pagar:";
            // 
            // numeroInput
            // 
            this.numeroInput.Location = new System.Drawing.Point(138, 13);
            this.numeroInput.Name = "numeroInput";
            this.numeroInput.Size = new System.Drawing.Size(214, 20);
            this.numeroInput.TabIndex = 7;
            this.numeroInput.Leave += new System.EventHandler(this.numeroInput_Leave);
            // 
            // fechaCobroInput
            // 
            this.fechaCobroInput.Enabled = false;
            this.fechaCobroInput.Location = new System.Drawing.Point(138, 47);
            this.fechaCobroInput.Name = "fechaCobroInput";
            this.fechaCobroInput.Size = new System.Drawing.Size(214, 20);
            this.fechaCobroInput.TabIndex = 8;
            // 
            // clienteInput
            // 
            this.clienteInput.Enabled = false;
            this.clienteInput.Location = new System.Drawing.Point(6, 25);
            this.clienteInput.Name = "clienteInput";
            this.clienteInput.Size = new System.Drawing.Size(227, 20);
            this.clienteInput.TabIndex = 9;
            // 
            // empresaInput
            // 
            this.empresaInput.Enabled = false;
            this.empresaInput.Location = new System.Drawing.Point(6, 25);
            this.empresaInput.Name = "empresaInput";
            this.empresaInput.Size = new System.Drawing.Size(227, 20);
            this.empresaInput.TabIndex = 10;
            // 
            // fechaVencimientoInput
            // 
            this.fechaVencimientoInput.Location = new System.Drawing.Point(138, 86);
            this.fechaVencimientoInput.Name = "fechaVencimientoInput";
            this.fechaVencimientoInput.Size = new System.Drawing.Size(214, 20);
            this.fechaVencimientoInput.TabIndex = 11;
            this.fechaVencimientoInput.Leave += new System.EventHandler(this.fechaVencimientoInput_Leave);
            // 
            // importeInput
            // 
            this.importeInput.Location = new System.Drawing.Point(138, 127);
            this.importeInput.Name = "importeInput";
            this.importeInput.Size = new System.Drawing.Size(214, 20);
            this.importeInput.TabIndex = 12;
            this.importeInput.Leave += new System.EventHandler(this.importeInput_Leave);
            // 
            // cargaFacturaLabel
            // 
            this.cargaFacturaLabel.AutoSize = true;
            this.cargaFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargaFacturaLabel.Location = new System.Drawing.Point(98, 9);
            this.cargaFacturaLabel.Name = "cargaFacturaLabel";
            this.cargaFacturaLabel.Size = new System.Drawing.Size(206, 20);
            this.cargaFacturaLabel.TabIndex = 14;
            this.cargaFacturaLabel.Text = "Carga Factura (por numero)";
            // 
            // botonBuscarEmpresa
            // 
            this.botonBuscarEmpresa.Location = new System.Drawing.Point(268, 19);
            this.botonBuscarEmpresa.Name = "botonBuscarEmpresa";
            this.botonBuscarEmpresa.Size = new System.Drawing.Size(90, 30);
            this.botonBuscarEmpresa.TabIndex = 15;
            this.botonBuscarEmpresa.Text = "Buscar";
            this.botonBuscarEmpresa.UseVisualStyleBackColor = true;
            this.botonBuscarEmpresa.Click += new System.EventHandler(this.botonBuscarEmpresa_Click);
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.Location = new System.Drawing.Point(268, 19);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(90, 30);
            this.botonBuscarCliente.TabIndex = 16;
            this.botonBuscarCliente.Text = "Buscar";
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // buscarEmpresaGroupBox
            // 
            this.buscarEmpresaGroupBox.Controls.Add(this.empresaInput);
            this.buscarEmpresaGroupBox.Controls.Add(this.botonBuscarEmpresa);
            this.buscarEmpresaGroupBox.Location = new System.Drawing.Point(12, 334);
            this.buscarEmpresaGroupBox.Name = "buscarEmpresaGroupBox";
            this.buscarEmpresaGroupBox.Size = new System.Drawing.Size(369, 56);
            this.buscarEmpresaGroupBox.TabIndex = 18;
            this.buscarEmpresaGroupBox.TabStop = false;
            this.buscarEmpresaGroupBox.Text = "Buscar empresa";
            // 
            // buscarClienteGroupBox
            // 
            this.buscarClienteGroupBox.Controls.Add(this.clienteInput);
            this.buscarClienteGroupBox.Controls.Add(this.botonBuscarCliente);
            this.buscarClienteGroupBox.Location = new System.Drawing.Point(12, 270);
            this.buscarClienteGroupBox.Name = "buscarClienteGroupBox";
            this.buscarClienteGroupBox.Size = new System.Drawing.Size(369, 58);
            this.buscarClienteGroupBox.TabIndex = 0;
            this.buscarClienteGroupBox.TabStop = false;
            this.buscarClienteGroupBox.Text = "Buscar cliente";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(61, 163);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(90, 30);
            this.botonAceptar.TabIndex = 18;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(205, 163);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(90, 30);
            this.botonCancelar.TabIndex = 19;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscar factura (por cliente y/o empresa)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numeroFacturaLabel);
            this.groupBox1.Controls.Add(this.fechaCobroLabel);
            this.groupBox1.Controls.Add(this.fechaVencimientoLabel);
            this.groupBox1.Controls.Add(this.botonCancelar);
            this.groupBox1.Controls.Add(this.importeLabel);
            this.groupBox1.Controls.Add(this.botonAceptar);
            this.groupBox1.Controls.Add(this.numeroInput);
            this.groupBox1.Controls.Add(this.fechaCobroInput);
            this.groupBox1.Controls.Add(this.fechaVencimientoInput);
            this.groupBox1.Controls.Add(this.importeInput);
            this.groupBox1.Location = new System.Drawing.Point(18, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 199);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de factura";
            // 
            // CargaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscarClienteGroupBox);
            this.Controls.Add(this.buscarEmpresaGroupBox);
            this.Controls.Add(this.cargaFacturaLabel);
            this.Name = "CargaFactura";
            this.Text = "Carga Factura";
            this.buscarEmpresaGroupBox.ResumeLayout(false);
            this.buscarEmpresaGroupBox.PerformLayout();
            this.buscarClienteGroupBox.ResumeLayout(false);
            this.buscarClienteGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numeroFacturaLabel;
        private System.Windows.Forms.Label fechaCobroLabel;
        private System.Windows.Forms.Label fechaVencimientoLabel;
        private System.Windows.Forms.Label importeLabel;
        private System.Windows.Forms.TextBox numeroInput;
        private System.Windows.Forms.DateTimePicker fechaCobroInput;
        private System.Windows.Forms.TextBox clienteInput;
        private System.Windows.Forms.TextBox empresaInput;
        private System.Windows.Forms.DateTimePicker fechaVencimientoInput;
        private System.Windows.Forms.TextBox importeInput;
        private System.Windows.Forms.Label cargaFacturaLabel;
        private System.Windows.Forms.Button botonBuscarEmpresa;
        private System.Windows.Forms.Button botonBuscarCliente;
        private System.Windows.Forms.GroupBox buscarEmpresaGroupBox;
        private System.Windows.Forms.GroupBox buscarClienteGroupBox;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ToolTip numeroTooltip;
        private System.Windows.Forms.ToolTip importeTooltip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}