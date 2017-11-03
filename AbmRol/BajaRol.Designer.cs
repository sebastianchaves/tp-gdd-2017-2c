namespace PagoAgilFrba.AbmRol
{
    partial class BajaRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaRol));
            this.bajaRolLabel = new System.Windows.Forms.Label();
            this.rolesEncontradosGrid = new System.Windows.Forms.DataGridView();
            this.rolesEncontradosGroupbox = new System.Windows.Forms.GroupBox();
            this.botonDeshabilitar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.rolSeleccionadoLabel = new System.Windows.Forms.Label();
            this.rolSeleccionadoInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolesEncontradosGrid)).BeginInit();
            this.rolesEncontradosGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bajaRolLabel
            // 
            this.bajaRolLabel.AutoSize = true;
            this.bajaRolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaRolLabel.Location = new System.Drawing.Point(138, 9);
            this.bajaRolLabel.Name = "bajaRolLabel";
            this.bajaRolLabel.Size = new System.Drawing.Size(77, 20);
            this.bajaRolLabel.TabIndex = 1;
            this.bajaRolLabel.Text = "Baja Rol";
            // 
            // rolesEncontradosGrid
            // 
            this.rolesEncontradosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesEncontradosGrid.Location = new System.Drawing.Point(13, 19);
            this.rolesEncontradosGrid.Name = "rolesEncontradosGrid";
            this.rolesEncontradosGrid.Size = new System.Drawing.Size(307, 133);
            this.rolesEncontradosGrid.TabIndex = 2;
            this.rolesEncontradosGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesEncontradosGrid_CellClick);
            // 
            // rolesEncontradosGroupbox
            // 
            this.rolesEncontradosGroupbox.Controls.Add(this.rolSeleccionadoInput);
            this.rolesEncontradosGroupbox.Controls.Add(this.rolSeleccionadoLabel);
            this.rolesEncontradosGroupbox.Controls.Add(this.botonDeshabilitar);
            this.rolesEncontradosGroupbox.Controls.Add(this.rolesEncontradosGrid);
            this.rolesEncontradosGroupbox.Location = new System.Drawing.Point(12, 32);
            this.rolesEncontradosGroupbox.Name = "rolesEncontradosGroupbox";
            this.rolesEncontradosGroupbox.Size = new System.Drawing.Size(335, 201);
            this.rolesEncontradosGroupbox.TabIndex = 5;
            this.rolesEncontradosGroupbox.TabStop = false;
            this.rolesEncontradosGroupbox.Text = "Roles encontrados:";
            // 
            // botonDeshabilitar
            // 
            this.botonDeshabilitar.Location = new System.Drawing.Point(239, 165);
            this.botonDeshabilitar.Name = "botonDeshabilitar";
            this.botonDeshabilitar.Size = new System.Drawing.Size(90, 30);
            this.botonDeshabilitar.TabIndex = 4;
            this.botonDeshabilitar.Text = "&Deshabilitar";
            this.botonDeshabilitar.UseVisualStyleBackColor = true;
            this.botonDeshabilitar.Click += new System.EventHandler(this.botonDeshabilitar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(259, 256);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 5;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // rolSeleccionadoLabel
            // 
            this.rolSeleccionadoLabel.AutoSize = true;
            this.rolSeleccionadoLabel.Location = new System.Drawing.Point(10, 174);
            this.rolSeleccionadoLabel.Name = "rolSeleccionadoLabel";
            this.rolSeleccionadoLabel.Size = new System.Drawing.Size(92, 13);
            this.rolSeleccionadoLabel.TabIndex = 5;
            this.rolSeleccionadoLabel.Text = "Rol seleccionado:";
            // 
            // rolSeleccionadoInput
            // 
            this.rolSeleccionadoInput.Location = new System.Drawing.Point(108, 171);
            this.rolSeleccionadoInput.Name = "rolSeleccionadoInput";
            this.rolSeleccionadoInput.ReadOnly = true;
            this.rolSeleccionadoInput.Size = new System.Drawing.Size(113, 20);
            this.rolSeleccionadoInput.TabIndex = 6;
            // 
            // BajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 298);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.bajaRolLabel);
            this.Controls.Add(this.rolesEncontradosGroupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BajaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Rol";
            this.Load += new System.EventHandler(this.BajaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesEncontradosGrid)).EndInit();
            this.rolesEncontradosGroupbox.ResumeLayout(false);
            this.rolesEncontradosGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bajaRolLabel;
        private System.Windows.Forms.DataGridView rolesEncontradosGrid;
        private System.Windows.Forms.GroupBox rolesEncontradosGroupbox;
        private System.Windows.Forms.Button botonDeshabilitar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TextBox rolSeleccionadoInput;
        private System.Windows.Forms.Label rolSeleccionadoLabel;
    }
}