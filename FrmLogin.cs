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
        private SucursalDAO<Sucursal> sucursalDao;

        public FrmLogin()
        {
            InitializeComponent();
            EmpresasConMontoRendidoDao<EmpresaConMontoRendido> dao = new EmpresasConMontoRendidoDao<EmpresaConMontoRendido>();
            List<EmpresaConMontoRendido> result = dao.obtenerMayoresMontosRendidos(2017, 1);
            this.usuarioDao = new UsuarioDAO<Usuario>();
            this.sucursalDao = new SucursalDAO<Sucursal>();
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

            if (usuarios.Count > 0)
            {

                this.usuarioLogin = usuarios.ElementAt(0);

                String contraseniaPosta = Utils.getSha256(this.contrasenia);

                if (contraseniaPosta.Equals(this.usuarioLogin.contrasenia) && this.usuarioLogin.habilitado)
                {
                    int sucursalId = this.usuarioLogin.idSucursal;
                    if (sucursalId == 0 || sucursalDao.sucursalPorId(this.usuarioLogin.idSucursal).ElementAt(0).activo)
                    {
                        usuarioDao.reiniciarIntentos(this.usuarioLogin);
                        using (FrmPrincipal frmP = new FrmPrincipal(this.usuarioLogin))
                        {
                            this.Hide();
                            frmP.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La sucursal perteneciente al usuario esta inhabilitada");
                    }
                }
                else
                {
                    this.contrasenia = "";
                    this.usuario = "";
                    int intentos = usuarioDao.sumarIntentos(this.usuarioLogin);
                    this.usuarioLogin = new Usuario();
                    if (intentos > 2)
                    {
                        MessageBox.Show("Usuario inhabilitado por intentos fallidos");
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario inexistente");
                Utils.clearTextBoxes(this);
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
