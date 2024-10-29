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
    public partial class fCalculo : Form
    {
        public fCalculo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fLoginVerdadero miform2 = new fLoginVerdadero();
            this.Hide();
            miform2.Show();
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Altura, Peso, IMC;
            string errores = "";

            Altura = Convert.ToDouble(tbxAltura.Text);
            Peso = Convert.ToDouble(tbxPeso.Text);


            if (Altura <= 0)
            {
                errores += "La altura debe ser un número positivo.\n";
            }

            if (Peso <= 0)
            {
                errores += "El peso debe ser un número positivo.\n";
            }

            if (Altura < 1)
            {
                errores += "La altura debe ser un número mayor a 1.\n";
            }

            if (Peso < 1)
            {
                errores += "El peso debe ser un número mayor a 1.\n";
            }



            if (Altura > 3.0)
            {
                errores += "La altura no puede ser mayor de 3 metros.\n";
            }

            if (Peso > 500.0)
            {
                errores += "El peso no puede ser mayor de 500  kg.\n";
            }


            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores);
                return;
            }

            IMC = Peso / (Altura * Altura);
            tbxResultadoIMC.Text = IMC.ToString("F2");

        }
    }
}
