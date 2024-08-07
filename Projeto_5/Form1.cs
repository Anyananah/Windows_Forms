using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Valor_1_Click(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?",
                  "Confirmação",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes);
                    this.Close();
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_V1.Clear();
            textBox_V2.Clear();
            textBox_Resultado.Clear();
        }

        private void button_mais_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(textBox_V1.Text);
            valor2 = double.Parse(textBox_V2.Text);

            resultado = valor1 + valor2;

            textBox_Resultado.Text = resultado.ToString(); 
        }

        private void button_menos_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(textBox_V1.Text);
            valor2 = double.Parse(textBox_V2.Text);

            resultado = valor1 - valor2;

            textBox_Resultado.Text = resultado.ToString();
        }

        private void button_divisao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(textBox_V1.Text);
            valor2 = double.Parse(textBox_V2.Text);

            resultado = valor1 / valor2;

            textBox_Resultado.Text = resultado.ToString();
        }

        private void button_multiplicacao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(textBox_V1.Text);
            valor2 = double.Parse(textBox_V2.Text);

            resultado = valor1 * valor2;

            textBox_Resultado.Text = resultado.ToString();
        }
    }
}
