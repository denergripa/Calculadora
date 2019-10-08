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
    public partial class Form1 : Form
    {
        double valor1;
        double resultado;
        string operador;
        double valor2;

        public Form1()

            
        {
            InitializeComponent();
        }

        private void Num0_Click(object sender, EventArgs e)
        {
           // txtDisplay.Text = "0"; seria o Nome da Label, nome do componente, que eu ou referenciar depois
            txtDisplay.Text = txtDisplay.Text + num0.Text;
            // num0.Text = nome do campo que eu coloquei la no botaozin
        }
        private void Num1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num1.Text;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num2.Text;
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num3.Text;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num4.Text;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num5.Text;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num6.Text;
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num7.Text;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num8.Text;
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + num9.Text;
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            // o travesão significa OU, sendo assim compara a variavel com + || OU - OU dividir etc.
            if (operador == "+" || operador == "/" || operador == "-")
            {
                operador = "*"; //Alimentando variável
                txtHist.Text = " * " + valor1; 

            }
            else
            {
                txtHist.Text = txtDisplay.Text + " * ";
                valor1 = Convert.ToDouble(txtDisplay.Text); 
                txtDisplay.Text = "";
                operador = "*";
            }
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            if (operador == "+" || operador == "*" || operador == "-")
            {
                operador = "/";
                txtHist.Text = " / " + valor1;
            }
            else
            {
                txtHist.Text = txtDisplay.Text + " / ";
                valor1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                operador = "/";
            }
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            if (operador == "/" || operador == "*" || operador == "-")
            {
                operador = "+";
                txtHist.Text = " + " + valor1;
            }
            else
            {
                txtHist.Text = txtDisplay.Text + " + "; // se eu mudar a ordem, vou cagar no pal
                valor1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";  // se eu mudar a ordem, vou cagar no pal
                operador = "+"; // somente uma string, que sua estrelha não brilha
            }
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            if (operador == "/" || operador == "*" || operador == "+")
            {
                operador = "-";
                txtHist.Text = " - " + valor1;
            }
            else
            {
                txtHist.Text = txtDisplay.Text + " - ";
                valor1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                operador = "-";
            }
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            //txtDisplay.Text = (txtHist.Text + operador + txtDisplay.Text); FAIL
          
            txtHist.Text = txtDisplay.Text + txtHist.Text;
            valor2 = Convert.ToDouble(txtDisplay.Text); // Convert To double é pra transformar o caracter em um numero

            if (operador == "+")
            {
                resultado = (valor1 + valor2);
                txtDisplay.Text = Convert.ToString(resultado);
                valor1 = resultado;

            }

            if (operador == "-")
            {
                resultado = (valor1 - valor2);
                txtDisplay.Text = Convert.ToString(resultado);
                valor1 = resultado;

            }

            if (operador == "*")
            {
                resultado = (valor1 * valor2);
                txtDisplay.Text = Convert.ToString(resultado);
                valor1 = resultado;

            }
            if (operador == "/")

            {
                txtHist.Text = "Divisão por zero";
                txtDisplay.Text = "0";


            }
            else
            {
                resultado = (valor1 / valor2);
                txtDisplay.Text = Convert.ToString(resultado);
                valor1 = resultado;
            }
            operador = "";
        }

        private void Zerar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            txtHist.Text = "";
        }
    }
}
