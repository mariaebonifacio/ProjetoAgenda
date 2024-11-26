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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();

            UsuarioController controller = new UsuarioController();
            DataTable tabela = controller.GetUsuarios();

            dgvUsuario.DataSource = tabela;
        }


        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(dgvUsuario.SelectedRows[0].Cells[0].Value);
            UsuarioController Controller = new UsuarioController();
            bool resultado = Controller.ExcluirUsuario(usuario);

            if (resultado)
            {
                //Quando clicar no "ok" do messageBox, eme atualiza a GrideView
                DialogResult result = MessageBox.Show("Exclusão Concluída");

                if (result == DialogResult.OK)
                {
                    UsuarioController controller = new UsuarioController();
                    DataTable tabela = controller.GetUsuarios();

                    dgvUsuario.DataSource = tabela;
                }

                else
                {
                    MessageBox.Show("não foi possível excluir usuário.");
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
