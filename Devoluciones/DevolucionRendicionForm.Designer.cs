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
            this.anioLabel = new System.Windows.Forms.Label();
            this.mesLabel = new System.Windows.Forms.Label();
            this.anioInput = new System.Windows.Forms.TextBox();
            this.mesInput = new System.Windows.Forms.TextBox();
            this.rendicionLabel = new System.Windows.Forms.Label();
            this.rendicionInput = new System.Windows.Forms.TextBox();
            this.datosDevolucionGroupbox = new System.Windows.Forms.GroupBox();
            this.botonNuevaDevolucion = new System.Windows.Forms.Button();
            this.botonCrearDevolucion = new System.Windows.Forms.Button();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.motivoLabel = new System.Windows.Forms.Label();
            this.fechaInput = new System.Windows.Forms.DateTimePicker();
            this.motivoInput = new System.Windows.Forms.RichTextBox();
            this.datosRendicionGroupbox.SuspendLayout();
            this.datosDevolucionGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(260, 358);
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
            this.botonDevolver.Location = new System.Drawing.Point(164, 358);
            this.botonDevolver.Name = "botonDevolver";
            this.botonDevolver.Size = new System.Drawing.Size(90, 30);
            this.botonDevolver.TabIndex = 4;
            this.botonDevolver.Text = "&Devolver";
            this.botonDevolver.UseVisualStyleBackColor = true;
            this.botonDevolver.Click += new System.EventHandler(this.botonDevolver_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(235, 103);
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
            this.datosRendicionGroupbox.Controls.Add(this.anioLabel);
            this.datosRendicionGroupbox.Controls.Add(this.mesLabel);
            this.datosRendicionGroupbox.Controls.Add(this.anioInput);
            this.datosRendicionGroupbox.Controls.Add(this.mesInput);
            this.datosRendicionGroupbox.Controls.Add(this.rendicionLabel);
            this.datosRendicionGroupbox.Controls.Add(this.rendicionInput);
            this.datosRendicionGroupbox.Controls.Add(this.botonBuscar);
            this.datosRendicionGroupbox.Location = new System.Drawing.Point(12, 203);
            this.datosRendicionGroupbox.Name = "datosRendicionGroupbox";
            this.datosRendicionGroupbox.Size = new System.Drawing.Size(338, 139);
            this.datosRendicionGroupbox.TabIndex = 8;
            this.datosRendicionGroupbox.TabStop = false;
            this.datosRendicionGroupbox.Text = "Datos rendicion";
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(14, 80);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(29, 13);
            this.anioLabel.TabIndex = 15;
            this.anioLabel.Text = "Año:";
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Location = new System.Drawing.Point(14, 54);
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(30, 13);
            this.mesLabel.TabIndex = 14;
            this.mesLabel.Text = "Mes:";
            // 
            // anioInput
            // 
            this.anioInput.Location = new System.Drawing.Point(88, 77);
            this.anioInput.Name = "anioInput";
            this.anioInput.ReadOnly = true;
            this.anioInput.Size = new System.Drawing.Size(237, 20);
            this.anioInput.TabIndex = 13;
            // 
            // mesInput
            // 
            this.mesInput.Location = new System.Drawing.Point(88, 51);
            this.mesInput.Name = "mesInput";
            this.mesInput.ReadOnly = true;
            this.mesInput.Size = new System.Drawing.Size(237, 20);
            this.mesInput.TabIndex = 12;
            // 
            // rendicionLabel
            // 
            this.rendicionLabel.AutoSize = true;
            this.rendicionLabel.Location = new System.Drawing.Point(14, 28);
            this.rendicionLabel.Name = "rendicionLabel";
            this.rendicionLabel.Size = new System.Drawing.Size(51, 13);
            this.rendicionLabel.TabIndex = 11;
            this.rendicionLabel.Text = "Empresa:";
            // 
            // rendicionInput
            // 
            this.rendicionInput.Location = new System.Drawing.Point(88, 25);
            this.rendicionInput.Name = "rendicionInput";
            this.rendicionInput.ReadOnly = true;
            this.rendicionInput.Size = new System.Drawing.Size(237, 20);
            this.rendicionInput.TabIndex = 10;
            // 
            // datosDevolucionGroupbox
            // 
            this.datosDevolucionGroupbox.Controls.Add(this.botonNuevaDevolucion);
            this.datosDevolucionGroupbox.Controls.Add(this.botonCrearDevolucion);
            this.datosDevolucionGroupbox.Controls.Add(this.fechaLabel);
            this.datosDevolucionGroupbox.Controls.Add(this.motivoLabel);
            this.datosDevolucionGroupbox.Controls.Add(this.fechaInput);
            this.datosDevolucionGroupbox.Controls.Add(this.motivoInput);
            this.datosDevolucionGroupbox.Location = new System.Drawing.Point(12, 32);
            this.datosDevolucionGroupbox.Name = "datosDevolucionGroupbox";
            this.datosDevolucionGroupbox.Size = new System.Drawing.Size(338, 165);
            this.datosDevolucionGroupbox.TabIndex = 15;
            this.datosDevolucionGroupbox.TabStop = false;
            this.datosDevolucionGroupbox.Text = "Datos devolucion";
            // 
            // botonNuevaDevolucion
            // 
            this.botonNuevaDevolucion.Enabled = false;
            this.botonNuevaDevolucion.Location = new System.Drawing.Point(139, 129);
            this.botonNuevaDevolucion.Name = "botonNuevaDevolucion";
            this.botonNuevaDevolucion.Size = new System.Drawing.Size(90, 30);
            this.botonNuevaDevolucion.TabIndex = 16;
            this.botonNuevaDevolucion.Text = "&Nueva";
            this.botonNuevaDevolucion.UseVisualStyleBackColor = true;
            this.botonNuevaDevolucion.Click += new System.EventHandler(this.botonNuevaDevolucion_Click);
            // 
            // botonCrearDevolucion
            // 
            this.botonCrearDevolucion.Enabled = false;
            this.botonCrearDevolucion.Location = new System.Drawing.Point(235, 129);
            this.botonCrearDevolucion.Name = "botonCrearDevolucion";
            this.botonCrearDevolucion.Size = new System.Drawing.Size(90, 30);
            this.botonCrearDevolucion.TabIndex = 15;
            this.botonCrearDevolucion.Text = "&Crear";
            this.botonCrearDevolucion.UseVisualStyleBackColor = true;
            this.botonCrearDevolucion.Click += new System.EventHandler(this.botonCrearDevolucion_Click);
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(14, 34);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(40, 13);
            this.fechaLabel.TabIndex = 12;
            this.fechaLabel.Text = "Fecha:";
            // 
            // motivoLabel
            // 
            this.motivoLabel.AutoSize = true;
            this.motivoLabel.Location = new System.Drawing.Point(14, 64);
            this.motivoLabel.Name = "motivoLabel";
            this.motivoLabel.Size = new System.Drawing.Size(42, 13);
            this.motivoLabel.TabIndex = 13;
            this.motivoLabel.Text = "Motivo:";
            // 
            // fechaInput
            // 
            this.fechaInput.Enabled = false;
            this.fechaInput.Location = new System.Drawing.Point(88, 28);
            this.fechaInput.Name = "fechaInput";
            this.fechaInput.Size = new System.Drawing.Size(237, 20);
            this.fechaInput.TabIndex = 8;
            this.fechaInput.Leave += new System.EventHandler(this.fechaInput_Leave);
            // 
            // motivoInput
            // 
            this.motivoInput.Location = new System.Drawing.Point(88, 61);
            this.motivoInput.MaxLength = 255;
            this.motivoInput.Name = "motivoInput";
            this.motivoInput.Size = new System.Drawing.Size(237, 63);
            this.motivoInput.TabIndex = 9;
            this.motivoInput.Text = "";
            this.motivoInput.TextChanged += new System.EventHandler(this.motivoInput_TextChanged);
            this.motivoInput.Leave += new System.EventHandler(this.motivoInput_Leave);
            // 
            // DevolucionRendicionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 400);
            this.Controls.Add(this.datosDevolucionGroupbox);
            this.Controls.Add(this.datosRendicionGroupbox);
            this.Controls.Add(this.devolucionRendicionLabel);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonDevolver);
            this.Name = "DevolucionRendicionForm";
            this.Text = "Devolucion Rendicion";
            this.datosRendicionGroupbox.ResumeLayout(false);
            this.datosRendicionGroupbox.PerformLayout();
            this.datosDevolucionGroupbox.ResumeLayout(false);
            this.datosDevolucionGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonDevolver;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label devolucionRendicionLabel;
        private System.Windows.Forms.GroupBox datosRendicionGroupbox;
        private System.Windows.Forms.Label rendicionLabel;
        private System.Windows.Forms.TextBox rendicionInput;
        private System.Windows.Forms.GroupBox datosDevolucionGroupbox;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label motivoLabel;
        private System.Windows.Forms.DateTimePicker fechaInput;
        private System.Windows.Forms.RichTextBox motivoInput;
        private System.Windows.Forms.Button botonNuevaDevolucion;
        private System.Windows.Forms.Button botonCrearDevolucion;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.Label mesLabel;
        private System.Windows.Forms.TextBox anioInput;
        private System.Windows.Forms.TextBox mesInput;
    }
}