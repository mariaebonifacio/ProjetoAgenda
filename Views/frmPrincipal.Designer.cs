namespace ProjetoAgenda.Views
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            cadastarToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            excluirStripMenu = new ToolStripMenuItem();
            contatoToolStripMenuItem = new ToolStripMenuItem();
            labelWelcome = new Label();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(720, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, sairToolStripMenuItem1 });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(104, 22);
            sairToolStripMenuItem.Text = "Voltar";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(104, 22);
            sairToolStripMenuItem1.Text = "Sair";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem1_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastarToolStripMenuItem, excluirStripMenu, contatoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // cadastarToolStripMenuItem
            // 
            cadastarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, usuárioToolStripMenuItem });
            cadastarToolStripMenuItem.Name = "cadastarToolStripMenuItem";
            cadastarToolStripMenuItem.Size = new Size(180, 22);
            cadastarToolStripMenuItem.Text = "Cadastar";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(180, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // excluirStripMenu
            // 
            excluirStripMenu.Name = "excluirStripMenu";
            excluirStripMenu.Size = new Size(180, 22);
            excluirStripMenu.Text = "Usuário";
            excluirStripMenu.Click += excluirStripMenu_Click;
            // 
            // contatoToolStripMenuItem
            // 
            contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            contatoToolStripMenuItem.Size = new Size(180, 22);
            contatoToolStripMenuItem.Text = "Contato";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.FromArgb(255, 192, 128);
            labelWelcome.Location = new Point(12, 44);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(124, 21);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Seja bem-vindo!";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(180, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GossipGirl11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 450);
            Controls.Add(labelWelcome);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem cadastarToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem excluirStripMenu;
        private Label labelWelcome;
        private ToolStripMenuItem contatoToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
    }
}