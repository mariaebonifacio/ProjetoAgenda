namespace ProjetoAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void habilitarBotaologin()
        {
            //Se o preenchimento do usuário for diferente de vazio e a quantidade de caracteres na senha for
            //maior ou igual à 8, habilita o botão de login
            if (textBoxUsuario.Text != "" && textBoxSenha.Text.Length >= 8)
            {
                buttonEntrar.Enabled = true;
            }

            else
            {
                buttonEntrar.Enabled = false;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            fmrCadastro formularioCadastro = new fmrCadastro();
            formularioCadastro.ShowDialog();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaologin();
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaologin();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
