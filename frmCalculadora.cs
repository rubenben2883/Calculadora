using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        double Valor1 = 0;
        double Valor2 = 0;
        double resultado = 0;

        //string Operacion = "NA";

        private string _operacion;

        public string Operacion
        {
            get { return _operacion; }
            
            set
            {
                _operacion = value;
                // Modificar el texto del Label con el nuevo valor de Operacion
                lblOperacionActiva.Text = _operacion;
            }
        }





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
            //ver si alguna de la tecla es la +,-, multiplicaro o dividor
            switch (e.KeyChar.ToString())
            {
                case "+":
                    {
                        btnMas_Click(null, null);
                    }
                    break;
                case "-":
                    {
                        btnMenos_Click(null, null);
                    }
                    break;
                case "*":
                    {
                        btnMultiplica_Click(null, null);
                    }
                    break;
                case "/":
                    {
                        btnDidive_Click(null, null); 
                    }
                    break;
               
            }
            if(e.KeyChar==13) //vemos si es usuario presiono ENTER --deberiamos intentar dale el resultado de las operacion
            {
                btnIgual_Click(null, null);
            }

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
            //22marzo25--ahora ademas permite +,-,*,/-- pues se quiere usar el teclado fisico
            // Permitir solo números, el punto decimal, teclas de control, suma, resta, multiplicación y división
            //if (!char.IsDigit(e.KeyChar) &&
            //    e.KeyChar != '.' &&
            //    e.KeyChar != '+' &&
            //    e.KeyChar != '-' &&
            //    e.KeyChar != '*' &&
            //    e.KeyChar != '/' &&
            //    !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
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

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.Length > 0)
            {
                if (Convert.ToDouble(txtResultados.Text) < 0)
                {
                    MessageBox.Show("No introducido un valor para realizar la operacion de suma");
                }
                else
                {
                    Valor1 = Convert.ToDouble(txtResultados.Text);
                    txtResultados.Text = "";
                    Operacion = "+";
                    //lblOperacionActiva.Text = Operacion;
                }
            }
            else
                MessageBox.Show("No introducido un valor para realizar la operacion de suma");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.Length > 0)
            {
                if (Convert.ToDouble(txtResultados.Text) < 0)
                {
                    MessageBox.Show("No introducido un valor para concretar la operacion");
                }
                else
                {
                    Valor2 = Convert.ToDouble(txtResultados.Text);
                    switch (this.Operacion)
                    {
                        case "+":
                            {
                                resultado= Valor1 + Valor2;
                            }
                            break;
                        case "-":
                            {
                                resultado=Valor1- Valor2;
                            }
                            break;
                        case "*":
                            {
                                resultado = Valor1 * Valor2; 
                            }
                            break;
                        case "/":
                            {
                                resultado= Valor1 / Valor2;
                            }
                            break;
            
                    }
                    txtResultados.Text = resultado.ToString();
                    Operacion = "NA";
                }
            }
            else
                MessageBox.Show("No haz intriducido el segunfo valor para hacer la operacion");
        }

        private void btnDidive_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.Length > 0)
            {
                if (Convert.ToDouble(txtResultados.Text) < 0)
                {
                    MessageBox.Show("No introducido un valor para realizar la operacion de división");
                }
                else
                {
                    Valor1 = Convert.ToDouble(txtResultados.Text);
                    txtResultados.Text = "";
                    Operacion = "/";
                    //lblOperacionActiva.Text = Operacion;
                }
            }
            else
                MessageBox.Show("No introducido un valor para realizar la operacion de suma");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Valor1 = 0; 
            Valor2=0;
            Operacion = "NA";
            txtResultados.Text = "";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.Length > 0)
            {
                if (Convert.ToDouble(txtResultados.Text) < 0)
                {
                    MessageBox.Show("No introducido un valor para realizar la operacion de resta");
                }
                else
                {
                    Valor1 = Convert.ToDouble(txtResultados.Text);
                    txtResultados.Text = "";
                    Operacion = "-";
                    
                }
            }
            else
                MessageBox.Show("No introducido un valor para realizar la operacion de resta");
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.Length > 0)
            {
                if (Convert.ToDouble(txtResultados.Text) < 0)
                {
                    MessageBox.Show("No introducido un valor para realizar la operacion de multiplicacion");
                }
                else
                {
                    Valor1 = Convert.ToDouble(txtResultados.Text);
                    txtResultados.Text = "";
                    Operacion = "*";

                }
            }
            else
                MessageBox.Show("No introducido un valor para realizar la operacion de multiplicacion");
        }

        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTeclaPresionada.Text=(e.KeyChar.ToString()); //mostramos que tecla se presiono

            //txtResultados.Text += e.KeyChar.ToString();
            //txtResultados_KeyPress(sender, e); //se la mandamos a la caja de texto aunque esta no tenga el foco

            if (txtResultados.Focused) return; // Evitar duplicar el evento si el TextBox ya tiene el foco

            txtResultados.Focus(); // Dar el foco al TextBox
            SendKeys.Send(e.KeyChar.ToString()); // Enviar la tecla presionada al TextBox
            
        }
    }
}
