namespace PagoAgilFrba.Busquedas
{
    partial class BusquedaEmpresa
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
            this.buscarGroupBox = new System.Windows.Forms.GroupBox();
            this.rubroCombo = new System.Windows.Forms.ComboBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.descripcionBuscarLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.cuitInput = new System.Windows.Forms.TextBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.cuitTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.buscarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarGroupBox
            // 
            this.buscarGroupBox.Controls.Add(this.rubroCombo);
            this.buscarGroupBox.Controls.Add(this.botonVolver);
            this.buscarGroupBox.Controls.Add(this.nombreLabel);
            this.buscarGroupBox.Controls.Add(this.cuitLabel);
            this.buscarGroupBox.Controls.Add(this.rubroLabel);
            this.buscarGroupBox.Controls.Add(this.descripcionBuscarLabel);
            this.buscarGroupBox.Controls.Add(this.botonBuscar);
            this.buscarGroupBox.Controls.Add(this.cuitInput);
            this.buscarGroupBox.Controls.Add(this.nombreInput);
            this.buscarGroupBox.Location = new System.Drawing.Point(12, 12);
            this.buscarGroupBox.Name = "buscarGroupBox";
            this.buscarGroupBox.Size = new System.Drawing.Size(412, 163);
            this.buscarGroupBox.TabIndex = 6;
            this.buscarGroupBox.TabStop = false;
            this.buscarGroupBox.Text = "Busqueda de Empresa";
            // 
            // rubroCombo
            // 
            this.rubroCombo.FormattingEnabled = true;
            this.rubroCombo.Location = new System.Drawing.Point(105, 128);
            this.rubroCombo.Name = "rubroCombo";
            this.rubroCombo.Size = new System.Drawing.Size(187, 21);
            this.rubroCombo.TabIndex = 2;
            this.rubroCombo.SelectedIndexChanged += new System.EventHandler(this.rubroCombo_SelectedIndexChanged);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(322, 93);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(84, 29);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(48, 63);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 5;
            this.nombreLabel.Text = "Nombre:";
            // 
            // cuitLabel
            // 
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(48, 97);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(28, 13);
            this.cuitLabel.TabIndex = 6;
            this.cuitLabel.Text = "Cuit:";
            // 
            // rubroLabel
            // 
            this.rubroLabel.AutoSize = true;
            this.rubroLabel.Location = new System.Drawing.Point(48, 131);
            this.rubroLabel.Name = "rubroLabel";
            this.rubroLabel.Size = new System.Drawing.Size(39, 13);
            this.rubroLabel.TabIndex = 7;
            this.rubroLabel.Text = "Rubro:";
            // 
            // descripcionBuscarLabel
            // 
            this.descripcionBuscarLabel.AutoSize = true;
            this.descripcionBuscarLabel.Location = new System.Drawing.Point(21, 29);
            this.descripcionBuscarLabel.Name = "descripcionBuscarLabel";
            this.descripcionBuscarLabel.Size = new System.Drawing.Size(213, 13);
            this.descripcionBuscarLabel.TabIndex = 3;
            this.descripcionBuscarLabel.Text = "Busque filtrando con los siguientes campos:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(322, 128);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(84, 29);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // cuitInput
            // 
            this.cuitInput.Location = new System.Drawing.Point(105, 94);
            this.cuitInput.MaxLength = 13;
            this.cuitInput.Name = "cuitInput";
            this.cuitInput.Size = new System.Drawing.Size(187, 20);
            this.cuitInput.TabIndex = 1;
            this.cuitInput.Leave += new System.EventHandler(this.cuitInput_Leave);
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(105, 60);
            this.nombreInput.MaxLength = 255;
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(187, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.Leave += new System.EventHandler(this.nombreInput_Leave);
            // 
            // BusquedaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 185);
            this.Controls.Add(this.buscarGroupBox);
            this.Name = "BusquedaEmpresa";
            this.Text = "Busqueda Empresa";
            this.buscarGroupBox.ResumeLayout(false);
            this.buscarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buscarGroupBox;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label descripcionBuscarLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox cuitInput;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.ComboBox rubroCombo;
        private System.Windows.Forms.ToolTip cuitTooltip;
    }
}