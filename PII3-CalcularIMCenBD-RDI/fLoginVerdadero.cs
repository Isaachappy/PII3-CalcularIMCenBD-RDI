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
    public partial class fLoginVerdadero : Form
    {
        public fLoginVerdadero()
        {
            InitializeComponent();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            fLoginUsuarios miform2 = new fLoginUsuarios();
            this.Hide();
            miform2.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            fCalculo miform2 = new fCalculo();
            this.Hide();
            miform2.Show();
        }
    }
}
