using Projeto_8.br.com.projeto.DAO;
using Projeto_8.br.com.projeto.MODEL;
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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();

            //PRIMEIRO PASSO - RECEBER DADOS

            obj.Nome = textBox_nome.Text;
            obj.RG = maskedTextBox_rg.Text;
            obj.CPF = maskedTextBox_cpf.Text;
            obj.Email = textBox_email.Text;
            obj.Senha = textBox_senha.Text;
            obj.Cargo = comboBox_cargo.Text;
            obj.Nivel_acesso = comboBox_nivel.Text;
            obj.Telefone = maskedBox_tel.Text;
            obj.Celular = maskedTextBox_cel.Text;
            obj.CEP = maskedTextBox_cep.Text;
            obj.Endereco = textBox_endereco.Text;
            obj.Numero = int.Parse(textBox_n.Text);
            obj.Complemento = textBox_complemento.Text;
            obj.Bairro = textBox_bairro.Text;
            obj.Cidade = textBox_cidade.Text;
            obj.Estado = comboBox_estado.Text;

            //PASSO DOIS - CRIAR O OBJETO E CHAMAR
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            //dg_consulta_funcionario.DataSource = dao.listarFuncionarios();
        }
    }
}
