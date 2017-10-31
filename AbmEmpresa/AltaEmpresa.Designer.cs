namespace PagoAgilFrba.AbmEmpresa
{
    partial class AltaEmpresa
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
            this.altaEmpresaLabel = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.datosEmpresaGroupBox = new System.Windows.Forms.GroupBox();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.rubroCombo = new System.Windows.Forms.ComboBox();
            this.cuitInput = new System.Windows.Forms.TextBox();
            this.direccionInput = new System.Windows.Forms.TextBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.cuitTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.datosEmpresaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // altaEmpresaLabel
            // 
            this.altaEmpresaLabel.AutoSize = true;
            this.altaEmpresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaEmpresaLabel.Location = new System.Drawing.Point(117, 9);
            this.altaEmpresaLabel.Name = "altaEmpresaLabel";
            this.altaEmpresaLabel.Size = new System.Drawing.Size(105, 20);
            this.altaEmpresaLabel.TabIndex = 0;
            this.altaEmpresaLabel.Text = "Alta Empresa";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(76, 210);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(90, 30);
            this.botonAceptar.TabIndex = 4;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(172, 210);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(90, 30);
            this.botonCancelar.TabIndex = 5;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // datosEmpresaGroupBox
            // 
            this.datosEmpresaGroupBox.Controls.Add(this.rubroLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.direccionLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.cuitLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.nombreLabel);
            this.datosEmpresaGroupBox.Controls.Add(this.rubroCombo);
            this.datosEmpresaGroupBox.Controls.Add(this.cuitInput);
            this.datosEmpresaGroupBox.Controls.Add(this.direccionInput);
            this.datosEmpresaGroupBox.Controls.Add(this.nombreInput);
            this.datosEmpresaGroupBox.Location = new System.Drawing.Point(12, 36);
            this.datosEmpresaGroupBox.Name = "datosEmpresaGroupBox";
            this.datosEmpresaGroupBox.Size = new System.Drawing.Size(311, 168);
            this.datosEmpresaGroupBox.TabIndex = 2;
            this.datosEmpresaGroupBox.TabStop = false;
            this.datosEmpresaGroupBox.Text = "Datos Empresa";
            // 
            // rubroLabel
            // 
            this.rubroLabel.AutoSize = true;
            this.rubroLabel.Location = new System.Drawing.Point(23, 133);
            this.rubroLabel.Name = "rubroLabel";
            this.rubroLabel.Size = new System.Drawing.Size(39, 13);
            this.rubroLabel.TabIndex = 7;
            this.rubroLabel.Text = "Rubro:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(23, 96);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 6;
            this.direccionLabel.Text = "Dirección:";
            // 
            // cuitLabel
            // 
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(23, 59);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(28, 13);
            this.cuitLabel.TabIndex = 5;
            this.cuitLabel.Text = "Cuit:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(23, 22);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre:";
            // 
            // rubroCombo
            // 
            this.rubroCombo.FormattingEnabled = true;
            this.rubroCombo.Location = new System.Drawing.Point(126, 130);
            this.rubroCombo.Name = "rubroCombo";
            this.rubroCombo.Size = new System.Drawing.Size(179, 21);
            this.rubroCombo.TabIndex = 3;
            this.rubroCombo.SelectedIndexChanged += new System.EventHandler(this.rubroCombo_SelectedIndexChanged);
            // 
            // cuitInput
            // 
            this.cuitInput.Location = new System.Drawing.Point(126, 56);
            this.cuitInput.Name = "cuitInput";
            this.cuitInput.Size = new System.Drawing.Size(179, 20);
            this.cuitInput.TabIndex = 1;
            this.cuitInput.Leave += new System.EventHandler(this.cuitInput_Leave_1);
            // 
            // direccionInput
            // 
            this.direccionInput.Location = new System.Drawing.Point(126, 93);
            this.direccionInput.Name = "direccionInput";
            this.direccionInput.Size = new System.Drawing.Size(179, 20);
            this.direccionInput.TabIndex = 2;
            this.direccionInput.Leave += new System.EventHandler(this.direccionInput_Leave);
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(126, 19);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(179, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.Leave += new System.EventHandler(this.nombreInput_Leave);
            // 
            // AltaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 248);
            this.Controls.Add(this.datosEmpresaGroupBox);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.altaEmpresaLabel);
            this.Name = "AltaEmpresa";
            this.Text = "Alta Empresa";
            this.datosEmpresaGroupBox.ResumeLayout(false);
            this.datosEmpresaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label altaEmpresaLabel;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.GroupBox datosEmpresaGroupBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.ComboBox rubroCombo;
        private System.Windows.Forms.TextBox cuitInput;
        private System.Windows.Forms.TextBox direccionInput;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.ToolTip cuitTooltip;
    }
}