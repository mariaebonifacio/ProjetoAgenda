using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool addUsuario(string nome, string usuario, string telefone, string senha)
        {
            try
            {

                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "INSERT INTO tbusuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                conexao.Open();


                //Responsável pelo comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                //Para executar no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    string comandSql2 = $@"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';
                                            GRANT ALL PRIVILEGES ON bdagenda.* TO '{usuario}'@'%'
                                            FLUSH PRIVILEGES;";

                    comando = new MySqlCommand(comandSql2, conexao);

                    linhasAfetadas = comando.ExecuteNonQuery();

                    return true;

                }

                else
                {
                    return false;
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }
        }

        public bool LogarUsuario(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = @"select * from tbusuarios
                               where usuario = @usuario
                               AND BINARY senha = @senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    //Caso o usuário consiga logar, preencho o UserSession
                    //com suas informações
                    UserSession.usuario = resultado.GetString("usuario");
                    UserSession.nome = resultado.GetString("nome");
                    UserSession.senha = resultado.GetString("senha");
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close ();
                    return false;
                }
            }

            catch
            {
                return false;
            }
        }
        private bool CreateUsuario(string usuario, string senha)
        {
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            string sql2 = @"CREATE USER '{usuario} '@'IDENTIFIED BY '{senha}';
                    GRANT ALL PRIVILEGES ON bdagenda.* TO '{usuario}'@'%';
                    FLUSH PRIVILEGES;";

            conexao.Open();

            //Responsável pelo comando SQL
            MySqlCommand comando = new MySqlCommand(sql2, conexao);

            comando.ExecuteNonQuery();

            return true;
        }

        public bool ExcluirUsuario(string usuario)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = "DELETE FROM tbusuarios WHERE usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);

                int LinhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (LinhasAfetadas > 0)
                { return true; }
                else
                { return false; }
            }



            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
                return false;
            }
        }

        public bool AlterarSenha (string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = "UPDATE tbusuarios SET senha = @senha WHERE usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@usuario", usuario);

                int LinhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if(LinhasAfetadas > 0)

                { return true; }

                else
                { return false; }
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar usuario: {erro.Message}");
                return false;
            }
        }

        public DataTable GetUsuarios()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(VariableGlobal.UserSession.usuario, VariableGlobal.UserSession.senha);
                string sql = @"select usuarios as 'Usuário', senha as 'Senha' FROM tbusuarios;";
                conexao.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar os usuários: {erro.Message}");

                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
