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
    public partial class fCalcularIMC : Form
    {
        string connectionString = "Server=localhost;Database=imc;Uid=root;Pwd=;";
        public fCalcularIMC()
        {
            InitializeComponent();
        }

        private void CalcularIMC_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar3_Click(object sender, EventArgs e)
        {
            tbxPeso.Text = string.Empty;
            tbxEstatura.Text = string.Empty;    
            tbxIMC.Text = string.Empty;
            bool v = tbxPeso.Focus();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            fLogin fFormLogin = new fLogin();
            fFormLogin.Show();
            this.Hide();    

        }

        private void btnAcpetar3_Click(object sender, EventArgs e)
        {
            int error = 0;

             if (String.IsNullOrEmpty(tbxPeso.Text))
            {
                MessageBox.Show("El campo de PESO mo debe estar vacio", "IMPORTANTE!");
                error = 1;
                bool v = tbxPeso.Focus();
            }
            if (String.IsNullOrEmpty(tbxEstatura.Text))
            {
                MessageBox.Show("El campo de ESTATURA mo debe estar vacio", "IMPORTANTE!");
                error = 1;
                bool v = tbxEstatura.Focus();
            }
            if (error == 0)
            {
                string usuario = tbxUsuarioC.Text;
                double peso = Convert.ToDouble(tbxPeso.Text);
                double estatura = Convert.ToDouble(tbxEstatura.Text);
                double imc = peso / (estatura * estatura);

                imc = Math.Round(imc, 2);
                tbxIMC.Text = imc.ToString();
                string fecha = DateTime.Now.ToString();

                using (MySqlConnection conn = new MySqlConnection
                    (connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO registrosimc(usr,peso,estatura,imc,fecha) VALUES (@usuario,@peso,@estatura,@imc,@fecha)";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@estatura", estatura);
                        cmd.Parameters.AddWithValue("@imc", imc);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Los datos fueron guardados correctamente.", "AVISO");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }


                }
                fMenu fFormMenu = new fMenu();
                fFormMenu.tbxNombreM.Text = this.tbxNombreC.Text;
                fFormMenu.tbxEdadM.Text = this.tbxEdadC.Text;
                fFormMenu.tbxUsuarioM.Text = this.tbxUsuarioC.Text;
                fFormMenu.Show();
                this.Hide();
            }
        }
    }
}
