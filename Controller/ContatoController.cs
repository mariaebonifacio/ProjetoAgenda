using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public bool AddContato(string contato, string telefone, string categoria)
        {
            

            try
            {
                //Criando conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);


                //Comando SQL que será executado
                string sql = "INSERT INTO tbcontatos (contato, telefone, categoria) VALUES (@contato, @telefone, @categoria);";

                //Abrir a conexão com o banco
                conexao.Open();


                //Responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Esas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                { return true; }

                else
                { return false; }
            }


            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO CADASTRAR CADASTRO: {erro.Message}");
                return false;
            }
        }

        public bool ExcluirContato(string telefone)
        {

            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Comando SQL que será executado
                string sql = "DELETE FROM  tbcontatos WHERE telefone = @telefone";

                //Abrir a conexão com o banco
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Esas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@telefone", telefone);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhasAfetadas > 0)
                { return true; }

                else
                { return false; }
            }


            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO EXCLUIR CONTATO: {erro.Message}");
                return false;
            }

        }

        public bool AlterarContatos(string contato, string telefone, string categoria)
        {


            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Comando SQL que será executado
                string sql = @"UPDATE tbcontatos
                            SET categoria = @categoria 
                            SET contato = @contato
                            SET telefone = @telefone
                            WHERE telefone = @telefone";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Abrir a conexão com o banco
                conexao.Open();

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Esas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhasAfetadas > 0)
                { return true; }

                else
                { return false; }
            }


            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO ALTERAR CONTATO: {erro.Message}");
                return false;
            }

        }

        public DataTable GetContatos()
        {
            MySqlConnection conexao = null;

            try
            {

                //Usei a classe ConexaoDB que ja havia criado
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Select que vai retornar os dados
                string sql = $"SELECT contato AS 'Contato', telefone AS 'Telefone', categoria AS 'Categoria' FROM tbcontatos;";

                //Abrir a conexão
                conexao.Open();

                //Ao invés de ultilizar o MySqlCommand vou utilizar o MySqlDataAdapter pois quero trabalhar com a tabela inteira, não só os dados.
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Criei uma tabela vazia
                DataTable tabela = new DataTable();

                //O adaptador vai preencher a tabela com os dados
                adaptador.Fill(tabela);

                return tabela;
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar contato: {erro.Message}");

                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
