namespace PagoAgilFrba.AbmEmpresa
{
    partial class ModificacionEmpresa
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
            this.resultadosGrid = new System.Windows.Forms.DataGridView();
            this.empresasEncontradasGroupBox = new System.Windows.Forms.GroupBox();
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.datosEmpresaGroupBox = new System.Windows.Forms.GroupBox();
            this.deshabilitadaRadioButton = new System.Windows.Forms.RadioButton();
            this.habilitadaRadioButton = new System.Windows.Forms.RadioButton();
            this.rubroCombo = new System.Windows.Forms.ComboBox();
            this.habilitacionLabel = new System.Windows.Forms.Label();
            this.cuitInput = new System.Windows.Forms.TextBox();
            this.direccionInput = new System.Windows.Forms.TextBox();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.modificacionTituloLabel = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).BeginInit();
            this.empresasEncontradasGroupBox.SuspendLayout();
            this.datosEmpresaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(41, 242);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 6;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // resultadosGrid
            // 
            this.resultadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosGrid.Location = new System.Drawing.Point(6, 19);
            this.resultadosGrid.Name = "resultadosGrid";
            this.resultadosGrid.Size = new System.Drawing.Size(261, 216);
            this.resultadosGrid.TabIndex = 1;
            // 
            // empresasEncontradasGroupBox
            // 
            this.empresasEncontradasGroupBox.Controls.Add(this.botonSeleccionar);
            this.empresasEncontradasGroupBox.Controls.Add(this.resultadosGrid);
            this.empresasEncontradasGroupBox.Controls.Add(this.botonBuscar);
            this.empresasEncontradasGroupBox.Location = new System.Drawing.Point(13, 36);
            this.empresasEncontradasGroupBox.Name = "empresasEncontradasGroupBox";
            this.empresasEncontradasGroupBox.Size = new System.Drawing.Size(273, 278);
            this.empresasEncontradasGroupBox.TabIndex = 2;
            this.empresasEncontradasGroupBox.TabStop = false;
            this.empresasEncontradasGroupBox.Text = "Seleccione una empresa";
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Enabled = false;
            this.botonSeleccionar.Location = new System.Drawing.Point(137, 241);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(90, 30);
            this.botonSeleccionar.TabIndex = 9;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // datosEmpresaGroupBox
            // 
            this.datosEmpresaGroupBox.Controls.Add(this.deshabilitadaRadioButton);
            this.datosEmpresaGroupBox.Controls.Add(this.habilitadaRadioButton);
            this.datosEmpresaGroupBox.Controls.Add(this.rubroCombo);
            this.datosEmpresaGroupBox.Controls.Add(this.habilitacionLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.cuitInput);
            this.datosEmpresaGroupBox.Controls.Add(this.direccionInput);
            this.datosEmpresaGroupBox.Controls.Add(this.rubroLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.nombreInput);
            this.datosEmpresaGroupBox.Controls.Add(this.nombreLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.direccionLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.cuitLabel);
            this.datosEmpresaGroupBox.Location = new System.Drawing.Point(292, 36);
            this.datosEmpresaGroupBox.Name = "datosEmpresaGroupBox";
            this.datosEmpresaGroupBox.Size = new System.Drawing.Size(273, 235);
            this.datosEmpresaGroupBox.TabIndex = 3;
            this.datosEmpresaGroupBox.TabStop = false;
            this.datosEmpresaGroupBox.Text = "Datos de la empresa";
            // 
            // deshabilitadaRadioButton
            // 
            this.deshabilitadaRadioButton.AutoSize = true;
            this.deshabilitadaRadioButton.Enabled = false;
            this.deshabilitadaRadioButton.Location = new System.Drawing.Point(178, 188);
            this.deshabilitadaRadioButton.Name = "deshabilitadaRadioButton";
            this.deshabilitadaRadioButton.Size = new System.Drawing.Size(89, 17);
            this.deshabilitadaRadioButton.TabIndex = 5;
            this.deshabilitadaRadioButton.TabStop = true;
            this.deshabilitadaRadioButton.Text = "Deshabilitada";
            this.deshabilitadaRadioButton.UseVisualStyleBackColor = true;
            this.deshabilitadaRadioButton.CheckedChanged += new System.EventHandler(this.deshabilitadaRadioButton_CheckedChanged);
            // 
            // habilitadaRadioButton
            // 
            this.habilitadaRadioButton.AutoSize = true;
            this.habilitadaRadioButton.Enabled = false;
            this.habilitadaRadioButton.Location = new System.Drawing.Point(87, 188);
            this.habilitadaRadioButton.Name = "habilitadaRadioButton";
            this.habilitadaRadioButton.Size = new System.Drawing.Size(72, 17);
            this.habilitadaRadioButton.TabIndex = 4;
            this.habilitadaRadioButton.TabStop = true;
            this.habilitadaRadioButton.Text = "Habilitada";
            this.habilitadaRadioButton.UseVisualStyleBackColor = true;
            this.habilitadaRadioButton.CheckedChanged += new System.EventHandler(this.habilitadaRadioButton_CheckedChanged);
            // 
            // rubroCombo
            // 
            this.rubroCombo.FormattingEnabled = true;
            this.rubroCombo.Location = new System.Drawing.Point(87, 144);
            this.rubroCombo.Name = "rubroCombo";
            this.rubroCombo.Size = new System.Drawing.Size(180, 21);
            this.rubroCombo.TabIndex = 3;
            // 
            // habilitacionLabel
            // 
            this.habilitacionLabel.AutoSize = true;
            this.habilitacionLabel.Location = new System.Drawing.Point(9, 190);
            this.habilitacionLabel.Name = "habilitacionLabel";
            this.habilitacionLabel.Size = new System.Drawing.Size(65, 13);
            this.habilitacionLabel.TabIndex = 5;
            this.habilitacionLabel.Text = "Habilitacion:";
            // 
            // cuitInput
            // 
            this.cuitInput.Location = new System.Drawing.Point(87, 70);
            this.cuitInput.Name = "cuitInput";
            this.cuitInput.Size = new System.Drawing.Size(180, 20);
            this.cuitInput.TabIndex = 1;
            // 
            // direccionInput
            // 
            this.direccionInput.Location = new System.Drawing.Point(87, 107);
            this.direccionInput.Name = "direccionInput";
            this.direccionInput.Size = new System.Drawing.Size(180, 20);
            this.direccionInput.TabIndex = 2;
            // 
            // rubroLabel
            // 
            this.rubroLabel.AutoSize = true;
            this.rubroLabel.Location = new System.Drawing.Point(9, 147);
            this.rubroLabel.Name = "rubroLabel";
            this.rubroLabel.Size = new System.Drawing.Size(39, 13);
            this.rubroLabel.TabIndex = 11;
            this.rubroLabel.Text = "Rubro:";
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(87, 33);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(180, 20);
            this.nombreInput.TabIndex = 0;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(9, 36);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 8;
            this.nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(9, 110);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 10;
            this.direccionLabel.Text = "Dirección:";
            // 
            // cuitLabel
            // 
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(9, 73);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(28, 13);
            this.cuitLabel.TabIndex = 9;
            this.cuitLabel.Text = "Cuit:";
            // 
            // modificacionTituloLabel
            // 
            this.modificacionTituloLabel.AutoSize = true;
            this.modificacionTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionTituloLabel.Location = new System.Drawing.Point(205, 9);
            this.modificacionTituloLabel.Name = "modificacionTituloLabel";
            this.modificacionTituloLabel.Size = new System.Drawing.Size(165, 20);
            this.modificacionTituloLabel.TabIndex = 4;
            this.modificacionTituloLabel.Text = "Modificación Empresa";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(444, 277);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(90, 30);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(348, 277);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(90, 30);
            this.botonAceptar.TabIndex = 7;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // ModificacionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 325);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.modificacionTituloLabel);
            this.Controls.Add(this.datosEmpresaGroupBox);
            this.Controls.Add(this.empresasEncontradasGroupBox);
            this.Name = "ModificacionEmpresa";
            this.Text = "Modificacion Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).EndInit();
            this.empresasEncontradasGroupBox.ResumeLayout(false);
            this.datosEmpresaGroupBox.ResumeLayout(false);
            this.datosEmpresaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView resultadosGrid;
        private System.Windows.Forms.GroupBox empresasEncontradasGroupBox;
        private System.Windows.Forms.GroupBox datosEmpresaGroupBox;
        private System.Windows.Forms.Label modificacionTituloLabel;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label habilitacionLabel;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.RadioButton deshabilitadaRadioButton;
        private System.Windows.Forms.RadioButton habilitadaRadioButton;
        private System.Windows.Forms.ComboBox rubroCombo;
        private System.Windows.Forms.TextBox cuitInput;
        private System.Windows.Forms.TextBox direccionInput;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Button botonSeleccionar;
    }
}