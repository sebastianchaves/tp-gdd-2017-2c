namespace PagoAgilFrba.RendicionesPKG
{
    partial class RendicionAltaFrm
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
            this.confeccioneSuListadoGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mesCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comisionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empresaIdCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.diaRendicionCombo = new System.Windows.Forms.ComboBox();
            this.anioCombo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.confeccioneSuListadoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // confeccioneSuListadoGroupBox
            // 
            this.confeccioneSuListadoGroupBox.Controls.Add(this.label5);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.mesCombo);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.button1);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.label4);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.comisionText);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.label3);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.empresaIdCombo);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.label1);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.diaRendicionCombo);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.anioCombo);
            this.confeccioneSuListadoGroupBox.Controls.Add(this.label2);
            this.confeccioneSuListadoGroupBox.Location = new System.Drawing.Point(86, 12);
            this.confeccioneSuListadoGroupBox.Name = "confeccioneSuListadoGroupBox";
            this.confeccioneSuListadoGroupBox.Size = new System.Drawing.Size(561, 140);
            this.confeccioneSuListadoGroupBox.TabIndex = 10;
            this.confeccioneSuListadoGroupBox.TabStop = false;
            this.confeccioneSuListadoGroupBox.Text = "Rendir empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mes:";
            // 
            // mesCombo
            // 
            this.mesCombo.FormattingEnabled = true;
            this.mesCombo.Location = new System.Drawing.Point(17, 103);
            this.mesCombo.Name = "mesCombo";
            this.mesCombo.Size = new System.Drawing.Size(121, 21);
            this.mesCombo.TabIndex = 12;
            this.mesCombo.SelectedIndexChanged += new System.EventHandler(this.mesCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Rendir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Porcentaje comision";
            // 
            // comisionText
            // 
            this.comisionText.Location = new System.Drawing.Point(351, 44);
            this.comisionText.Name = "comisionText";
            this.comisionText.Size = new System.Drawing.Size(186, 20);
            this.comisionText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Empresa:";
            // 
            // empresaIdCombo
            // 
            this.empresaIdCombo.FormattingEnabled = true;
            this.empresaIdCombo.Location = new System.Drawing.Point(177, 43);
            this.empresaIdCombo.Name = "empresaIdCombo";
            this.empresaIdCombo.Size = new System.Drawing.Size(121, 21);
            this.empresaIdCombo.TabIndex = 7;
            this.empresaIdCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dia:";
            // 
            // diaRendicionCombo
            // 
            this.diaRendicionCombo.FormattingEnabled = true;
            this.diaRendicionCombo.Location = new System.Drawing.Point(17, 43);
            this.diaRendicionCombo.Name = "diaRendicionCombo";
            this.diaRendicionCombo.Size = new System.Drawing.Size(121, 21);
            this.diaRendicionCombo.TabIndex = 5;
            this.diaRendicionCombo.SelectedIndexChanged += new System.EventHandler(this.diaRendicionCombo_SelectedIndexChanged);
            // 
            // anioCombo
            // 
            this.anioCombo.Location = new System.Drawing.Point(177, 103);
            this.anioCombo.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.anioCombo.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.anioCombo.Name = "anioCombo";
            this.anioCombo.Size = new System.Drawing.Size(121, 20);
            this.anioCombo.TabIndex = 1;
            this.anioCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anioCombo.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.anioCombo.ValueChanged += new System.EventHandler(this.anioCombo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año:";
            // 
            // RendicionPKGFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 206);
            this.Controls.Add(this.confeccioneSuListadoGroupBox);
            this.Name = "RendicionPKGFrm";
            this.Text = "Alta de rendicion";
            this.confeccioneSuListadoGroupBox.ResumeLayout(false);
            this.confeccioneSuListadoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioCombo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox confeccioneSuListadoGroupBox;
        private System.Windows.Forms.NumericUpDown anioCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox diaRendicionCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comisionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox empresaIdCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mesCombo;
    }
}