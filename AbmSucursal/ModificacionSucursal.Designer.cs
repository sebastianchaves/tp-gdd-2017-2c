namespace PagoAgilFrba.AbmSucursal
{
    partial class ModificacionSucursal
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
            this.modificacionSucursalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modificacionSucursalLabel
            // 
            this.modificacionSucursalLabel.AutoSize = true;
            this.modificacionSucursalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionSucursalLabel.Location = new System.Drawing.Point(65, 9);
            this.modificacionSucursalLabel.Name = "modificacionSucursalLabel";
            this.modificacionSucursalLabel.Size = new System.Drawing.Size(163, 20);
            this.modificacionSucursalLabel.TabIndex = 1;
            this.modificacionSucursalLabel.Text = "Modificacion Sucursal";
            // 
            // ModificacionSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.modificacionSucursalLabel);
            this.Name = "ModificacionSucursal";
            this.Text = "Modificacion Sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modificacionSucursalLabel;
    }
}