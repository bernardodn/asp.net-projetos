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
    
    public partial class Calculadora : Form
    {
        int valor1;
        int valor2;
        int resultado;
        string operacao;


        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            operacao = "+";
            valor1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            operacao = "-";
            valor1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            operacao = "*";
            valor1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            operacao = "/";
            valor1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(txtDisplay.Text);

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    txtDisplay.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    txtDisplay.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    txtDisplay.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    txtDisplay.Text = resultado.ToString();
                    break;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            resultado = '0';
        }
    }
}
