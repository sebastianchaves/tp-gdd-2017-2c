using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// para usar SQL
using System.Data.SqlClient;

namespace PagoAgilFrba
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // que usuario este en la base de datos
            // que la contraseña proporcionada sea la brindada
            SqlConnection cn = new SqlConnection(@"SQLSERVER2012.\SQLEXPRESS; user=sa:password=gestiondedatos:GD2C2017");
            try
            {
                // revisar esta sentencia dependiendo de como queden las tablas dps de ejecurtar el scrip
            SqlCommand cmd = new SqlCommand("select nombreUsuario, contrasenia" from USUARIOS where nombreUsuario=''+txtUsuario.Text+"' and  contrasenia='"+txtContrasenia.Text+"' ",cn);
            cn.Open();
            cmd.ExecuteNonQuery(cn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds,"USUARIOS);"

                    DataRow dro;
                dro=ds.Tables["USUARIOS"].Rows[0];

                if(txtUsuario.Text= dro["nombreUsuario"].ToString() || (txtContrasenia.Text == dro["Contrasenia"].ToString()));

                    FrmLogin Login = new Login();
                    Login.Show();
                    this.Hide();
            }
            catch
            {
            }

            finally 
            {
            cn.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
