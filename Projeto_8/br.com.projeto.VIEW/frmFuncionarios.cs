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

            dg_consulta_funcionario.DataSource = dao.listarFuncionario();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dg_consulta_funcionario.DataSource = dao.listarFuncionario();
        }

        private void dg_consulta_funcionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox_codigo.Text = dg_consulta_funcionario.CurrentRow.Cells[0].Value.ToString();
            textBox_nome.Text = dg_consulta_funcionario.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox_rg.Text = dg_consulta_funcionario.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_cpf.Text = dg_consulta_funcionario.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dg_consulta_funcionario.CurrentRow.Cells[4].Value.ToString();
            textBox_senha.Text = dg_consulta_funcionario.CurrentRow.Cells[5].Value.ToString();
            comboBox_cargo.Text = dg_consulta_funcionario.CurrentRow.Cells[6].Value.ToString();
            comboBox_nivel.Text = dg_consulta_funcionario.CurrentRow.Cells[7].Value.ToString();
            maskedBox_tel.Text = dg_consulta_funcionario.CurrentRow.Cells[8].Value.ToString();
            maskedTextBox_cel.Text = dg_consulta_funcionario.CurrentRow.Cells[9].Value.ToString();
            maskedTextBox_cep.Text = dg_consulta_funcionario.CurrentRow.Cells[10].Value.ToString();
            textBox_endereco.Text = dg_consulta_funcionario.CurrentRow.Cells[11].Value.ToString();
            textBox_n.Text = dg_consulta_funcionario.CurrentRow.Cells[12].Value.ToString();
            textBox_complemento.Text = dg_consulta_funcionario.CurrentRow.Cells[13].Value.ToString();
            textBox_bairro.Text = dg_consulta_funcionario.CurrentRow.Cells[14].Value.ToString();
            textBox_cidade.Text = dg_consulta_funcionario.CurrentRow.Cells[15].Value.ToString();
            comboBox_estado.Text = dg_consulta_funcionario.CurrentRow.Cells[16].Value.ToString();

            //ALTERAR GUIA PARA DADOS PESSOAIS
            tab_funcionarios.SelectedTab = tabPage2;
        }

        private void button5_Click(object sender, EventArgs e)
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

            obj.Codigo = int.Parse(textBox_codigo.Text);

            //PASSO DOIS - CRIAR O OBJETO E CHAMAR
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);

            dg_consulta_funcionario.DataSource = dao.listarFuncionario();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();

            //PRIMEIRO PASSO - RECEBER DADOS
            obj.Codigo = int.Parse(textBox_codigo.Text);

            //PASSO DOIS - CRIAR O OBJETO E CHAMAR
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.excluirFuncionario(obj);

            //RECARREGAR DATAGRID
            dg_consulta_funcionario.DataSource = dao.listarFuncionario();

            //RETORNA PARA PESQUISAR
            tab_funcionarios.SelectedTab = tabPage2;

        }
    }
}
