namespace PagoAgilFrba.AbmFactura
{
    partial class BajaFactura
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
            this.bajaFacturaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bajaFacturaLabel
            // 
            this.bajaFacturaLabel.AutoSize = true;
            this.bajaFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaFacturaLabel.Location = new System.Drawing.Point(157, 9);
            this.bajaFacturaLabel.Name = "bajaFacturaLabel";
            this.bajaFacturaLabel.Size = new System.Drawing.Size(100, 20);
            this.bajaFacturaLabel.TabIndex = 1;
            this.bajaFacturaLabel.Text = "Baja Factura";
            // 
            // BajaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 306);
            this.Controls.Add(this.bajaFacturaLabel);
            this.Name = "BajaFactura";
            this.Text = "Baja Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bajaFacturaLabel;
    }
}