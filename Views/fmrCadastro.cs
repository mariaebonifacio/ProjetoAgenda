using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenda.Data;

namespace ProjetoAgenda
{
    public partial class fmrCadastro : Form
    {

        private void habilitarBotaoCadastro()
        {
            if (textBoxNome.Text != "" && textBoxUsuario.Text != "" && textBoxSenha.Text.Length >= 8
                && textBoxRepetir.Text == textBoxSenha.Text)
            {
                buttonCadastrar.Enabled = true;
            }

            else
            {
                buttonCadastrar.Enabled = false;
            }
        }

        public fmrCadastro()
        {
            InitializeComponent();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void textBoxRepetir_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            //Abrindo conexão
            conexao.Open();

            //Criando o comando SQL para inserir o usuário
            string sql = $"INSERT INTO tbUsuarios (nome, usuario,telefone,senha) VALUES (@nome,@usuario,@telefone,@senha)";

            //criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            //Inserir os parametros
            comando.Parameters.AddWithValue("@nome", textBoxNome.Text);
            comando.Parameters.AddWithValue("@usuario", textBoxUsuario.Text);
            comando.Parameters.AddWithValue("@telefone", textBoxTelefone.Text);
            comando.Parameters.AddWithValue("@senha", textBoxSenha.Text);

            //exectando a instrução SQL no bando 
            comando.ExecuteNonQuery();

            //fechando a conexão com o banco
            conexao.Close();

            MessageBox.Show("Cadastro realizado com sucesso!");
            this.Close();

        }
    }
}
