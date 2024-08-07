using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_7
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string nome = textBox_nome.Text;
            string senha = textBox_senha.Text;

            if (CadastroUsuario.Login(nome, senha))
            {
                Close();
            } else
            {
                MessageBox.Show("Acesso NEGADO!");
                textBox_nome.Text = "";
                textBox_senha.Text = "";
                textBox_nome.Focus();
                Close();
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

        private void textBox_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
