using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
            //Criando conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = @"INSERT INTO tbcategoria
                                (nome_categoria)
                                VALUES
                                (@nome_categoria);";

                //Abrir a conexão com o banco
                conexao.Open();


                //Responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Esas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome_categoria", categoria);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                { return true; }

                else
                { return false; }
            }


            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO CADASTRAR CATEGORIA: {erro.Message}");
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;
            
                try
                {

                    //Usei a classe ConexaoDB que ja havia criado
                    conexao = ConexaoDB.CriarConexao();

                    //Select que vai retornar os dados
                    string sql = @"SELECT id_categoria as 'Código', nome_categoria as 'Categoria'
                                   FROM tbcategoria;";

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
                    MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}");
                    
                    return new DataTable();
                }
        }

        public bool ExcluirCategorias(int id_categoria)
        {


            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = @"DELETE FROM tbcategoria
                            WHERE id_categoria = (id_categoria);";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Abrir a conexão com o banco
                conexao.Open();

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Esas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@id_categoria", id_categoria);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                { return true; }

                else
                { return false; }
            }


            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO EXCLUIR CATEGORIA: {erro.Message}");
            }

        }

    }
}

