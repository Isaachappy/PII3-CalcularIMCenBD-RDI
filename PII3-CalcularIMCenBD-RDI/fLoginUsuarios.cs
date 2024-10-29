using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PII3_CalcularIMCenBD_RDI
{
    public partial class fLoginUsuarios : Form
    {
        string connectionString = "Server=localhost;Database=usuariosimc;Uid=root;Pwd=;";
        public fLoginUsuarios()
        {
            InitializeComponent();
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
        
    }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYaTengoCuenta_Click(object sender, EventArgs e)
        {
            fLoginVerdadero miform2 = new fLoginVerdadero();
            this.Hide();
            miform2.Show();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text;
            string clave = tbxPwd1.Text;
            string edad = tbxEdad.Text;
            string correo = tbxCorreo.Text;
            string clave2 = tbxPwd2.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO usuarios (usuario,clave,edad,correo,domicilio) VALUES (@usuario,@clave,@edad,@correo,@domicilio)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@edad", edad);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@domicilio", clave2);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex.Message);
                }
            }
        }

        private void btnVerContra_Click(object sender, EventArgs e)
        {
            tbxPwd1.PasswordChar = '\0';
        }

        private void btnnOcultarContra_Click(object sender, EventArgs e)
        {
            tbxPwd1.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {

        }

        private void tbxPwd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPwd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGmail_Click(object sender, EventArgs e)
        {

        }

        private void txtxEdad_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
