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
            this.datosEmpresaGroupBox = new System.Windows.Forms.GroupBox();
            this.diaDeRendicionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.datosEmpresaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(17, 310);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 6;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // datosEmpresaGroupBox
            // 
            this.datosEmpresaGroupBox.Controls.Add(this.diaDeRendicionText);
            this.datosEmpresaGroupBox.Controls.Add(this.label1);
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
            this.datosEmpresaGroupBox.Location = new System.Drawing.Point(12, 32);
            this.datosEmpresaGroupBox.Name = "datosEmpresaGroupBox";
            this.datosEmpresaGroupBox.Size = new System.Drawing.Size(317, 272);
            this.datosEmpresaGroupBox.TabIndex = 3;
            this.datosEmpresaGroupBox.TabStop = false;
            this.datosEmpresaGroupBox.Text = "Datos de la empresa";
            // 
            // diaDeRendicionText
            // 
            this.diaDeRendicionText.Enabled = false;
            this.diaDeRendicionText.Location = new System.Drawing.Point(107, 183);
            this.diaDeRendicionText.Name = "diaDeRendicionText";
            this.diaDeRendicionText.Size = new System.Drawing.Size(204, 20);
            this.diaDeRendicionText.TabIndex = 12;
            this.diaDeRendicionText.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dia de rendicion:";
            // 
            // deshabilitadaRadioButton
            // 
            this.deshabilitadaRadioButton.AutoSize = true;
            this.deshabilitadaRadioButton.Enabled = false;
            this.deshabilitadaRadioButton.Location = new System.Drawing.Point(202, 229);
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
            this.habilitadaRadioButton.Location = new System.Drawing.Point(87, 229);
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
            this.rubroCombo.Enabled = false;
            this.rubroCombo.FormattingEnabled = true;
            this.rubroCombo.Location = new System.Drawing.Point(107, 144);
            this.rubroCombo.Name = "rubroCombo";
            this.rubroCombo.Size = new System.Drawing.Size(204, 21);
            this.rubroCombo.TabIndex = 3;
            this.rubroCombo.Leave += new System.EventHandler(this.rubroCombo_Leave);
            // 
            // habilitacionLabel
            // 
            this.habilitacionLabel.AutoSize = true;
            this.habilitacionLabel.Location = new System.Drawing.Point(9, 231);
            this.habilitacionLabel.Name = "habilitacionLabel";
            this.habilitacionLabel.Size = new System.Drawing.Size(65, 13);
            this.habilitacionLabel.TabIndex = 5;
            this.habilitacionLabel.Text = "Habilitacion:";
            // 
            // cuitInput
            // 
            this.cuitInput.Enabled = false;
            this.cuitInput.Location = new System.Drawing.Point(107, 70);
            this.cuitInput.Name = "cuitInput";
            this.cuitInput.Size = new System.Drawing.Size(204, 20);
            this.cuitInput.TabIndex = 1;
            this.cuitInput.Leave += new System.EventHandler(this.cuitInput_Leave);
            // 
            // direccionInput
            // 
            this.direccionInput.Enabled = false;
            this.direccionInput.Location = new System.Drawing.Point(107, 107);
            this.direccionInput.Name = "direccionInput";
            this.direccionInput.Size = new System.Drawing.Size(204, 20);
            this.direccionInput.TabIndex = 2;
            this.direccionInput.Leave += new System.EventHandler(this.direccionInput_Leave);
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
            this.nombreInput.Enabled = false;
            this.nombreInput.Location = new System.Drawing.Point(107, 33);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(204, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.Leave += new System.EventHandler(this.nombreInput_Leave);
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
            this.modificacionTituloLabel.Location = new System.Drawing.Point(77, 9);
            this.modificacionTituloLabel.Name = "modificacionTituloLabel";
            this.modificacionTituloLabel.Size = new System.Drawing.Size(165, 20);
            this.modificacionTituloLabel.TabIndex = 4;
            this.modificacionTituloLabel.Text = "Modificación Empresa";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(209, 310);
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
            this.botonActualizar.Location = new System.Drawing.Point(113, 310);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(90, 30);
            this.botonActualizar.TabIndex = 7;
            this.botonActualizar.Text = "&Actualizar";
            this.botonActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // ModificacionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 378);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.modificacionTituloLabel);
            this.Controls.Add(this.datosEmpresaGroupBox);
            this.Name = "ModificacionEmpresa";
            this.Text = "Modificacion Empresa";
            this.datosEmpresaGroupBox.ResumeLayout(false);
            this.datosEmpresaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.GroupBox datosEmpresaGroupBox;
        private System.Windows.Forms.Label modificacionTituloLabel;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label habilitacionLabel;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.RadioButton deshabilitadaRadioButton;
        private System.Windows.Forms.RadioButton habilitadaRadioButton;
        private System.Windows.Forms.ComboBox rubroCombo;
        private System.Windows.Forms.TextBox cuitInput;
        private System.Windows.Forms.TextBox direccionInput;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.TextBox diaDeRendicionText;
        private System.Windows.Forms.Label label1;
    }
}