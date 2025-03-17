using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultados.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultados.Text += "2";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.IndexOf(".") == -1)
                txtResultados.Text += ".";
            else
                MessageBox.Show("No se puede usar el . decimal mas 1 de 1 veces", "Sorry", MessageBoxButtons.OK);
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            if(txtResultados.Text !="")
            {
                txtResultados.Text = txtResultados.Text.Substring(0, txtResultados.Text.Length - 1);
            }
        }

        private void concatenarTextAResultado(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtResultados.Text += button.Text;
        }

        private void txtResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un punto decimal
            if (e.KeyChar == '.' && txtResultados.Text.Contains("."))
            {
                // Si ya hay un punto decimal, cancela la entrada
                e.Handled = true;
            }

            // Opcional: Permitir solo números, el punto decimal y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMem1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AyudanteIntefaz.SoloNumeros(sender, e);
        }

        private void txtMem2_KeyPress(object sender, KeyPressEventArgs e)
        {
            AyudanteIntefaz.SoloNumeros(sender, e);
        }

        private void btnAgregarContro_Click(object sender, EventArgs e)
        {
            

        }
    }
}
