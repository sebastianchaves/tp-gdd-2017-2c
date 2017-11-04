using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoAgilFrba.Modelo.Utils;
using PagoAgilFrba.Modelo.Entidades;
using PagoAgilFrba.Modelo.DAOs;

namespace PagoAgilFrba
{
    public partial class FrmLogin : Form
    {

        private String usuario;
        private String contrasenia;
        private Usuario usuarioLogin;
        private UsuarioDAO<Usuario> usuarioDao;

        public FrmLogin()
        {
            InitializeComponent();

            this.usuarioDao = new UsuarioDAO<Usuario>();
        }

        private void login()
        {
            if (this.camposCompletos())
            {
                this.logearse();
            }
            else
            {
                MessageBox.Show("Complete los campos faltantes");
            }
        }

        private void logearse()
        {
            List<Usuario> usuarios = this.usuarioDao.findUsuario(usuario);
            this.usuarioLogin = usuarios.ElementAt(0);

            String contraseniaPosta = Utils.getSha256(this.contrasenia);

            if (contraseniaPosta.Equals(this.usuarioLogin.contrasenia))
            {
                this.Close();
            }
            else
            {
                this.contrasenia = "";
                this.usuario = "";
                this.usuarioLogin = new Usuario();
                MessageBox.Show("Contraseña incorrecta!");
            }
        }

        private Boolean camposCompletos()
        {
            return this.usuarioInput.Text != "" && this.contraseniaInput.Text != "";
        }

        public Usuario getUsuarioLogin()
        {
            return this.usuarioLogin;
        }

        // Eventos
        // Boton Ingresar
        private void botonIngresar_Click(object sender, EventArgs e)
        {
            this.login();
        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargando Datos
        // Usuario
        private void usuarioInput_Leave(object sender, EventArgs e)
        {
            this.usuario = this.usuarioInput.Text;
        }

        // Contrasenia
        private void contraseniaInput_Leave(object sender, EventArgs e)
        {
            this.contrasenia = this.contraseniaInput.Text;
        }

    }
}
