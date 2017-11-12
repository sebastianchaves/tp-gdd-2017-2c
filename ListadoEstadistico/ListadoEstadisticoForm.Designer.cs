namespace PagoAgilFrba.ListadoEstadistico
{
    partial class ListadoEstadisticoForm
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
            this.tipoCombo = new System.Windows.Forms.ComboBox();
            this.anioNumeric = new System.Windows.Forms.NumericUpDown();
            this.trimestreCombo = new System.Windows.Forms.ComboBox();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.anioLabel = new System.Windows.Forms.Label();
            this.trimestreLabel = new System.Windows.Forms.Label();
            this.listadosEstadisticosLabel = new System.Windows.Forms.Label();
            this.confeccioneSuListadoGroupBox = new System.Windows.Forms.GroupBox();
            this.botonEjecutar = new System.Windows.Forms.Button();
            this.resultadosGrid = new System.Windows.Forms.DataGridView();
            this.botonVolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.anioNumeric)).BeginInit();
            this.confeccioneSuListadoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoCombo
            // 
            this.tipoCombo.FormattingEnabled = true;
            this.tipoCombo.Location = new System.Drawing.Point(40, 42);
            this.tipoCombo.Name = "tipoCombo";
            this.tipoCombo.Size = new System.Drawing.Size(121, 21);
            this.tipoCombo.TabIndex = 0;
            // 
            // anioNumeric
            // 
            this.anioNumeric.Location = new System.Drawing.Point(212, 42);
            this.anioNumeric.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.anioNumeric.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.anioNumeric.Name = "anioNumeric";
            this.anioNumeric.Size = new System.Drawing.Size(121, 20);
            this.anioNumeric.TabIndex = 1;
            this.anioNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anioNumeric.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // trimestreCombo
            // 
            this.trimestreCombo.FormattingEnabled = true;
            this.trimestreCombo.Location = new System.Drawing.Point(384, 42);
            this.trimestreCombo.Name = "trimestreCombo";
            this.trimestreCombo.Size = new System.Drawing.Size(121, 21);
            this.trimestreCombo.TabIndex = 2;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(37, 26);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(31, 13);
            this.tipoLabel.TabIndex = 3;
            this.tipoLabel.Text = "Tipo:";
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(209, 26);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(29, 13);
            this.anioLabel.TabIndex = 4;
            this.anioLabel.Text = "Año:";
            // 
            // trimestreLabel
            // 
            this.trimestreLabel.AutoSize = true;
            this.trimestreLabel.Location = new System.Drawing.Point(381, 26);
            this.trimestreLabel.Name = "trimestreLabel";
            this.trimestreLabel.Size = new System.Drawing.Size(53, 13);
            this.trimestreLabel.TabIndex = 5;
            this.trimestreLabel.Text = "Trimestre:";
            // 
            // listadosEstadisticosLabel
            // 
            this.listadosEstadisticosLabel.AutoSize = true;
            this.listadosEstadisticosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadosEstadisticosLabel.Location = new System.Drawing.Point(219, 9);
            this.listadosEstadisticosLabel.Name = "listadosEstadisticosLabel";
            this.listadosEstadisticosLabel.Size = new System.Drawing.Size(159, 20);
            this.listadosEstadisticosLabel.TabIndex = 6;
            this.listadosEstadisticosLabel.Text = "Listados Estadísticos";
            // 
            // confeccioneSuListadoGroupBox
            // 
            this.confeccioneSuListadoGroupBox.Controls.Add(this.botonEjecutar);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.tipoLabel);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.tipoCombo);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.trimestreLabel);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.anioNumeric);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.anioLabel);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.trimestreCombo);
            this.confeccioneSuListadoGroupBox.Location = new System.Drawing.Point(12, 32);
            this.confeccioneSuListadoGroupBox.Name = "confeccioneSuListadoGroupBox";
            this.confeccioneSuListadoGroupBox.Size = new System.Drawing.Size(537, 114);
            this.confeccioneSuListadoGroupBox.TabIndex = 7;
            this.confeccioneSuListadoGroupBox.TabStop = false;
            this.confeccioneSuListadoGroupBox.Text = "Confeccione su listado";
            // 
            // botonEjecutar
            // 
            this.botonEjecutar.Location = new System.Drawing.Point(441, 78);
            this.botonEjecutar.Name = "botonEjecutar";
            this.botonEjecutar.Size = new System.Drawing.Size(90, 30);
            this.botonEjecutar.TabIndex = 9;
            this.botonEjecutar.Text = "Ejecutar";
            this.botonEjecutar.UseVisualStyleBackColor = true;
            this.botonEjecutar.Click += new System.EventHandler(this.botonEjecutar_Click);
            // 
            // resultadosGrid
            // 
            this.resultadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosGrid.Location = new System.Drawing.Point(6, 19);
            this.resultadosGrid.Name = "resultadosGrid";
            this.resultadosGrid.Size = new System.Drawing.Size(525, 167);
            this.resultadosGrid.TabIndex = 6;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(459, 350);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 8;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultadosGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 192);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // ListadoEstadisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.confeccioneSuListadoGroupBox);
            this.Controls.Add(this.listadosEstadisticosLabel);
            this.Name = "ListadoEstadisticoForm";
            this.Text = "Listados Estadísticos";
            ((System.ComponentModel.ISupportInitialize)(this.anioNumeric)).EndInit();
            this.confeccioneSuListadoGroupBox.ResumeLayout(false);
            this.confeccioneSuListadoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipoCombo;
        private System.Windows.Forms.NumericUpDown anioNumeric;
        private System.Windows.Forms.ComboBox trimestreCombo;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.Label trimestreLabel;
        private System.Windows.Forms.Label listadosEstadisticosLabel;
        private System.Windows.Forms.GroupBox confeccioneSuListadoGroupBox;
        private System.Windows.Forms.Button botonEjecutar;
        private System.Windows.Forms.DataGridView resultadosGrid;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}