namespace PagoAgilFrba
{
    partial class FrmSeleccionRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionRol));
            this.rolImage = new System.Windows.Forms.PictureBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.rolesLabel = new System.Windows.Forms.Label();
            this.seleccionRolLabel = new System.Windows.Forms.Label();
            this.rolesCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rolImage
            // 
            this.rolImage.Image = ((System.Drawing.Image)(resources.GetObject("rolImage.Image")));
            this.rolImage.Location = new System.Drawing.Point(35, 36);
            this.rolImage.Name = "rolImage";
            this.rolImage.Size = new System.Drawing.Size(131, 129);
            this.rolImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rolImage.TabIndex = 0;
            this.rolImage.TabStop = false;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(260, 116);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(90, 30);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "&Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // rolesLabel
            // 
            this.rolesLabel.AutoSize = true;
            this.rolesLabel.Location = new System.Drawing.Point(189, 72);
            this.rolesLabel.Name = "rolesLabel";
            this.rolesLabel.Size = new System.Drawing.Size(77, 13);
            this.rolesLabel.TabIndex = 3;
            this.rolesLabel.Text = "Seleccione rol:";
            // 
            // seleccionRolLabel
            // 
            this.seleccionRolLabel.AutoSize = true;
            this.seleccionRolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionRolLabel.Location = new System.Drawing.Point(235, 26);
            this.seleccionRolLabel.Name = "seleccionRolLabel";
            this.seleccionRolLabel.Size = new System.Drawing.Size(144, 20);
            this.seleccionRolLabel.TabIndex = 4;
            this.seleccionRolLabel.Text = "Seleccion de Rol";
            // 
            // rolesCombo
            // 
            this.rolesCombo.FormattingEnabled = true;
            this.rolesCombo.Items.AddRange(new object[] {
            "Cobrador",
            "Administrador"});
            this.rolesCombo.Location = new System.Drawing.Point(290, 69);
            this.rolesCombo.Name = "rolesCombo";
            this.rolesCombo.Size = new System.Drawing.Size(141, 21);
            this.rolesCombo.TabIndex = 5;
            // 
            // FrmSeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 195);
            this.Controls.Add(this.rolesCombo);
            this.Controls.Add(this.seleccionRolLabel);
            this.Controls.Add(this.rolesLabel);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.rolImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleccionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de Rol";
            ((System.ComponentModel.ISupportInitialize)(this.rolImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rolImage;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label rolesLabel;
        private System.Windows.Forms.Label seleccionRolLabel;
        private System.Windows.Forms.ComboBox rolesCombo;
    }
}