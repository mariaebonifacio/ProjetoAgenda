namespace ProjetoAgenda.Views
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            dgvUsuario = new DataGridView();
            buttonExcluirUsuario = new Button();
            pictureBox1 = new PictureBox();
            buttonSair = new Button();
            groupBox1 = new GroupBox();
            buttonAlterar = new Button();
            labelSenha = new Label();
            txtSenha = new TextBox();
            labelUsuario = new Label();
            pictureBox2 = new PictureBox();
            txtUsuario = new TextBox();
            buttonVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuario
            // 
            dgvUsuario.BackgroundColor = Color.MidnightBlue;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(325, 33);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(313, 318);
            dgvUsuario.TabIndex = 0;
            // 
            // buttonExcluirUsuario
            // 
            buttonExcluirUsuario.BackColor = Color.AliceBlue;
            buttonExcluirUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExcluirUsuario.ForeColor = Color.MidnightBlue;
            buttonExcluirUsuario.Location = new Point(353, 357);
            buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            buttonExcluirUsuario.Size = new Size(267, 44);
            buttonExcluirUsuario.TabIndex = 1;
            buttonExcluirUsuario.Text = "Excluir";
            buttonExcluirUsuario.UseVisualStyleBackColor = false;
            buttonExcluirUsuario.Click += buttonExcluirUsuario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Donald;
            pictureBox1.Location = new Point(673, 328);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.AliceBlue;
            buttonSair.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.MidnightBlue;
            buttonSair.Location = new Point(84, 423);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(66, 26);
            buttonSair.TabIndex = 4;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAlterar);
            groupBox1.Controls.Add(labelSenha);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 332);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar senha";
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = Color.MidnightBlue;
            buttonAlterar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAlterar.ForeColor = Color.AliceBlue;
            buttonAlterar.Location = new Point(67, 284);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(110, 34);
            buttonAlterar.TabIndex = 4;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(9, 132);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 17);
            labelSenha.TabIndex = 7;
            labelSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 150);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(229, 41);
            txtSenha.TabIndex = 6;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(9, 40);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(67, 17);
            labelUsuario.TabIndex = 5;
            labelUsuario.Text = "Usuário";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Donald_Duck_Free_PNG_Image;
            pictureBox2.Location = new Point(78, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(6, 68);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(229, 41);
            txtUsuario.TabIndex = 0;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.AliceBlue;
            buttonVoltar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = Color.MidnightBlue;
            buttonVoltar.Location = new Point(12, 423);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(66, 26);
            buttonVoltar.TabIndex = 6;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVoltar);
            Controls.Add(groupBox1);
            Controls.Add(buttonSair);
            Controls.Add(pictureBox1);
            Controls.Add(buttonExcluirUsuario);
            Controls.Add(dgvUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuario;
        private Button buttonExcluirUsuario;
        private PictureBox pictureBox1;
        private Button buttonSair;
        private GroupBox groupBox1;
        private Button buttonAlterar;
        private Label labelSenha;
        private TextBox txtSenha;
        private Label labelUsuario;
        private PictureBox pictureBox2;
        private TextBox txtUsuario;
        private Button buttonVoltar;
    }
}