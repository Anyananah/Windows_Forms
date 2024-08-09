﻿using MySql.Data.MySqlClient;
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
    internal class FuncionarioDAO
    {
        #region Conexão
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            conexao = new Conexao().GetConnection();
        }
        #endregion

        #region Cadastrar
        public void cadastrarFuncionario(Funcionarios obj)
        {
            try
            {
                //PRIMEIRO PASSO - DEFINIR COMANDO SQL
                string sql = @"INSERT INTO tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso,
                telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                VALUES(@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco,
                @numero, @complemento, @bairro, @cidade, @estado)";

                //SEGUNDO PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.Nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.RG);
                executarcmd.Parameters.AddWithValue("@cpf", obj.CPF);
                executarcmd.Parameters.AddWithValue("@email", obj.Email);
                executarcmd.Parameters.AddWithValue("@senha", obj.Senha);
                executarcmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executarcmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel_acesso);
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

                MessageBox.Show("Funcionário cadastrado com Sucesso!");

                //QUARTO PASSO - FECHAR CONEXÃO
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro);
            }
        }
        #endregion

        #region Listar

        public DataTable listarFuncionario()
        {
            try
            {
                //PRIMEIRO PASSO - INSTANCIAR DATATABLE
                DataTable tabelaFuncionario = new DataTable();

                //SEGUNDO PASSO - DEFINIR COMANDO SQL
                string sql = @"SELECT * FROM tb_clientes";

                //TERCEIRO PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                //QUARTO PASSO - ABRIR CONEXÃO E EXECUTAR O COMANDO SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                //QUINTO PASSO - PREENCHER OS DADOS DO DATATABLE
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaFuncionario);

                //SEXTO PASSO - FECHAR CONEXÃO
                conexao.Close();

                return tabelaFuncionario;
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
