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
using static System.Net.WebRequestMethods;

namespace Projeto_8.br.com.projeto.VIEW
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {       
            Clientes obj = new Clientes();

            //PRIMEIRO PASSO - RECEBER DADOS

            obj.Nome = textBox_nome.Text;
            obj.RG  = maskedTextBox_rg.Text;
            obj.CPF  = maskedTextBox_cpf.Text;
            obj.Email = textBox_email.Text;
            obj.Telefone  = maskedBox_tel.Text;
            obj.Celular  = maskedTextBox_cel.Text;
            obj.CEP  = maskedTextBox_cep.Text;
            obj.Endereco  = textBox_endereco.Text;
            obj.Numero  = int.Parse(textBox_n.Text);
            obj.Complemento = textBox_complemento.Text;
            obj.Bairro = textBox_bairro.Text;
            obj.Cidade = textBox_cidade.Text;
            obj.Estado = comboBox_estado.Text;

            //PASSO DOIS - CRIAR O OBJETO E CHAMAR
             ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            dg_consulta.DataSource = dao.listarCliente();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            dg_consulta.DataSource = dao.listarCliente();
        }

        private void comboBox_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dg_consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //PEGAR DADOS
            textBox_codigo.Text = dg_consulta.CurrentRow.Cells[0].Value.ToString();
            textBox_nome.Text = dg_consulta.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox_rg.Text = dg_consulta.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_cpf.Text = dg_consulta.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dg_consulta.CurrentRow.Cells[4].Value.ToString();
            maskedBox_tel.Text = dg_consulta.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox_cel.Text = dg_consulta.CurrentRow.Cells[6].Value.ToString();
            maskedTextBox_cep.Text = dg_consulta.CurrentRow.Cells[7].Value.ToString();
            textBox_endereco.Text = dg_consulta.CurrentRow.Cells[8].Value.ToString();
            textBox_n.Text = dg_consulta.CurrentRow.Cells[9].Value.ToString();
            textBox_complemento.Text = dg_consulta.CurrentRow.Cells[10].Value.ToString();
            textBox_bairro.Text = dg_consulta.CurrentRow.Cells[11].Value.ToString();
            textBox_cidade.Text = dg_consulta.CurrentRow.Cells[12].Value.ToString();
            comboBox_estado.Text = dg_consulta.CurrentRow.Cells[13].Value.ToString();

            //ALTERAR GUIA PARA DADOS PESSOAIS
            tab_clientes.SelectedTab = page_dadospessoais;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //PRIMEIRO PASSO - RECEBER DADOS

            obj.Nome = textBox_nome.Text;
            obj.RG = maskedTextBox_rg.Text;
            obj.CPF = maskedTextBox_cpf.Text;
            obj.Email = textBox_email.Text;
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
            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            dg_consulta.DataSource = dao.listarCliente();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //PRIMEIRO PASSO - RECEBER DADOS
            obj.Codigo = int.Parse(textBox_codigo.Text);

            //PASSO DOIS - CRIAR O OBJETO E CHAMAR
            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);

            //RECARREGAR DATAGRID
            dg_consulta.DataSource = dao.listarCliente();

            //RETORNA PARA PESQUISAR
            tab_clientes.SelectedTab = tabPage2;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nome = Text_NomeConsulta.Text;

            ClienteDAO dao = new ClienteDAO();

            dg_consulta.DataSource = dao.BuscarClientePorNome(nome);

            if(dg_consulta.Rows.Count == 0)
            {
                dg_consulta.DataSource = dao.listarCliente();
            }
        }

        private void Text_NomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + Text_NomeConsulta.Text + "%";

           ClienteDAO dao = new ClienteDAO();

           dg_consulta.DataSource = dao.BuscarClienteListando(nome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string cep = maskedTextBox_cep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                textBox_endereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                textBox_bairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                textBox_cidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                textBox_complemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                comboBox_estado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor verifique!");
            }
        }
    }
}
