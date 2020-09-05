using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Definição das variáveis
            double num1, num2, resultado;
            // Conversão de string para double
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            // Cálculo dos números
            resultado = num1 + num2;
            // mostrando o resultado na tela
            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            // Definição das variáveis
            double num1, num2, resultado;
            // Conversão de string para double
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            // Cálculo dos números
            resultado = num1 - num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            // Definição das variáveis
            double num1, num2, resultado;
            // Conversão de string para double
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            // Cálculo dos números
            resultado = num1 / num2;
            // mostrando o resultado na tela
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // Definição das variáveis
            double num1, num2, resultado;
            // Conversão de string para double
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            // Cálculo dos números
            resultado = num1 * num2;
            // mostrando o resultado na tela
            txtResultado.Text = resultado.ToString();
        }
    }
}
