namespace PagoAgilFrba.Busquedas
{
    partial class BusquedaFactura
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
            this.botonVolver = new System.Windows.Forms.Button();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.descripcionBuscarLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.numeroInput = new System.Windows.Forms.TextBox();
            this.numeroTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.buscarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarGroupBox
            // 
            this.buscarGroupBox.Controls.Add(this.botonVolver);
            this.buscarGroupBox.Controls.Add(this.numeroLabel);
            this.buscarGroupBox.Controls.Add(this.descripcionBuscarLabel);
            this.buscarGroupBox.Controls.Add(this.botonBuscar);
            this.buscarGroupBox.Controls.Add(this.numeroInput);
            this.buscarGroupBox.Location = new System.Drawing.Point(12, 12);
            this.buscarGroupBox.Name = "buscarGroupBox";
            this.buscarGroupBox.Size = new System.Drawing.Size(325, 126);
            this.buscarGroupBox.TabIndex = 7;
            this.buscarGroupBox.TabStop = false;
            this.buscarGroupBox.Text = "Busqueda de Factura";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(235, 91);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(84, 29);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(48, 63);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(47, 13);
            this.numeroLabel.TabIndex = 5;
            this.numeroLabel.Text = "Numero:";
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
            this.botonBuscar.Location = new System.Drawing.Point(145, 91);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(84, 29);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // numeroInput
            // 
            this.numeroInput.Location = new System.Drawing.Point(105, 60);
            this.numeroInput.MaxLength = 9;
            this.numeroInput.Name = "numeroInput";
            this.numeroInput.Size = new System.Drawing.Size(187, 20);
            this.numeroInput.TabIndex = 0;
            this.numeroInput.Leave += new System.EventHandler(this.numeroInput_Leave);
            // 
            // BusquedaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 152);
            this.Controls.Add(this.buscarGroupBox);
            this.Name = "BusquedaFactura";
            this.Text = "Busqueda Factura";
            this.buscarGroupBox.ResumeLayout(false);
            this.buscarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buscarGroupBox;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label descripcionBuscarLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox numeroInput;
        private System.Windows.Forms.ToolTip numeroTooltip;
    }
}