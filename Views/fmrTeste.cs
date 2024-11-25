
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoAgenda.Controller;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;

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
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(245, 257);
            button1.Name = "button1";
            button1.Size = new Size(201, 69);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(467, 257);
            button2.Name = "button2";
            button2.Size = new Size(201, 69);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 175);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 52);
            textBox1.TabIndex = 2;
            // 
            // fmrTeste
            // 
            ClientSize = new Size(1010, 593);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "fmrTeste";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button2;
        private TextBox textBox1;
        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            UserSession.usuario = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoriaController categoriaController = new CategoriaController();

            categoriaController.AlterarCategorias("Alunos", 9);
        }
    }
}
