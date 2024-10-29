using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Views
{
    internal class UsuarioController
    {
        public bool addUsuario(string nome, string usuario, string telefone, string senha)
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

            if( linhasAfetadas > 0 )
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
