using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculadora
{
    public class AyudanteIntefaz
    {
        /// <summary>
        /// Permite escribir solo numero en una caja de texto y el punto decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox caja = (TextBox)sender;
            // Verifica si la tecla presionada es un punto decimal
            if (e.KeyChar == '.' && caja.Text.Contains("."))
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
    }
}
