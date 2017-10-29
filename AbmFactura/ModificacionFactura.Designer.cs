namespace PagoAgilFrba.AbmFactura
{
    partial class ModificacionFactura
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
            this.modificacionFacturaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modificacionFacturaLabel
            // 
            this.modificacionFacturaLabel.AutoSize = true;
            this.modificacionFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionFacturaLabel.Location = new System.Drawing.Point(128, 9);
            this.modificacionFacturaLabel.Name = "modificacionFacturaLabel";
            this.modificacionFacturaLabel.Size = new System.Drawing.Size(156, 20);
            this.modificacionFacturaLabel.TabIndex = 1;
            this.modificacionFacturaLabel.Text = "Modificacion Factura";
            // 
            // ModificacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 274);
            this.Controls.Add(this.modificacionFacturaLabel);
            this.Name = "ModificacionFactura";
            this.Text = "Modificacion Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modificacionFacturaLabel;
    }
}