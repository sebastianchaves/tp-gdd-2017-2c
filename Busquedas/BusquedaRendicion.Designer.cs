namespace PagoAgilFrba.Busquedas
{
    partial class BusquedaRendicion
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
            this.busquedaRendicionGroupBox = new System.Windows.Forms.GroupBox();
            this.empresasCombo = new System.Windows.Forms.ComboBox();
            this.anioInput = new System.Windows.Forms.NumericUpDown();
            this.mesInput = new System.Windows.Forms.NumericUpDown();
            this.botonVolver = new System.Windows.Forms.Button();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.mesLabel = new System.Windows.Forms.Label();
            this.anioLabel = new System.Windows.Forms.Label();
            this.descripcionBuscarLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.busquedaRendicionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesInput)).BeginInit();
            this.SuspendLayout();
            // 
            // busquedaRendicionGroupBox
            // 
            this.busquedaRendicionGroupBox.Controls.Add(this.empresasCombo);
            this.busquedaRendicionGroupBox.Controls.Add(this.anioInput);
            this.busquedaRendicionGroupBox.Controls.Add(this.mesInput);
            this.busquedaRendicionGroupBox.Controls.Add(this.botonVolver);
            this.busquedaRendicionGroupBox.Controls.Add(this.empresaLabel);
            this.busquedaRendicionGroupBox.Controls.Add(this.mesLabel);
            this.busquedaRendicionGroupBox.Controls.Add(this.anioLabel);
            this.busquedaRendicionGroupBox.Controls.Add(this.descripcionBuscarLabel);
            this.busquedaRendicionGroupBox.Controls.Add(this.botonBuscar);
            this.busquedaRendicionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.busquedaRendicionGroupBox.Name = "busquedaRendicionGroupBox";
            this.busquedaRendicionGroupBox.Size = new System.Drawing.Size(412, 163);
            this.busquedaRendicionGroupBox.TabIndex = 8;
            this.busquedaRendicionGroupBox.TabStop = false;
            this.busquedaRendicionGroupBox.Text = "Busqueda de Rendicion";
            // 
            // empresasCombo
            // 
            this.empresasCombo.FormattingEnabled = true;
            this.empresasCombo.Location = new System.Drawing.Point(116, 60);
            this.empresasCombo.Name = "empresasCombo";
            this.empresasCombo.Size = new System.Drawing.Size(187, 21);
            this.empresasCombo.TabIndex = 11;
            this.empresasCombo.SelectedIndexChanged += new System.EventHandler(this.empresasCombo_SelectedIndexChanged);
            // 
            // anioInput
            // 
            this.anioInput.Location = new System.Drawing.Point(116, 128);
            this.anioInput.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.anioInput.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.anioInput.Name = "anioInput";
            this.anioInput.Size = new System.Drawing.Size(187, 20);
            this.anioInput.TabIndex = 10;
            this.anioInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anioInput.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.anioInput.Leave += new System.EventHandler(this.anioInput_Leave);
            // 
            // mesInput
            // 
            this.mesInput.Location = new System.Drawing.Point(116, 95);
            this.mesInput.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mesInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mesInput.Name = "mesInput";
            this.mesInput.Size = new System.Drawing.Size(187, 20);
            this.mesInput.TabIndex = 9;
            this.mesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mesInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mesInput.Leave += new System.EventHandler(this.mesInput_Leave);
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
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(30, 63);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(51, 13);
            this.empresaLabel.TabIndex = 5;
            this.empresaLabel.Text = "Empresa:";
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Location = new System.Drawing.Point(30, 97);
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(30, 13);
            this.mesLabel.TabIndex = 6;
            this.mesLabel.Text = "Mes:";
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(30, 131);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(29, 13);
            this.anioLabel.TabIndex = 7;
            this.anioLabel.Text = "Año:";
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
            // BusquedaRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 189);
            this.Controls.Add(this.busquedaRendicionGroupBox);
            this.Name = "BusquedaRendicion";
            this.Text = "Busqueda Rendicion";
            this.busquedaRendicionGroupBox.ResumeLayout(false);
            this.busquedaRendicionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox busquedaRendicionGroupBox;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Label descripcionBuscarLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label mesLabel;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.NumericUpDown anioInput;
        private System.Windows.Forms.NumericUpDown mesInput;
        private System.Windows.Forms.ComboBox empresasCombo;
    }
}