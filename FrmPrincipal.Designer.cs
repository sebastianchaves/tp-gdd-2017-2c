namespace PagoAgilFrba
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmClienteTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmEmpresaTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmFacturaTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.aFacturaTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.mFacturaTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.bFacturaTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoFacturaTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.abmRolTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.altaRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmSucursalTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.altaSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadisticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendicionTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.botonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.abmClienteTooltip,
            this.abmEmpresaTooltip,
            this.abmFacturaTooltip,
            this.abmRolTooltip,
            this.abmSucursalTooltip,
            this.estadisticasTooltip,
            this.rendicionTooltip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // abmClienteTooltip
            // 
            this.abmClienteTooltip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem,
            this.modificaciónClienteToolStripMenuItem});
            this.abmClienteTooltip.Enabled = false;
            this.abmClienteTooltip.Name = "abmClienteTooltip";
            this.abmClienteTooltip.Size = new System.Drawing.Size(56, 20);
            this.abmClienteTooltip.Text = "&Cliente";
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.altaClienteToolStripMenuItem.Text = "Alta cliente";
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click);
            // 
            // modificaciónClienteToolStripMenuItem
            // 
            this.modificaciónClienteToolStripMenuItem.Name = "modificaciónClienteToolStripMenuItem";
            this.modificaciónClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modificaciónClienteToolStripMenuItem.Text = "Modificación cliente";
            this.modificaciónClienteToolStripMenuItem.Click += new System.EventHandler(this.modificaciónClienteToolStripMenuItem_Click);
            // 
            // abmEmpresaTooltip
            // 
            this.abmEmpresaTooltip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEmpresaToolStripMenuItem,
            this.modificaciónEmpresaToolStripMenuItem});
            this.abmEmpresaTooltip.Enabled = false;
            this.abmEmpresaTooltip.Name = "abmEmpresaTooltip";
            this.abmEmpresaTooltip.Size = new System.Drawing.Size(64, 20);
            this.abmEmpresaTooltip.Text = "&Empresa";
            // 
            // altaEmpresaToolStripMenuItem
            // 
            this.altaEmpresaToolStripMenuItem.Name = "altaEmpresaToolStripMenuItem";
            this.altaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.altaEmpresaToolStripMenuItem.Text = "Alta empresa";
            this.altaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.altaEmpresaToolStripMenuItem_Click);
            // 
            // modificaciónEmpresaToolStripMenuItem
            // 
            this.modificaciónEmpresaToolStripMenuItem.Name = "modificaciónEmpresaToolStripMenuItem";
            this.modificaciónEmpresaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.modificaciónEmpresaToolStripMenuItem.Text = "Modificación empresa";
            this.modificaciónEmpresaToolStripMenuItem.Click += new System.EventHandler(this.modificaciónEmpresaToolStripMenuItem_Click);
            // 
            // abmFacturaTooltip
            // 
            this.abmFacturaTooltip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aFacturaTooltip,
            this.mFacturaTooltip,
            this.bFacturaTooltip,
            this.pagoFacturaTooltip});
            this.abmFacturaTooltip.Name = "abmFacturaTooltip";
            this.abmFacturaTooltip.Size = new System.Drawing.Size(58, 20);
            this.abmFacturaTooltip.Text = "&Factura";
            // 
            // aFacturaTooltip
            // 
            this.aFacturaTooltip.Enabled = false;
            this.aFacturaTooltip.Name = "aFacturaTooltip";
            this.aFacturaTooltip.Size = new System.Drawing.Size(184, 22);
            this.aFacturaTooltip.Text = "Alta factura";
            this.aFacturaTooltip.Click += new System.EventHandler(this.altaFacturaToolStripMenuItem_Click);
            // 
            // mFacturaTooltip
            // 
            this.mFacturaTooltip.Enabled = false;
            this.mFacturaTooltip.Name = "mFacturaTooltip";
            this.mFacturaTooltip.Size = new System.Drawing.Size(184, 22);
            this.mFacturaTooltip.Text = "Modificación factura";
            this.mFacturaTooltip.Click += new System.EventHandler(this.modificaciónFacturaToolStripMenuItem_Click);
            // 
            // bFacturaTooltip
            // 
            this.bFacturaTooltip.Enabled = false;
            this.bFacturaTooltip.Name = "bFacturaTooltip";
            this.bFacturaTooltip.Size = new System.Drawing.Size(184, 22);
            this.bFacturaTooltip.Text = "Alta factura";
            this.bFacturaTooltip.Click += new System.EventHandler(this.bFacturaTooltip_Click);
            // 
            // pagoFacturaTooltip
            // 
            this.pagoFacturaTooltip.Enabled = false;
            this.pagoFacturaTooltip.Name = "pagoFacturaTooltip";
            this.pagoFacturaTooltip.Size = new System.Drawing.Size(184, 22);
            this.pagoFacturaTooltip.Text = "Pago de factura";
            this.pagoFacturaTooltip.Click += new System.EventHandler(this.pagoDeFacturaToolStripMenuItem_Click);
            // 
            // abmRolTooltip
            // 
            this.abmRolTooltip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaRolToolStripMenuItem,
            this.modificaciónRolToolStripMenuItem,
            this.bajaRolToolStripMenuItem});
            this.abmRolTooltip.Enabled = false;
            this.abmRolTooltip.Name = "abmRolTooltip";
            this.abmRolTooltip.Size = new System.Drawing.Size(36, 20);
            this.abmRolTooltip.Text = "&Rol";
            // 
            // altaRolToolStripMenuItem
            // 
            this.altaRolToolStripMenuItem.Name = "altaRolToolStripMenuItem";
            this.altaRolToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.altaRolToolStripMenuItem.Text = "Alta rol";
            this.altaRolToolStripMenuItem.Click += new System.EventHandler(this.altaRolToolStripMenuItem_Click);
            // 
            // modificaciónRolToolStripMenuItem
            // 
            this.modificaciónRolToolStripMenuItem.Name = "modificaciónRolToolStripMenuItem";
            this.modificaciónRolToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modificaciónRolToolStripMenuItem.Text = "Modificación rol";
            this.modificaciónRolToolStripMenuItem.Click += new System.EventHandler(this.modificaciónRolToolStripMenuItem_Click);
            // 
            // bajaRolToolStripMenuItem
            // 
            this.bajaRolToolStripMenuItem.Name = "bajaRolToolStripMenuItem";
            this.bajaRolToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bajaRolToolStripMenuItem.Text = "Baja rol";
            // 
            // abmSucursalTooltip
            // 
            this.abmSucursalTooltip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaSucursalToolStripMenuItem,
            this.modificaciónSucursalToolStripMenuItem});
            this.abmSucursalTooltip.Enabled = false;
            this.abmSucursalTooltip.Name = "abmSucursalTooltip";
            this.abmSucursalTooltip.Size = new System.Drawing.Size(63, 20);
            this.abmSucursalTooltip.Text = "&Sucursal";
            // 
            // altaSucursalToolStripMenuItem
            // 
            this.altaSucursalToolStripMenuItem.Name = "altaSucursalToolStripMenuItem";
            this.altaSucursalToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.altaSucursalToolStripMenuItem.Text = "Alta sucursal";
            this.altaSucursalToolStripMenuItem.Click += new System.EventHandler(this.altaSucursalToolStripMenuItem_Click);
            // 
            // modificaciónSucursalToolStripMenuItem
            // 
            this.modificaciónSucursalToolStripMenuItem.Name = "modificaciónSucursalToolStripMenuItem";
            this.modificaciónSucursalToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modificaciónSucursalToolStripMenuItem.Text = "Modificación sucursal";
            this.modificaciónSucursalToolStripMenuItem.Click += new System.EventHandler(this.modificaciónSucursalToolStripMenuItem_Click);
            // 
            // estadisticasTooltip
            // 
            this.estadisticasTooltip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoEstadisticoToolStripMenuItem});
            this.estadisticasTooltip.Enabled = false;
            this.estadisticasTooltip.Name = "estadisticasTooltip";
            this.estadisticasTooltip.Size = new System.Drawing.Size(79, 20);
            this.estadisticasTooltip.Text = "E&stadísticas";
            // 
            // listadoEstadisticoToolStripMenuItem
            // 
            this.listadoEstadisticoToolStripMenuItem.Name = "listadoEstadisticoToolStripMenuItem";
            this.listadoEstadisticoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.listadoEstadisticoToolStripMenuItem.Text = "Listado Estadistico";
            this.listadoEstadisticoToolStripMenuItem.Click += new System.EventHandler(this.listadoEstadisticoToolStripMenuItem_Click);
            // 
            // rendicionTooltip
            // 
            this.rendicionTooltip.Enabled = false;
            this.rendicionTooltip.Name = "rendicionTooltip";
            this.rendicionTooltip.Size = new System.Drawing.Size(72, 20);
            this.rendicionTooltip.Text = "Re&ndición";
            this.rendicionTooltip.Click += new System.EventHandler(this.rendicionTooltip_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(385, 270);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(96, 39);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.Text = "&Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 321);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Ágil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmClienteTooltip;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmEmpresaTooltip;
        private System.Windows.Forms.ToolStripMenuItem altaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmFacturaTooltip;
        private System.Windows.Forms.ToolStripMenuItem aFacturaTooltip;
        private System.Windows.Forms.ToolStripMenuItem mFacturaTooltip;
        private System.Windows.Forms.ToolStripMenuItem bFacturaTooltip;
        private System.Windows.Forms.ToolStripMenuItem pagoFacturaTooltip;
        private System.Windows.Forms.ToolStripMenuItem abmRolTooltip;
        private System.Windows.Forms.ToolStripMenuItem altaRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmSucursalTooltip;
        private System.Windows.Forms.ToolStripMenuItem altaSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasTooltip;
        private System.Windows.Forms.ToolStripMenuItem rendicionTooltip;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadisticoToolStripMenuItem;
    }
}