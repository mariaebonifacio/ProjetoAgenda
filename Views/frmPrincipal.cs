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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            labelWelcome.Text = $"Seja bem vindo(a), {VariableGlobal.UserSession.nome}!";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria formularioCategoria = new frmCategoria();
            formularioCategoria.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmUsuario formularioUsuario = new frmUsuario();
            formularioUsuario.ShowDialog();
        }

        private void senhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarUsuario formularioAlterarUsuario = new frmAlterarUsuario();
            formularioAlterarUsuario.ShowDialog();
        }
    }
}
