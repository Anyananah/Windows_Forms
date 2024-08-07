using MySql.Data.MySqlClient;
using Projeto_8.br.com.projeto.CONEXAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.DAO
{
    internal class ClienteDAO
    {
        #region Conexão
        private MySqlConnection conexao;
        
        public ClienteDAO()
        {
            conexao = new Conexao().GetConnection();
        }
        #endregion

        #region Cadastrar
        public void cadastrarCliente(Clientes obj)
        {
            try
            {
                //PRIMEIRO PASSO - DEFINIR COMANDO SQL
                string sql = @"INSERT INTO tb_clientes (nome, rg, cpf, email,
                telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                VALUES(@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco,
                @numero, @complemento, @bairro, @cidade, @estado)";

                //SEGUNDO PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.Nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.RG);
                executarcmd.Parameters.AddWithValue("@cpf", obj.CPF);
                executarcmd.Parameters.AddWithValue("@email", obj.Email);
                executarcmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.Celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.CEP);
                executarcmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executarcmd.Parameters.AddWithValue("@numero", obj.Numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.Estado);

                //TERCEIRO PASSO - ABRIR CONEXÃO E EXECUTAR
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com Sucesso!");

                //QUARTO PASSO - FECHAR CONEXÃO
                conexao.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show( "Ocorreu um erro!" + erro);
            }
        }
        #endregion

        #region Listar

        public DataTable listarCliente()
        {
            try
            {
                //PRIMEIRO PASSO - INSTANCIAR DATATABLE
                DataTable tabelaCliente = new DataTable();

                //SEGUNDO PASSO - DEFINIR COMANDO SQL
                string sql = @"SELECT * FROM tb_clientes";

                //TERCEIRO PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                //QUARTO PASSO - ABRIR CONEXÃO E EXECUTAR O COMANDO SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                //QUINTO PASSO - PREENCHER OS DADOS DO DATATABLE
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaCliente); 

                //SEXTO PASSO - FECHAR CONEXÃO
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro);
                return null;
            }
        }

        #endregion

        #region Alterar
        public void alterarCliente(Clientes obj)
        {
            try
            {
                //PRIMEIRO PASSO - DEFINIR COMANDO SQL
                string sql = @"UPDATE tb_clientes SET nome=@nome, rg=@rg, cpf=@cpf, email=@email,
                telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero,
                complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado WHERE id=@id";

                //SEGUNDO PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@nome", obj.Nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.RG);
                executarcmd.Parameters.AddWithValue("@cpf", obj.CPF);

                executarcmd.Parameters.AddWithValue("@email", obj.Email);
                executarcmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.Celular);

                executarcmd.Parameters.AddWithValue("@cep", obj.CEP);
                executarcmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executarcmd.Parameters.AddWithValue("@numero", obj.Numero);

                executarcmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.Estado);

                executarcmd.Parameters.AddWithValue("@id", obj.Codigo);

                //TERCEIRO PASSO - ABRIR CONEXÃO E EXECUTAR
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com Sucesso!");

                //QUARTO PASSO - FECHAR CONEXÃO
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro);
            }
        }
        #endregion

        #region Excluir

        public void excluirCliente(Clientes obj)
        {
            try
            {
                //PRIMEIRO PASSO - DEFINIR COMANDO SQL
                string sql = @"DELETE FROM tb_clientes";

                //SEGUNDO PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@id", obj.Codigo);

                //TERCEIRO PASSO - ABRIR CONEXÃO E EXECUTAR
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente removido com Sucesso!");

                //QUARTO PASSO - FECHAR CONEXÃO
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro);
            }
        }

        #endregion

        #region Buscar Cliente - Por Nome

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //PRIMEIRO PASSO - INSTANCIAR DATATABLE
                DataTable tabelaCliente = new DataTable();

                //SEGUNDO PASSO - DEFINIR COMANDO SQL
                string sql = @"SELECT * FROM tb_clientes WHERE nome = @nome";

                //TERCEIRO PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@nome", nome);

                //QUARTO PASSO - ABRIR CONEXÃO E EXECUTAR O COMANDO SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                //QUINTO PASSO - PREENCHER OS DADOS DO DATATABLE
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaCliente);

                //SEXTO PASSO - FECHAR CONEXÃO
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro);
                return null;
            }
        }


        #endregion

        #region Buscar Cliente - Listando

        public DataTable BuscarClienteListando(string nome)
        {
            try
            {
                //PRIMEIRO PASSO - INSTANCIAR DATATABLE
                DataTable tabelaCliente = new DataTable();

                //SEGUNDO PASSO - DEFINIR COMANDO SQL
                string sql = @"SELECT * FROM tb_clientes WHERE nome LIKE @nome";

                //TERCEIRO PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@nome", nome);

                //QUARTO PASSO - ABRIR CONEXÃO E EXECUTAR O COMANDO SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                //QUINTO PASSO - PREENCHER OS DADOS DO DATATABLE
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaCliente);

                //SEXTO PASSO - FECHAR CONEXÃO
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro);
                return null;
            }
        }


        #endregion

    }
}
