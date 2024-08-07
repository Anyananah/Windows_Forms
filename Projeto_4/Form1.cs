using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button_Clean_Click(object sender, EventArgs e)
        {
            //Limpar
            TextBox_Nome.Clear();
            ComboBox_Destino.Text = string.Empty;
            RadioButton_aviao.Checked = false;
            RadioButton_bus.Checked = false;
            Date_Time.Value = DateTime.Now;
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            //Confirmar
            if(TextBox_Nome.Text.Length == 0)
            {
                MessageBox.Show("Digite seu nome!");
                TextBox_Nome.Focus();
            }
            if(ComboBox_Destino.Text == "")
            {
                MessageBox.Show("Destino não selecionado!");
                ComboBox_Destino.Focus();
            }
            if(RadioButton_aviao.Checked == false && RadioButton_bus.Checked == false)
            {
                MessageBox.Show("Meio de Transporte não selecionado!");
                RadioButton_aviao.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(640, 140);
            GroupBox_Valor.Visible = false;
        }

        private void Button_Calc_Click(object sender, EventArgs e)
        {
            //Calcular
            double Label_GastoTransp, Label_GastoDestino, Label_VTotal;

            switch(ComboBox_Destino.Text.ToUpper())
            {
                case "SP":
                    Label_GastoDestino = 1000;
                    break;
                case "RJ":
                    Label_GastoDestino = 1500;
                    break;
                case "ES":
                    Label_GastoDestino = 2000;
                    break;
                case "GO":
                    Label_GastoDestino = 2500;
                    break;
                case "SC":
                    Label_GastoDestino = 3000;
                    break;
                default:
                    Label_GastoDestino = 0;
                    break;
            }

            //Meio de Transporte

            if(RadioButton_aviao.Checked == true)
            {
                Label_GastoTransp = 100;
            }
            else
            {
                Label_GastoTransp = 30;
            }

            //Calculo Valor Total

            Label_VTotal = Label_GastoTransp + Label_GastoDestino;

            //Redimensionamento

            this.ClientSize = new System.Drawing.Size(640, 300);
            GroupBox_Valor.Visible = true;

            //Exibir

            Label_Money.Text = Label_GastoDestino.ToString("C2");
            Label_MoneyD.Text = Label_GastoTransp.ToString("C2");
            Label_MoneyT.Text = Label_VTotal.ToString("C2");
        }

        private void Button_Sair_Click(object sender, EventArgs e)
        {

        }
    }
}
