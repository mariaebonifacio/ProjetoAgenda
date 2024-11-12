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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();

            DataTable tabela = controleCategoria.GetCategorias();

            //Ele seleciona toda a tabela
            dgvCategoria.DataSource = tabela;
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();


            bool resultado = controleCategoria.AddCategoria(textBoxCadastrar.Text);

            AtualizarDataGrid();

            if (resultado == true)
            {
                MessageBox.Show("Seu cadastro foi efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível realizar seu cadastro.");
            }

            DataTable tabela = controleCategoria.GetCategorias();

            //Ele seleciona toda a tabela
            dgvCategoria.DataSource = tabela;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            CategoriaController categoria = new CategoriaController();
            bool resultado = categoria.ExcluirCategorias(codigo);
            AtualizarDataGrid(); 
        }
    }
}
