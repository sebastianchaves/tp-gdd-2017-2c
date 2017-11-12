namespace PagoAgilFrba.Devoluciones
{
    partial class DevolucionRendicionForm
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
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonDevolver = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.devolucionRendicionLabel = new System.Windows.Forms.Label();
            this.datosRendicionGroupbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datosRendicionGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(232, 287);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 5;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonDevolver
            // 
            this.botonDevolver.Enabled = false;
            this.botonDevolver.Location = new System.Drawing.Point(136, 287);
            this.botonDevolver.Name = "botonDevolver";
            this.botonDevolver.Size = new System.Drawing.Size(90, 30);
            this.botonDevolver.TabIndex = 4;
            this.botonDevolver.Text = "&Devolver";
            this.botonDevolver.UseVisualStyleBackColor = true;
            this.botonDevolver.Click += new System.EventHandler(this.botonDevolver_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(40, 287);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // devolucionRendicionLabel
            // 
            this.devolucionRendicionLabel.AutoSize = true;
            this.devolucionRendicionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devolucionRendicionLabel.Location = new System.Drawing.Point(96, 9);
            this.devolucionRendicionLabel.Name = "devolucionRendicionLabel";
            this.devolucionRendicionLabel.Size = new System.Drawing.Size(162, 20);
            this.devolucionRendicionLabel.TabIndex = 0;
            this.devolucionRendicionLabel.Text = "Devolucion Rendicion";
            // 
            // datosRendicionGroupbox
            // 
            this.datosRendicionGroupbox.Controls.Add(this.label3);
            this.datosRendicionGroupbox.Controls.Add(this.label2);
            this.datosRendicionGroupbox.Controls.Add(this.label1);
            this.datosRendicionGroupbox.Controls.Add(this.textBox1);
            this.datosRendicionGroupbox.Controls.Add(this.richTextBox1);
            this.datosRendicionGroupbox.Controls.Add(this.dateTimePicker1);
            this.datosRendicionGroupbox.Location = new System.Drawing.Point(12, 44);
            this.datosRendicionGroupbox.Name = "datosRendicionGroupbox";
            this.datosRendicionGroupbox.Size = new System.Drawing.Size(338, 237);
            this.datosRendicionGroupbox.TabIndex = 8;
            this.datosRendicionGroupbox.TabStop = false;
            this.datosRendicionGroupbox.Text = "Datos rendicion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Motivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rendicion:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(88, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(88, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 140);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // DevolucionRendicionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 329);
            this.Controls.Add(this.datosRendicionGroupbox);
            this.Controls.Add(this.devolucionRendicionLabel);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonDevolver);
            this.Controls.Add(this.botonBuscar);
            this.Name = "DevolucionRendicionForm";
            this.Text = "Devolucion Rendicion";
            this.datosRendicionGroupbox.ResumeLayout(false);
            this.datosRendicionGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonDevolver;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label devolucionRendicionLabel;
        private System.Windows.Forms.GroupBox datosRendicionGroupbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}