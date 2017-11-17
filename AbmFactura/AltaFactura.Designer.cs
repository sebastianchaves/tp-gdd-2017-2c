﻿namespace PagoAgilFrba.AbmFactura
{
    partial class AltaFactura
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
            this.altaFacturaLabel = new System.Windows.Forms.Label();
            this.datosEmpresaGroupBox = new System.Windows.Forms.GroupBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.empresaInput = new System.Windows.Forms.TextBox();
            this.botonBuscarEmpresa = new System.Windows.Forms.Button();
            this.datosFacturaGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsAgregadosLabel = new System.Windows.Forms.Label();
            this.conceptosGrid = new System.Windows.Forms.DataGridView();
            this.numeroInput = new System.Windows.Forms.TextBox();
            this.fechaVencimientoLabel = new System.Windows.Forms.Label();
            this.fechaAltaLabel = new System.Windows.Forms.Label();
            this.fechaVencimientoInput = new System.Windows.Forms.DateTimePicker();
            this.fechaAltaInput = new System.Windows.Forms.DateTimePicker();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.datosClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.clienteInput = new System.Windows.Forms.TextBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.datosConceptoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcionInput = new System.Windows.Forms.TextBox();
            this.botonAgregarConcepto = new System.Windows.Forms.Button();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.cantidadInput = new System.Windows.Forms.TextBox();
            this.montoLabel = new System.Windows.Forms.Label();
            this.montoInput = new System.Windows.Forms.TextBox();
            this.botonEliminarConcepto = new System.Windows.Forms.Button();
            this.montoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cantidadTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.numeroTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.datosEmpresaGroupBox.SuspendLayout();
            this.datosFacturaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosGrid)).BeginInit();
            this.datosClienteGroupBox.SuspendLayout();
            this.datosConceptoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // altaFacturaLabel
            // 
            this.altaFacturaLabel.AutoSize = true;
            this.altaFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaFacturaLabel.Location = new System.Drawing.Point(245, 9);
            this.altaFacturaLabel.Name = "altaFacturaLabel";
            this.altaFacturaLabel.Size = new System.Drawing.Size(96, 20);
            this.altaFacturaLabel.TabIndex = 1;
            this.altaFacturaLabel.Text = "Alta Factura";
            // 
            // datosEmpresaGroupBox
            // 
            this.datosEmpresaGroupBox.Controls.Add(this.empresaLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.empresaInput);
            this.datosEmpresaGroupBox.Controls.Add(this.botonBuscarEmpresa);
            this.datosEmpresaGroupBox.Location = new System.Drawing.Point(12, 119);
            this.datosEmpresaGroupBox.Name = "datosEmpresaGroupBox";
            this.datosEmpresaGroupBox.Size = new System.Drawing.Size(231, 81);
            this.datosEmpresaGroupBox.TabIndex = 2;
            this.datosEmpresaGroupBox.TabStop = false;
            this.datosEmpresaGroupBox.Text = "Datos Empresa";
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(15, 23);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(51, 13);
            this.empresaLabel.TabIndex = 9;
            this.empresaLabel.Text = "Empresa:";
            // 
            // empresaInput
            // 
            this.empresaInput.Enabled = false;
            this.empresaInput.Location = new System.Drawing.Point(74, 20);
            this.empresaInput.Name = "empresaInput";
            this.empresaInput.ReadOnly = true;
            this.empresaInput.Size = new System.Drawing.Size(151, 20);
            this.empresaInput.TabIndex = 7;
            // 
            // botonBuscarEmpresa
            // 
            this.botonBuscarEmpresa.Location = new System.Drawing.Point(135, 44);
            this.botonBuscarEmpresa.Name = "botonBuscarEmpresa";
            this.botonBuscarEmpresa.Size = new System.Drawing.Size(90, 30);
            this.botonBuscarEmpresa.TabIndex = 7;
            this.botonBuscarEmpresa.Text = "Buscar";
            this.botonBuscarEmpresa.UseVisualStyleBackColor = true;
            this.botonBuscarEmpresa.Click += new System.EventHandler(this.botonBuscarEmpresa_Click);
            // 
            // datosFacturaGroupBox
            // 
            this.datosFacturaGroupBox.Controls.Add(this.itemsAgregadosLabel);
            this.datosFacturaGroupBox.Controls.Add(this.conceptosGrid);
            this.datosFacturaGroupBox.Controls.Add(this.numeroInput);
            this.datosFacturaGroupBox.Controls.Add(this.fechaVencimientoLabel);
            this.datosFacturaGroupBox.Controls.Add(this.fechaAltaLabel);
            this.datosFacturaGroupBox.Controls.Add(this.fechaVencimientoInput);
            this.datosFacturaGroupBox.Controls.Add(this.fechaAltaInput);
            this.datosFacturaGroupBox.Controls.Add(this.numeroLabel);
            this.datosFacturaGroupBox.Location = new System.Drawing.Point(249, 32);
            this.datosFacturaGroupBox.Name = "datosFacturaGroupBox";
            this.datosFacturaGroupBox.Size = new System.Drawing.Size(359, 323);
            this.datosFacturaGroupBox.TabIndex = 0;
            this.datosFacturaGroupBox.TabStop = false;
            this.datosFacturaGroupBox.Text = "Datos Factura";
            // 
            // itemsAgregadosLabel
            // 
            this.itemsAgregadosLabel.AutoSize = true;
            this.itemsAgregadosLabel.Location = new System.Drawing.Point(10, 122);
            this.itemsAgregadosLabel.Name = "itemsAgregadosLabel";
            this.itemsAgregadosLabel.Size = new System.Drawing.Size(88, 13);
            this.itemsAgregadosLabel.TabIndex = 10;
            this.itemsAgregadosLabel.Text = "Items agregados:";
            // 
            // conceptosGrid
            // 
            this.conceptosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conceptosGrid.Location = new System.Drawing.Point(13, 138);
            this.conceptosGrid.Name = "conceptosGrid";
            this.conceptosGrid.Size = new System.Drawing.Size(334, 179);
            this.conceptosGrid.TabIndex = 9;
            // 
            // numeroInput
            // 
            this.numeroInput.Location = new System.Drawing.Point(136, 18);
            this.numeroInput.Name = "numeroInput";
            this.numeroInput.Size = new System.Drawing.Size(211, 20);
            this.numeroInput.TabIndex = 8;
            this.numeroInput.Leave += new System.EventHandler(this.numeroInput_Leave);
            // 
            // fechaVencimientoLabel
            // 
            this.fechaVencimientoLabel.AutoSize = true;
            this.fechaVencimientoLabel.Location = new System.Drawing.Point(15, 92);
            this.fechaVencimientoLabel.Name = "fechaVencimientoLabel";
            this.fechaVencimientoLabel.Size = new System.Drawing.Size(115, 13);
            this.fechaVencimientoLabel.TabIndex = 7;
            this.fechaVencimientoLabel.Text = "Fecha de vencimiento:";
            // 
            // fechaAltaLabel
            // 
            this.fechaAltaLabel.AutoSize = true;
            this.fechaAltaLabel.Location = new System.Drawing.Point(15, 59);
            this.fechaAltaLabel.Name = "fechaAltaLabel";
            this.fechaAltaLabel.Size = new System.Drawing.Size(75, 13);
            this.fechaAltaLabel.TabIndex = 6;
            this.fechaAltaLabel.Text = "Fecha de alta:";
            // 
            // fechaVencimientoInput
            // 
            this.fechaVencimientoInput.Location = new System.Drawing.Point(136, 85);
            this.fechaVencimientoInput.Name = "fechaVencimientoInput";
            this.fechaVencimientoInput.Size = new System.Drawing.Size(211, 20);
            this.fechaVencimientoInput.TabIndex = 5;
            this.fechaVencimientoInput.Leave += new System.EventHandler(this.fechaVencimientoInput_Leave);
            // 
            // fechaAltaInput
            // 
            this.fechaAltaInput.Location = new System.Drawing.Point(136, 52);
            this.fechaAltaInput.Name = "fechaAltaInput";
            this.fechaAltaInput.Size = new System.Drawing.Size(211, 20);
            this.fechaAltaInput.TabIndex = 4;
            this.fechaAltaInput.Leave += new System.EventHandler(this.fechaAltaInput_Leave);
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(15, 25);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(47, 13);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "Número:";
            // 
            // datosClienteGroupBox
            // 
            this.datosClienteGroupBox.Controls.Add(this.clienteInput);
            this.datosClienteGroupBox.Controls.Add(this.clienteLabel);
            this.datosClienteGroupBox.Controls.Add(this.botonBuscarCliente);
            this.datosClienteGroupBox.Location = new System.Drawing.Point(12, 32);
            this.datosClienteGroupBox.Name = "datosClienteGroupBox";
            this.datosClienteGroupBox.Size = new System.Drawing.Size(231, 81);
            this.datosClienteGroupBox.TabIndex = 0;
            this.datosClienteGroupBox.TabStop = false;
            this.datosClienteGroupBox.Text = "Datos Cliente";
            // 
            // clienteInput
            // 
            this.clienteInput.Enabled = false;
            this.clienteInput.Location = new System.Drawing.Point(74, 18);
            this.clienteInput.Name = "clienteInput";
            this.clienteInput.ReadOnly = true;
            this.clienteInput.Size = new System.Drawing.Size(151, 20);
            this.clienteInput.TabIndex = 8;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(15, 21);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(42, 13);
            this.clienteLabel.TabIndex = 8;
            this.clienteLabel.Text = "Cliente:";
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.Location = new System.Drawing.Point(135, 44);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(90, 30);
            this.botonBuscarCliente.TabIndex = 8;
            this.botonBuscarCliente.Text = "Buscar";
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(334, 361);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(90, 30);
            this.botonAceptar.TabIndex = 5;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(430, 361);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 6;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // datosConceptoGroupBox
            // 
            this.datosConceptoGroupBox.Controls.Add(this.label1);
            this.datosConceptoGroupBox.Controls.Add(this.descripcionInput);
            this.datosConceptoGroupBox.Controls.Add(this.botonAgregarConcepto);
            this.datosConceptoGroupBox.Controls.Add(this.cantidadLabel);
            this.datosConceptoGroupBox.Controls.Add(this.cantidadInput);
            this.datosConceptoGroupBox.Controls.Add(this.montoLabel);
            this.datosConceptoGroupBox.Controls.Add(this.montoInput);
            this.datosConceptoGroupBox.Controls.Add(this.botonEliminarConcepto);
            this.datosConceptoGroupBox.Location = new System.Drawing.Point(12, 206);
            this.datosConceptoGroupBox.Name = "datosConceptoGroupBox";
            this.datosConceptoGroupBox.Size = new System.Drawing.Size(231, 149);
            this.datosConceptoGroupBox.TabIndex = 10;
            this.datosConceptoGroupBox.TabStop = false;
            this.datosConceptoGroupBox.Text = "Datos Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Descripcion:";
            // 
            // descripcionInput
            // 
            this.descripcionInput.Location = new System.Drawing.Point(74, 72);
            this.descripcionInput.Name = "descripcionInput";
            this.descripcionInput.Size = new System.Drawing.Size(151, 20);
            this.descripcionInput.TabIndex = 13;
            this.descripcionInput.TextChanged += new System.EventHandler(this.descripcionInput_TextChanged);
            // 
            // botonAgregarConcepto
            // 
            this.botonAgregarConcepto.Location = new System.Drawing.Point(28, 113);
            this.botonAgregarConcepto.Name = "botonAgregarConcepto";
            this.botonAgregarConcepto.Size = new System.Drawing.Size(90, 30);
            this.botonAgregarConcepto.TabIndex = 12;
            this.botonAgregarConcepto.Text = "Agregar";
            this.botonAgregarConcepto.UseVisualStyleBackColor = true;
            this.botonAgregarConcepto.Click += new System.EventHandler(this.botonAgregarConcepto_Click);
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(6, 49);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(52, 13);
            this.cantidadLabel.TabIndex = 11;
            this.cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadInput
            // 
            this.cantidadInput.Location = new System.Drawing.Point(74, 46);
            this.cantidadInput.Name = "cantidadInput";
            this.cantidadInput.Size = new System.Drawing.Size(151, 20);
            this.cantidadInput.TabIndex = 10;
            this.cantidadInput.TextChanged += new System.EventHandler(this.cantidadInput_TextChanged);
            // 
            // montoLabel
            // 
            this.montoLabel.AutoSize = true;
            this.montoLabel.Location = new System.Drawing.Point(6, 22);
            this.montoLabel.Name = "montoLabel";
            this.montoLabel.Size = new System.Drawing.Size(40, 13);
            this.montoLabel.TabIndex = 9;
            this.montoLabel.Text = "Monto:";
            // 
            // montoInput
            // 
            this.montoInput.Location = new System.Drawing.Point(74, 19);
            this.montoInput.Name = "montoInput";
            this.montoInput.Size = new System.Drawing.Size(151, 20);
            this.montoInput.TabIndex = 7;
            this.montoInput.TextChanged += new System.EventHandler(this.montoInput_TextChanged);
            // 
            // botonEliminarConcepto
            // 
            this.botonEliminarConcepto.Location = new System.Drawing.Point(124, 113);
            this.botonEliminarConcepto.Name = "botonEliminarConcepto";
            this.botonEliminarConcepto.Size = new System.Drawing.Size(90, 30);
            this.botonEliminarConcepto.TabIndex = 7;
            this.botonEliminarConcepto.Text = "Eliminar";
            this.botonEliminarConcepto.UseVisualStyleBackColor = true;
            this.botonEliminarConcepto.Click += new System.EventHandler(this.botonEliminarConcepto_Click);
            // 
            // AltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 403);
            this.Controls.Add(this.datosConceptoGroupBox);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.datosEmpresaGroupBox);
            this.Controls.Add(this.datosClienteGroupBox);
            this.Controls.Add(this.datosFacturaGroupBox);
            this.Controls.Add(this.altaFacturaLabel);
            this.Name = "AltaFactura";
            this.Text = "Alta Factura";
            this.datosEmpresaGroupBox.ResumeLayout(false);
            this.datosEmpresaGroupBox.PerformLayout();
            this.datosFacturaGroupBox.ResumeLayout(false);
            this.datosFacturaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosGrid)).EndInit();
            this.datosClienteGroupBox.ResumeLayout(false);
            this.datosClienteGroupBox.PerformLayout();
            this.datosConceptoGroupBox.ResumeLayout(false);
            this.datosConceptoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label altaFacturaLabel;
        private System.Windows.Forms.GroupBox datosEmpresaGroupBox;
        private System.Windows.Forms.GroupBox datosFacturaGroupBox;
        private System.Windows.Forms.GroupBox datosClienteGroupBox;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.TextBox empresaInput;
        private System.Windows.Forms.Button botonBuscarEmpresa;
        private System.Windows.Forms.TextBox clienteInput;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Button botonBuscarCliente;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.TextBox numeroInput;
        private System.Windows.Forms.Label fechaVencimientoLabel;
        private System.Windows.Forms.Label fechaAltaLabel;
        private System.Windows.Forms.DateTimePicker fechaVencimientoInput;
        private System.Windows.Forms.DateTimePicker fechaAltaInput;
        private System.Windows.Forms.DataGridView conceptosGrid;
        private System.Windows.Forms.Label itemsAgregadosLabel;
        private System.Windows.Forms.GroupBox datosConceptoGroupBox;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.TextBox montoInput;
        private System.Windows.Forms.Button botonEliminarConcepto;
        private System.Windows.Forms.TextBox cantidadInput;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Button botonAgregarConcepto;
        private System.Windows.Forms.ToolTip montoTooltip;
        private System.Windows.Forms.ToolTip cantidadTooltip;
        private System.Windows.Forms.ToolTip numeroTooltip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcionInput;
    }
}