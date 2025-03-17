namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnDidive = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.lblOperacionActiva = new System.Windows.Forms.Label();
            this.txtMem1 = new System.Windows.Forms.TextBox();
            this.txtMem2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarContro = new System.Windows.Forms.Button();
            this.textBoxSoloNumeros1 = new ControlesPersonalizadosMySoft.TextBoxSoloNumeros();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultados.Location = new System.Drawing.Point(12, 22);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(417, 45);
            this.txtResultados.TabIndex = 0;
            this.txtResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultados_KeyPress);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 118);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 60);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(114, 118);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 60);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(227, 118);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 60);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.concatenarTextAResultado);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(227, 194);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 60);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.concatenarTextAResultado);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(114, 194);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 60);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.concatenarTextAResultado);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 194);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 60);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.concatenarTextAResultado);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(227, 274);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 60);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.concatenarTextAResultado);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(114, 274);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 60);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.concatenarTextAResultado);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 274);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 60);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.concatenarTextAResultado);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplica.Location = new System.Drawing.Point(349, 250);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(80, 60);
            this.btnMultiplica.TabIndex = 12;
            this.btnMultiplica.Text = "*";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(349, 184);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(80, 60);
            this.btnMenos.TabIndex = 11;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnMas
            // 
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(349, 118);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(80, 60);
            this.btnMas.TabIndex = 10;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            // 
            // btnDidive
            // 
            this.btnDidive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDidive.Location = new System.Drawing.Point(349, 316);
            this.btnDidive.Name = "btnDidive";
            this.btnDidive.Size = new System.Drawing.Size(80, 60);
            this.btnDidive.TabIndex = 13;
            this.btnDidive.Text = "/";
            this.btnDidive.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(349, 386);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(80, 60);
            this.btnIgual.TabIndex = 14;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(114, 386);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(80, 60);
            this.btnCero.TabIndex = 15;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.concatenarTextAResultado);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(227, 386);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(80, 60);
            this.btnPunto.TabIndex = 16;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceso.Location = new System.Drawing.Point(227, 452);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(202, 60);
            this.btnRetroceso.TabIndex = 18;
            this.btnRetroceso.Text = "<<<";
            this.btnRetroceso.UseVisualStyleBackColor = true;
            this.btnRetroceso.Click += new System.EventHandler(this.btnRetroceso_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(114, 452);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(80, 60);
            this.btnCE.TabIndex = 17;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // lblOperacionActiva
            // 
            this.lblOperacionActiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperacionActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacionActiva.ForeColor = System.Drawing.Color.Tomato;
            this.lblOperacionActiva.Location = new System.Drawing.Point(349, 74);
            this.lblOperacionActiva.Name = "lblOperacionActiva";
            this.lblOperacionActiva.Size = new System.Drawing.Size(80, 41);
            this.lblOperacionActiva.TabIndex = 19;
            this.lblOperacionActiva.Text = "Na";
            this.lblOperacionActiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMem1
            // 
            this.txtMem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMem1.Location = new System.Drawing.Point(562, 228);
            this.txtMem1.Name = "txtMem1";
            this.txtMem1.Size = new System.Drawing.Size(318, 45);
            this.txtMem1.TabIndex = 20;
            this.txtMem1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMem1_KeyPress);
            // 
            // txtMem2
            // 
            this.txtMem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMem2.Location = new System.Drawing.Point(562, 298);
            this.txtMem2.Name = "txtMem2";
            this.txtMem2.Size = new System.Drawing.Size(318, 45);
            this.txtMem2.TabIndex = 21;
            this.txtMem2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMem2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Solo numeros";
            // 
            // btnAgregarContro
            // 
            this.btnAgregarContro.Location = new System.Drawing.Point(718, 442);
            this.btnAgregarContro.Name = "btnAgregarContro";
            this.btnAgregarContro.Size = new System.Drawing.Size(162, 49);
            this.btnAgregarContro.TabIndex = 23;
            this.btnAgregarContro.Text = "Agregar text solo numeora";
            this.btnAgregarContro.UseVisualStyleBackColor = true;
            this.btnAgregarContro.Click += new System.EventHandler(this.btnAgregarContro_Click);
            // 
            // textBoxSoloNumeros1
            // 
            this.textBoxSoloNumeros1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoloNumeros1.Location = new System.Drawing.Point(562, 364);
            this.textBoxSoloNumeros1.Name = "textBoxSoloNumeros1";
            this.textBoxSoloNumeros1.Size = new System.Drawing.Size(318, 60);
            this.textBoxSoloNumeros1.TabIndex = 24;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(911, 515);
            this.Controls.Add(this.textBoxSoloNumeros1);
            this.Controls.Add(this.btnAgregarContro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMem2);
            this.Controls.Add(this.txtMem1);
            this.Controls.Add(this.lblOperacionActiva);
            this.Controls.Add(this.btnRetroceso);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDidive);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCalculadora";
            this.Text = "Mi Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnDidive;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnRetroceso;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Label lblOperacionActiva;
        private System.Windows.Forms.TextBox txtMem1;
        private System.Windows.Forms.TextBox txtMem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarContro;
        private ControlesPersonalizadosMySoft.TextBoxSoloNumeros textBoxSoloNumeros1;
        //private Calculadora.TextBoxSoloNumeros textBoxSoloNumeros1;
    }
}

