namespace PagoAgilFrba
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.contraseniaLabel = new System.Windows.Forms.Label();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.usuarioInput = new System.Windows.Forms.TextBox();
            this.contraseniaInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(26, 38);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(114, 113);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(246, 38);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(46, 16);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(163, 81);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(46, 13);
            this.usuarioLabel.TabIndex = 2;
            this.usuarioLabel.Text = "Usuario:";
            // 
            // contraseniaLabel
            // 
            this.contraseniaLabel.AutoSize = true;
            this.contraseniaLabel.Location = new System.Drawing.Point(163, 120);
            this.contraseniaLabel.Name = "contraseniaLabel";
            this.contraseniaLabel.Size = new System.Drawing.Size(64, 13);
            this.contraseniaLabel.TabIndex = 3;
            this.contraseniaLabel.Text = "Contraseña:";
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(189, 160);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(90, 30);
            this.botonIngresar.TabIndex = 4;
            this.botonIngresar.Text = "&Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(285, 160);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(90, 30);
            this.botonCancelar.TabIndex = 5;
            this.botonCancelar.Text = "&Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // usuarioInput
            // 
            this.usuarioInput.Location = new System.Drawing.Point(233, 78);
            this.usuarioInput.Name = "usuarioInput";
            this.usuarioInput.Size = new System.Drawing.Size(142, 20);
            this.usuarioInput.TabIndex = 6;
            // 
            // contraseniaInput
            // 
            this.contraseniaInput.Location = new System.Drawing.Point(233, 117);
            this.contraseniaInput.Name = "contraseniaInput";
            this.contraseniaInput.Size = new System.Drawing.Size(142, 20);
            this.contraseniaInput.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 202);
            this.Controls.Add(this.contraseniaInput);
            this.Controls.Add(this.usuarioInput);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.contraseniaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.pictureLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Ágil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label contraseniaLabel;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.TextBox usuarioInput;
        private System.Windows.Forms.TextBox contraseniaInput;
    }
}