namespace PagoAgilFrba.AbmSucursal
{
    partial class BajaSucursal
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
            this.bajaSucursalLabel = new System.Windows.Forms.Label();
            this.seleccioneSucursalGroupBox = new System.Windows.Forms.GroupBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonDeshabilitar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.resultadosGrid = new System.Windows.Forms.DataGridView();
            this.seleccioneSucursalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bajaSucursalLabel
            // 
            this.bajaSucursalLabel.AutoSize = true;
            this.bajaSucursalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaSucursalLabel.Location = new System.Drawing.Point(253, 9);
            this.bajaSucursalLabel.Name = "bajaSucursalLabel";
            this.bajaSucursalLabel.Size = new System.Drawing.Size(107, 20);
            this.bajaSucursalLabel.TabIndex = 1;
            this.bajaSucursalLabel.Text = "Baja Sucursal";
            // 
            // seleccioneSucursalGroupBox
            // 
            this.seleccioneSucursalGroupBox.Controls.Add(this.botonVolver);
            this.seleccioneSucursalGroupBox.Controls.Add(this.botonDeshabilitar);
            this.seleccioneSucursalGroupBox.Controls.Add(this.botonBuscar);
            this.seleccioneSucursalGroupBox.Controls.Add(this.resultadosGrid);
            this.seleccioneSucursalGroupBox.Location = new System.Drawing.Point(12, 32);
            this.seleccioneSucursalGroupBox.Name = "seleccioneSucursalGroupBox";
            this.seleccioneSucursalGroupBox.Size = new System.Drawing.Size(595, 214);
            this.seleccioneSucursalGroupBox.TabIndex = 2;
            this.seleccioneSucursalGroupBox.TabStop = false;
            this.seleccioneSucursalGroupBox.Text = "Seleccione una sucursal";
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
            // BajaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 258);
            this.Controls.Add(this.seleccioneSucursalGroupBox);
            this.Controls.Add(this.bajaSucursalLabel);
            this.Name = "BajaSucursal";
            this.Text = "Baja Sucursal";
            this.seleccioneSucursalGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bajaSucursalLabel;
        private System.Windows.Forms.GroupBox seleccioneSucursalGroupBox;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonDeshabilitar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView resultadosGrid;
    }
}