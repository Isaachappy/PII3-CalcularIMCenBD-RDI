using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII3_CalcularIMCenBD_RDI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control CajaTexto in this.Controls)
            {
                if (CajaTexto is TextBox)
                {
                    CajaTexto.Text = "";
                }
            }

            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
            }
            bool v = tbxUsuario.Focus();

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int error = 0;

          
            if (String.IsNullOrEmpty(tbxUsuario.Text))
            {
                MessageBox.Show("El campo USUARIO no debe estar vacío", "¡IMPORTANTE!");
                error = 1;
                bool v = tbxUsuario.Focus();
            }
            if (String.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("El campo CONTRASEÑA no debe estar vacío", "¡IMPORTANTE!");
                error = 1;
                bool v = tbxPassword.Focus();
            }

            if (error == 0)
            {
                string username, pass, nombreusuario, edadusuario;
                username =tbxUsuario.Text;
                pass = tbxPassword.Text;

          //      MySqlConnection con = new MySqlConnection("server = 127.0.0.1; Adatabade=login; User Id= root; password=lentp123");

                MySqlConnection con = new MySqlConnection

                    ("server=localhost;database=IMC;user=root;password=;");
                  
                try
                {
                    con.Open();
                }
                catch (MySqlException ex) { MessageBox.Show("Error" + ex.ToString()); }

                string sql = "SELECT nombre,edad,usr,pwd FROM usuarios WHERE usr='" + username + "' AND pwd='" + pass + "' ";

                MySqlCommand comando= new MySqlCommand(sql, con);
               // comando.Parameters.AddWithValue("@nombreusuarios",nombreusuario);
                MySqlDataReader read = comando.ExecuteReader();
                if ( read.Read())
                {
                    
                    MessageBox.Show("Bienvenido " + username);
                    fMenu fFormMenu = new fMenu();
                    nombreusuario =read["nombre"].ToString();
                    edadusuario = read["edad"].ToString() ;
                    fFormMenu.tbxNombreM.Text = nombreusuario;
                    fFormMenu.tbxUsuarioM.Text = username;
                    fFormMenu.tbxEdadM.Text = edadusuario;
                    fFormMenu.Show();
                    this.Hide();

                   
                }
                else
                {
                    MessageBox.Show("no existe el usuario" + username);
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            fRegistro fFormRegistro = new fRegistro();  
            fFormRegistro.Show();
            this.Hide();
        }
    }
}
