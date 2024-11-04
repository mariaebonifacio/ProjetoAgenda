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
    public partial class fmrTeste : Form
    {
        public fmrTeste()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(325, 203);
            button1.Name = "button1";
            button1.Size = new Size(335, 155);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fmrTeste
            // 
            ClientSize = new Size(1010, 593);
            Controls.Add(button1);
            Name = "fmrTeste";
            ResumeLayout(false);
        }

        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController controleusuario = new UsuarioController();

            bool resultado = controleusuario.LogarUsuario("maria", "Me12122007");

            MessageBox.Show(resultado.ToString());
        }
    }
}
