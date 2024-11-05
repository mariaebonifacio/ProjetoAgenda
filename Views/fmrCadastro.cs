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
using ProjetoAgenda.Controller;


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
            //Pegando os dados do usuário
            string nome = textBoxNome.Text;
            string usuario = textBoxUsuario.Text;
            string telefone = textBoxTelefone.Text;
            string senha = textBoxSenha.Text;

            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.addUsuario(nome, usuario, telefone, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possível cadastrar o usuário.");
            }
        }
    }
}
