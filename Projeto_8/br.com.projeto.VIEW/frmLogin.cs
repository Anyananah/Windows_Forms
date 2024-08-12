using Projeto_8.br.com.projeto.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.VIEW
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string email = textBox_nome.Text;
            string senha = textBox_senha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            if(dao.efetuarLogin(email, senha))
            {
                frmMenu telaMenu = new frmMenu();
                telaMenu.Show();
                this.Hide();
            }
        }
    }
}
