using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Data
{
    static public class ConexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
         //String contendo as informações para conexão
            string stringConexao = "Server=127.0.0.1;Database=bdAgenda; User ID=root;Password=root;";

        //criando conexao
        MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }
    }
}
