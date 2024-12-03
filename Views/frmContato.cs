using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            ContatoController controlecontato = new ContatoController();
            DataTable tabela = controlecontato.GetContatos();
            dgvContato.DataSource = tabela;
        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string contato = txtContato.Text;
            string telefone = txtTelefone.Text;
            string categoria = cbCategoria.Text;

            ContatoController contatoController = new ContatoController();
            bool resultado = contatoController.AddContato(contato, telefone, categoria);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }

            else
            {
                MessageBox.Show("Erro ao cadastrar");
            }

            DataTable tabela = contatoController.GetContatos();

            dgvContato.DataSource = tabela;

            AtualizarDataGrid();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            string telefone = Convert.ToString(dgvContato.SelectedRows[0].Cells[1].Value);
            ContatoController Controller = new ContatoController();
            bool resultado = Controller.ExcluirContato(telefone);

            AtualizarDataGrid();



        }

        private void frmContato_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();

            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            cbCategoria.DataSource = tabela;
            cbCategoria.DisplayMember = "categoria";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int alterarContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[1].Value);
            ContatoController controle = new ContatoController();

            string contatoUsuario = txtContato.Text;
            string telefoneUsuario = txtTelefone.Text;
            string categoriaUsuario = cbCategoria.Text;

            bool resultado = controle.AlterarContatos(contatoUsuario, alterarContato, categoriaUsuario);

            if (resultado)
            {
                MessageBox.Show("Contato alterado com sucesso.");
            }

            else
            {
                MessageBox.Show("Erro ao alterar contato.");
            }

            AtualizarDataGrid();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
