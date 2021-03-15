using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculator()
        {
            InitializeComponent();

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0"; // Adicionar a string e Concatenar ela        
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1"; 
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2"; 
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3"; 
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                // Cultereinfo é para verificar numeros com ,
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperation.Text = "+";
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperation.Text = "-";
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") 
            { 
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperation.Text = "X";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lblOperation.Text = "/";
            }
            
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                operacao = "PORCENTAGEM";
                lblOperation.Text = "%";
            }
            
        }
        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
      
            if (operacao == "SOMA")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(valor1 + valor2);
                operacao = "";
                lblOperation.Text = "";
            }
            else if (operacao == "SUBTRACAO")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(valor1 - valor2);
                operacao = "";
                lblOperation.Text = "";
            }
            else if (operacao == "MULTIPLICACAO")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(valor1 * valor2);
                operacao = "";
                lblOperation.Text = "";
            }
            else if (operacao == "DIVISAO") 
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(valor1 / valor2);
                operacao = "";
                lblOperation.Text = "";
            }else if (operacao == "PORCENTAGEM")
            {
                txtResultado.Text = Convert.ToString(valor1 / 100);
                operacao = "";
                lblOperation.Text = "";
            }
        }

        
    }
}
