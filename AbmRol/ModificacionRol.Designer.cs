namespace PagoAgilFrba.AbmRol
{
    partial class ModificacionRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionRol));
            this.modificacionRolLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.groupBoxFuncionalidades = new System.Windows.Forms.GroupBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.funcionalidadesLabel = new System.Windows.Forms.Label();
            this.deshabilitadoRadioButton = new System.Windows.Forms.RadioButton();
            this.habilitadoRadioButton = new System.Windows.Forms.RadioButton();
            this.funcionalidadesCheckbox = new System.Windows.Forms.CheckedListBox();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.rolSeleccionadoInput = new System.Windows.Forms.TextBox();
            this.rolSeleccionadoLabel = new System.Windows.Forms.Label();
            this.groupBoxFuncionalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificacionRolLabel
            // 
            this.modificacionRolLabel.AutoSize = true;
            this.modificacionRolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionRolLabel.Location = new System.Drawing.Point(96, 9);
            this.modificacionRolLabel.Name = "modificacionRolLabel";
            this.modificacionRolLabel.Size = new System.Drawing.Size(141, 20);
            this.modificacionRolLabel.TabIndex = 0;
            this.modificacionRolLabel.Text = "Modificacion Rol";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(229, 41);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 30);
            this.botonBuscar.TabIndex = 1;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(229, 384);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(90, 30);
            this.botonVolver.TabIndex = 7;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // groupBoxFuncionalidades
            // 
            this.groupBoxFuncionalidades.Controls.Add(this.nombreInput);
            this.groupBoxFuncionalidades.Controls.Add(this.nombreLabel);
            this.groupBoxFuncionalidades.Controls.Add(this.funcionalidadesLabel);
            this.groupBoxFuncionalidades.Controls.Add(this.deshabilitadoRadioButton);
            this.groupBoxFuncionalidades.Controls.Add(this.habilitadoRadioButton);
            this.groupBoxFuncionalidades.Controls.Add(this.funcionalidadesCheckbox);
            this.groupBoxFuncionalidades.Controls.Add(this.estadoLabel);
            this.groupBoxFuncionalidades.Location = new System.Drawing.Point(28, 77);
            this.groupBoxFuncionalidades.Name = "groupBoxFuncionalidades";
            this.groupBoxFuncionalidades.Size = new System.Drawing.Size(280, 291);
            this.groupBoxFuncionalidades.TabIndex = 4;
            this.groupBoxFuncionalidades.TabStop = false;
            this.groupBoxFuncionalidades.Text = "Datos del Rol";
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(96, 29);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(165, 20);
            this.nombreInput.TabIndex = 13;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(15, 32);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 12;
            this.nombreLabel.Text = "Nombre:";
            // 
            // funcionalidadesLabel
            // 
            this.funcionalidadesLabel.AutoSize = true;
            this.funcionalidadesLabel.Location = new System.Drawing.Point(15, 69);
            this.funcionalidadesLabel.Name = "funcionalidadesLabel";
            this.funcionalidadesLabel.Size = new System.Drawing.Size(87, 13);
            this.funcionalidadesLabel.TabIndex = 11;
            this.funcionalidadesLabel.Text = "Funcionalidades:";
            // 
            // deshabilitadoRadioButton
            // 
            this.deshabilitadoRadioButton.AutoSize = true;
            this.deshabilitadoRadioButton.Location = new System.Drawing.Point(172, 251);
            this.deshabilitadoRadioButton.Name = "deshabilitadoRadioButton";
            this.deshabilitadoRadioButton.Size = new System.Drawing.Size(89, 17);
            this.deshabilitadoRadioButton.TabIndex = 9;
            this.deshabilitadoRadioButton.Text = "Deshabilitado";
            this.deshabilitadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // habilitadoRadioButton
            // 
            this.habilitadoRadioButton.AutoSize = true;
            this.habilitadoRadioButton.Checked = true;
            this.habilitadoRadioButton.Location = new System.Drawing.Point(82, 251);
            this.habilitadoRadioButton.Name = "habilitadoRadioButton";
            this.habilitadoRadioButton.Size = new System.Drawing.Size(72, 17);
            this.habilitadoRadioButton.TabIndex = 8;
            this.habilitadoRadioButton.TabStop = true;
            this.habilitadoRadioButton.Text = "Habilitado";
            this.habilitadoRadioButton.UseVisualStyleBackColor = true;
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
            this.funcionalidadesCheckbox.Location = new System.Drawing.Point(18, 85);
            this.funcionalidadesCheckbox.Name = "funcionalidadesCheckbox";
            this.funcionalidadesCheckbox.Size = new System.Drawing.Size(243, 139);
            this.funcionalidadesCheckbox.TabIndex = 7;
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(15, 253);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(43, 13);
            this.estadoLabel.TabIndex = 10;
            this.estadoLabel.Text = "Estado:";
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(133, 384);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(90, 30);
            this.botonActualizar.TabIndex = 5;
            this.botonActualizar.Text = "&Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // rolSeleccionadoInput
            // 
            this.rolSeleccionadoInput.Location = new System.Drawing.Point(110, 47);
            this.rolSeleccionadoInput.Name = "rolSeleccionadoInput";
            this.rolSeleccionadoInput.ReadOnly = true;
            this.rolSeleccionadoInput.Size = new System.Drawing.Size(113, 20);
            this.rolSeleccionadoInput.TabIndex = 9;
            // 
            // rolSeleccionadoLabel
            // 
            this.rolSeleccionadoLabel.AutoSize = true;
            this.rolSeleccionadoLabel.Location = new System.Drawing.Point(12, 50);
            this.rolSeleccionadoLabel.Name = "rolSeleccionadoLabel";
            this.rolSeleccionadoLabel.Size = new System.Drawing.Size(92, 13);
            this.rolSeleccionadoLabel.TabIndex = 8;
            this.rolSeleccionadoLabel.Text = "Rol seleccionado:";
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 426);
            this.Controls.Add(this.rolSeleccionadoInput);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.rolSeleccionadoLabel);
            this.Controls.Add(this.modificacionRolLabel);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.groupBoxFuncionalidades);
            this.Controls.Add(this.botonBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificacionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Rol";
            this.groupBoxFuncionalidades.ResumeLayout(false);
            this.groupBoxFuncionalidades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modificacionRolLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBoxFuncionalidades;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.CheckedListBox funcionalidadesCheckbox;
        private System.Windows.Forms.RadioButton deshabilitadoRadioButton;
        private System.Windows.Forms.RadioButton habilitadoRadioButton;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.TextBox rolSeleccionadoInput;
        private System.Windows.Forms.Label rolSeleccionadoLabel;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label funcionalidadesLabel;
    }
}