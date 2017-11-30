namespace PagoAgilFrba.AbmRol
{
    partial class AltaRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaRol));
            this.altaRolLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.funcionalidadesCheckbox = new System.Windows.Forms.CheckedListBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.funcionalidadesLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // altaRolLabel
            // 
            this.altaRolLabel.AutoSize = true;
            this.altaRolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaRolLabel.Location = new System.Drawing.Point(143, 9);
            this.altaRolLabel.Name = "altaRolLabel";
            this.altaRolLabel.Size = new System.Drawing.Size(73, 20);
            this.altaRolLabel.TabIndex = 0;
            this.altaRolLabel.Text = "Alta Rol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.funcionalidadesCheckbox);
            this.groupBox1.Controls.Add(this.nombreInput);
            this.groupBox1.Controls.Add(this.botonCancelar);
            this.groupBox1.Controls.Add(this.botonAceptar);
            this.groupBox1.Controls.Add(this.funcionalidadesLabel);
            this.groupBox1.Controls.Add(this.nombreLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // funcionalidadesCheckbox
            // 
            this.funcionalidadesCheckbox.FormattingEnabled = true;
            this.funcionalidadesCheckbox.Items.AddRange(new object[] {
            "Alta usuario",
            "Alta empresa",
            "Alta cliente",
            "Alta factura",
            "Alta rol",
            "Baja usuario",
            "Baja empresa",
            "Baja cliente",
            "Baja Factura",
            "Baja rol",
            "Modificar usuario",
            "Modificar empresa",
            "Modificar cliente",
            "Modifica factura",
            "Modificar rol",
            "Emitir estadísticas"});
            this.funcionalidadesCheckbox.Location = new System.Drawing.Point(113, 59);
            this.funcionalidadesCheckbox.Name = "funcionalidadesCheckbox";
            this.funcionalidadesCheckbox.Size = new System.Drawing.Size(213, 154);
            this.funcionalidadesCheckbox.TabIndex = 6;
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(113, 22);
            this.nombreInput.MaxLength = 255;
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(213, 20);
            this.nombreInput.TabIndex = 0;
            this.nombreInput.Leave += new System.EventHandler(this.nombreInput_Leave);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(175, 235);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(90, 30);
            this.botonCancelar.TabIndex = 5;
            this.botonCancelar.Text = "&Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(79, 235);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(90, 30);
            this.botonAceptar.TabIndex = 4;
            this.botonAceptar.Text = "&Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // funcionalidadesLabel
            // 
            this.funcionalidadesLabel.AutoSize = true;
            this.funcionalidadesLabel.Location = new System.Drawing.Point(6, 59);
            this.funcionalidadesLabel.Name = "funcionalidadesLabel";
            this.funcionalidadesLabel.Size = new System.Drawing.Size(87, 13);
            this.funcionalidadesLabel.TabIndex = 1;
            this.funcionalidadesLabel.Text = "Funcionalidades:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(6, 25);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre:";
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.altaRolLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label altaRolLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label funcionalidadesLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.CheckedListBox funcionalidadesCheckbox;
    }
}