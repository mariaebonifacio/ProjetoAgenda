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

            dgvContato.DataSource= tabela;

            AtualizarDataGrid();
        }
    }
}
