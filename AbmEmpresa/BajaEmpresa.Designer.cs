namespace PagoAgilFrba.AbmEmpresa
{
    partial class BajaEmpresa
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
            this.seleccioneEmpresaGroupBox = new System.Windows.Forms.GroupBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.resultadosGrid = new System.Windows.Forms.DataGridView();
            this.bajaEmpresaLabel = new System.Windows.Forms.Label();
            this.botonDeshabilitar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.seleccioneEmpresaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // seleccioneEmpresaGroupBox
            // 
            this.seleccioneEmpresaGroupBox.Controls.Add(this.botonVolver);
            this.seleccioneEmpresaGroupBox.Controls.Add(this.botonDeshabilitar);
            this.seleccioneEmpresaGroupBox.Controls.Add(this.botonBuscar);
            this.seleccioneEmpresaGroupBox.Controls.Add(this.resultadosGrid);
            this.seleccioneEmpresaGroupBox.Location = new System.Drawing.Point(12, 32);
            this.seleccioneEmpresaGroupBox.Name = "seleccioneEmpresaGroupBox";
            this.seleccioneEmpresaGroupBox.Size = new System.Drawing.Size(595, 214);
            this.seleccioneEmpresaGroupBox.TabIndex = 0;
            this.seleccioneEmpresaGroupBox.TabStop = false;
            this.seleccioneEmpresaGroupBox.Text = "Seleccione una empresa";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(307, 178);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 1;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // resultadosGrid
            // 
            this.resultadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosGrid.Location = new System.Drawing.Point(6, 19);
            this.resultadosGrid.Name = "resultadosGrid";
            this.resultadosGrid.Size = new System.Drawing.Size(583, 150);
            this.resultadosGrid.TabIndex = 0;
            // 
            // bajaEmpresaLabel
            // 
            this.bajaEmpresaLabel.AutoSize = true;
            this.bajaEmpresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaEmpresaLabel.Location = new System.Drawing.Point(250, 9);
            this.bajaEmpresaLabel.Name = "bajaEmpresaLabel";
            this.bajaEmpresaLabel.Size = new System.Drawing.Size(109, 20);
            this.bajaEmpresaLabel.TabIndex = 1;
            this.bajaEmpresaLabel.Text = "Baja Empresa";
            // 
            // botonDeshabilitar
            // 
            this.botonDeshabilitar.Enabled = false;
            this.botonDeshabilitar.Location = new System.Drawing.Point(403, 178);
            this.botonDeshabilitar.Name = "botonDeshabilitar";
            this.botonDeshabilitar.Size = new System.Drawing.Size(90, 30);
            this.botonDeshabilitar.TabIndex = 2;
            this.botonDeshabilitar.Text = "Deshabilitar";
            this.botonDeshabilitar.UseVisualStyleBackColor = true;
            this.botonDeshabilitar.Click += new System.EventHandler(this.botonDeshabilitar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(499, 178);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // BajaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 258);
            this.Controls.Add(this.bajaEmpresaLabel);
            this.Controls.Add(this.seleccioneEmpresaGroupBox);
            this.Name = "BajaEmpresa";
            this.Text = "Baja Empresa";
            this.seleccioneEmpresaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox seleccioneEmpresaGroupBox;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView resultadosGrid;
        private System.Windows.Forms.Label bajaEmpresaLabel;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonDeshabilitar;
    }
}