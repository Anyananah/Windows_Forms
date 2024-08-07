using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3
{
    public partial class Forms_Calculadora : Form
    {
        public Forms_Calculadora()
        {
            InitializeComponent();
        }
        private void Text_IMC_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            peso = double.Parse(TextBox_Peso.Text);
            altura = Convert.ToDouble(TextBox_Altura.Text);

            imc = peso / (altura * altura);

            Label_ResultIMC.Text = imc.ToString();

            if(imc < 19)
            {
                Label_ResultSIT.Text = "Abaixo do peso";
            }else if (imc >= 19 && imc < 25)
            {
                Label_ResultSIT.Text = "Peso Ideal";
            }else
            {
                Label_ResultSIT.Text = "Acima do Peso";
            }
        }
        private void Button_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes) ;
            this.Close();
        }

        private void TextBox_Altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Situacao_Click(object sender, EventArgs e)
        {

        }


        private void Label_ResultIMC_Click(object sender, EventArgs e)
        {

        }

        private void Label_ResultSIT_Click(object sender, EventArgs e)
        {

        }
    }
}
