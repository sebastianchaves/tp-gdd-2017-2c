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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionFactura));
            this.modificacionFacturaLabel = new System.Windows.Forms.Label();
            this.datosItemGroupbox = new System.Windows.Forms.GroupBox();
            this.botonAgregarConcepto = new System.Windows.Forms.Button();
            this.cantidadInput = new System.Windows.Forms.TextBox();
            this.botonEliminarConcepto = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clienteInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empresaInput = new System.Windows.Forms.TextBox();
            this.botonBuscarEmpresa = new System.Windows.Forms.Button();
            this.montoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cantidadTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datosItemGroupbox.SuspendLayout();
            this.datosFacturaGroupbox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // datosItemGroupbox
            // 
            this.datosItemGroupbox.Controls.Add(this.textBox1);
            this.datosItemGroupbox.Controls.Add(this.label3);
            this.datosItemGroupbox.Controls.Add(this.botonAgregarConcepto);
            this.datosItemGroupbox.Controls.Add(this.cantidadInput);
            this.datosItemGroupbox.Controls.Add(this.botonEliminarConcepto);
            this.datosItemGroupbox.Controls.Add(this.montoInput);
            this.datosItemGroupbox.Controls.Add(this.cantidadLabel);
            this.datosItemGroupbox.Controls.Add(this.montoLabel);
            this.datosItemGroupbox.Location = new System.Drawing.Point(12, 223);
            this.datosItemGroupbox.Name = "datosItemGroupbox";
            this.datosItemGroupbox.Size = new System.Drawing.Size(213, 168);
            this.datosItemGroupbox.TabIndex = 6;
            this.datosItemGroupbox.TabStop = false;
            this.datosItemGroupbox.Text = "Datos Items:";
            // 
            // botonAgregarConcepto
            // 
            this.botonAgregarConcepto.Enabled = false;
            this.botonAgregarConcepto.Location = new System.Drawing.Point(18, 126);
            this.botonAgregarConcepto.Name = "botonAgregarConcepto";
            this.botonAgregarConcepto.Size = new System.Drawing.Size(90, 30);
            this.botonAgregarConcepto.TabIndex = 14;
            this.botonAgregarConcepto.Text = "Agregar";
            this.botonAgregarConcepto.UseVisualStyleBackColor = true;
            this.botonAgregarConcepto.Click += new System.EventHandler(this.botonAgregarConcepto_Click);
            // 
            // cantidadInput
            // 
            this.cantidadInput.Enabled = false;
            this.cantidadInput.Location = new System.Drawing.Point(74, 58);
            this.cantidadInput.Name = "cantidadInput";
            this.cantidadInput.Size = new System.Drawing.Size(131, 20);
            this.cantidadInput.TabIndex = 3;
            this.cantidadInput.TextChanged += new System.EventHandler(this.cantidadInput_TextChanged);
            // 
            // botonEliminarConcepto
            // 
            this.botonEliminarConcepto.Enabled = false;
            this.botonEliminarConcepto.Location = new System.Drawing.Point(114, 126);
            this.botonEliminarConcepto.Name = "botonEliminarConcepto";
            this.botonEliminarConcepto.Size = new System.Drawing.Size(90, 30);
            this.botonEliminarConcepto.TabIndex = 13;
            this.botonEliminarConcepto.Text = "Eliminar";
            this.botonEliminarConcepto.UseVisualStyleBackColor = true;
            this.botonEliminarConcepto.Click += new System.EventHandler(this.botonEliminarConcepto_Click);
            // 
            // montoInput
            // 
            this.montoInput.Enabled = false;
            this.montoInput.Location = new System.Drawing.Point(74, 27);
            this.montoInput.Name = "montoInput";
            this.montoInput.Size = new System.Drawing.Size(131, 20);
            this.montoInput.TabIndex = 2;
            this.montoInput.TextChanged += new System.EventHandler(this.montoInput_TextChanged);
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(6, 61);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(52, 13);
            this.cantidadLabel.TabIndex = 1;
            this.cantidadLabel.Text = "Cantidad:";
            // 
            // montoLabel
            // 
            this.montoLabel.AutoSize = true;
            this.montoLabel.Location = new System.Drawing.Point(6, 30);
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
            this.datosFacturaGroupbox.Size = new System.Drawing.Size(363, 351);
            this.datosFacturaGroupbox.TabIndex = 7;
            this.datosFacturaGroupbox.TabStop = false;
            this.datosFacturaGroupbox.Text = "Datos Factura:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.itemsGrid);
            this.groupBox5.Location = new System.Drawing.Point(6, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 240);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Items:";
            // 
            // itemsGrid
            // 
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Location = new System.Drawing.Point(6, 19);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.Size = new System.Drawing.Size(339, 215);
            this.itemsGrid.TabIndex = 8;
            // 
            // fechaVencimientoInput
            // 
            this.fechaVencimientoInput.Enabled = false;
            this.fechaVencimientoInput.Location = new System.Drawing.Point(133, 79);
            this.fechaVencimientoInput.Name = "fechaVencimientoInput";
            this.fechaVencimientoInput.Size = new System.Drawing.Size(224, 20);
            this.fechaVencimientoInput.TabIndex = 5;
            this.fechaVencimientoInput.Leave += new System.EventHandler(this.fechaVencimientoInput_Leave);
            // 
            // fechaAltaInput
            // 
            this.fechaAltaInput.Enabled = false;
            this.fechaAltaInput.Location = new System.Drawing.Point(133, 49);
            this.fechaAltaInput.Name = "fechaAltaInput";
            this.fechaAltaInput.Size = new System.Drawing.Size(224, 20);
            this.fechaAltaInput.TabIndex = 4;
            this.fechaAltaInput.Leave += new System.EventHandler(this.fechaAltaInput_Leave);
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
            this.botonVolver.Location = new System.Drawing.Point(354, 405);
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
            this.botonActualizar.Location = new System.Drawing.Point(258, 405);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(90, 30);
            this.botonActualizar.TabIndex = 9;
            this.botonActualizar.Text = "&Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(162, 405);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 10;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clienteInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.botonBuscarCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // clienteInput
            // 
            this.clienteInput.Enabled = false;
            this.clienteInput.Location = new System.Drawing.Point(74, 18);
            this.clienteInput.Name = "clienteInput";
            this.clienteInput.ReadOnly = true;
            this.clienteInput.Size = new System.Drawing.Size(131, 20);
            this.clienteInput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente:";
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.Enabled = false;
            this.botonBuscarCliente.Location = new System.Drawing.Point(117, 44);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(90, 30);
            this.botonBuscarCliente.TabIndex = 8;
            this.botonBuscarCliente.Text = "Buscar";
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.empresaInput);
            this.groupBox2.Controls.Add(this.botonBuscarEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 86);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Empresa:";
            // 
            // empresaInput
            // 
            this.empresaInput.Enabled = false;
            this.empresaInput.Location = new System.Drawing.Point(74, 20);
            this.empresaInput.Name = "empresaInput";
            this.empresaInput.ReadOnly = true;
            this.empresaInput.Size = new System.Drawing.Size(131, 20);
            this.empresaInput.TabIndex = 7;
            // 
            // botonBuscarEmpresa
            // 
            this.botonBuscarEmpresa.Enabled = false;
            this.botonBuscarEmpresa.Location = new System.Drawing.Point(117, 46);
            this.botonBuscarEmpresa.Name = "botonBuscarEmpresa";
            this.botonBuscarEmpresa.Size = new System.Drawing.Size(90, 30);
            this.botonBuscarEmpresa.TabIndex = 7;
            this.botonBuscarEmpresa.Text = "Buscar";
            this.botonBuscarEmpresa.UseVisualStyleBackColor = true;
            this.botonBuscarEmpresa.Click += new System.EventHandler(this.botonBuscarEmpresa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(74, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripcion:";
            // 
            // ModificacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.datosItemGroupbox);
            this.Controls.Add(this.datosFacturaGroupbox);
            this.Controls.Add(this.modificacionFacturaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificacionFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Factura";
            this.datosItemGroupbox.ResumeLayout(false);
            this.datosItemGroupbox.PerformLayout();
            this.datosFacturaGroupbox.ResumeLayout(false);
            this.datosFacturaGroupbox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modificacionFacturaLabel;
        private System.Windows.Forms.GroupBox datosItemGroupbox;
        private System.Windows.Forms.GroupBox datosFacturaGroupbox;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clienteInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empresaInput;
        private System.Windows.Forms.Button botonBuscarEmpresa;
        private System.Windows.Forms.Button botonAgregarConcepto;
        private System.Windows.Forms.Button botonEliminarConcepto;
        private System.Windows.Forms.ToolTip montoTooltip;
        private System.Windows.Forms.ToolTip cantidadTooltip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}