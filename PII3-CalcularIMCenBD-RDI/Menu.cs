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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularM_Click(object sender, EventArgs e)
        {
            fCalcularIMC fFormIMC = new fCalcularIMC(); 

            fFormIMC.tbxNombreC.Text = this.tbxNombreM.Text;
            fFormIMC.tbxEdadC.Text =this.tbxEdadM.Text;
            fFormIMC.tbxUsuarioC.Text =this.tbxUsuarioM.Text;
            fFormIMC.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizarM_Click(object sender, EventArgs e)
        {
            fActualizarDatos fFormActualizar = new fActualizarDatos();

            fFormActualizar.tbxNombreA.Text = this.tbxNombreM.Text;
            fFormActualizar.tbxEdadA.Text= this.tbxEdadM.Text;
            fFormActualizar.tbxUsrA.Text = this.tbxUsuarioM.Text;

            string username, pass, nombreusuario, edadusuario, correousuario;
            username = this.tbxUsuarioM.Text;

            MySqlConnection con = new MySqlConnection("server=localhost;database=IMC;user=root;password=;");

            try
            {
                con.Open();
            }
            catch (MySqlException ex) { MessageBox.Show("Error" + ex.ToString()); }

            string sql = "SELECT nombre,edad,correo,usr,pdw FROM usuarios WHERE usr ='" + username + "'";
            MySqlCommand comando = new MySqlCommand(sql,con);
            MySqlDataReader read = comando.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Bienbenido" + username);

                fMenu fFormMenu = new fMenu();
                nombreusuario = read["nombre"].ToString();
                edadusuario = read["edad"].ToString();
                correousuario = read["correo"].ToString();
                pass = read["pwd"].ToString();

                fFormActualizar.tbxNombreA.Text = nombreusuario;
                fFormActualizar.tbxEdadA.Text = edadusuario;
                fFormActualizar.tbxCorreoA.Text = correousuario;
                fFormActualizar.tbxUsrA.Text = username;
                fFormActualizar.tbxPwd1A.Text = pass;
                fFormActualizar.tbxPwd2A.Text = pass;
                fFormActualizar.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("No existe el usuario " + username);
            }

        }

        private void btnHistorialM_Click(object sender, EventArgs e)
        {
            fHistoriaIMC fFormHIMC = new fHistoriaIMC();

            fFormHIMC.tbxNombreH.Text = this.tbxNombreM.Text;
            fFormHIMC.tbxEdadH.Text = this.tbxEdadM.Text;
            fFormHIMC.tbxUsrH.Text = this.tbxUsuarioM.Text;
            fFormHIMC.Show();
            this.Hide();
        }
    }
}
