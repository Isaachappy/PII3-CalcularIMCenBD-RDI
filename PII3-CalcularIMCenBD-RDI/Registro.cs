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
    public partial class fRegistro : Form
    {
        public fRegistro()
        {
            InitializeComponent();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
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
            bool v = tbxNombre.Focus();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
