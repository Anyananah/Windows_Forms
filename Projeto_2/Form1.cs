using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Forms_Saudacao : Form
    {
        public Forms_Saudacao()
        {
            InitializeComponent();
        }

        private void Button_Exibir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Olá {TextBox_Name.text}");
            string nome = TextBox_Name.Text;

            MessageBox.Show($"Olá {nome}",
                "Resposta",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                 );
        }
    }
}
