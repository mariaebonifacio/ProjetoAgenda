namespace ProjetoAgenda.Views
{
    partial class frmContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContato));
            buttonVoltar = new Button();
            groupBox1 = new GroupBox();
            cbCategoria = new ComboBox();
            labelCategoria = new Label();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            labelTelefone = new Label();
            txtTelefone = new TextBox();
            labelContato = new Label();
            txtContato = new TextBox();
            buttonSair = new Button();
            buttonExcluirUsuario = new Button();
            dgvContato = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            labelAvisos = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.GhostWhite;
            buttonVoltar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = Color.Purple;
            buttonVoltar.Location = new Point(12, 412);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(66, 26);
            buttonVoltar.TabIndex = 11;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(labelCategoria);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(labelTelefone);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(labelContato);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(31, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 281);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar contato";
            // 
            // cbCategoria
            // 
            cbCategoria.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(6, 194);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(245, 27);
            cbCategoria.TabIndex = 12;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(6, 168);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(104, 23);
            labelCategoria.TabIndex = 9;
            labelCategoria.Text = "Categoria";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Plum;
            btnCadastrar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.Purple;
            btnCadastrar.Location = new Point(6, 236);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(110, 34);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Plum;
            btnAlterar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.Purple;
            btnAlterar.Location = new Point(141, 236);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(110, 34);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(6, 98);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(93, 23);
            labelTelefone.TabIndex = 7;
            labelTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(6, 124);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(245, 41);
            txtTelefone.TabIndex = 6;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(6, 32);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(84, 23);
            labelContato.TabIndex = 5;
            labelContato.Text = "Contato";
            // 
            // txtContato
            // 
            txtContato.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContato.Location = new Point(6, 58);
            txtContato.Multiline = true;
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(245, 37);
            txtContato.TabIndex = 0;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.GhostWhite;
            buttonSair.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.Purple;
            buttonSair.Location = new Point(97, 412);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(66, 26);
            buttonSair.TabIndex = 9;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonExcluirUsuario
            // 
            buttonExcluirUsuario.BackColor = Color.GhostWhite;
            buttonExcluirUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExcluirUsuario.ForeColor = Color.Purple;
            buttonExcluirUsuario.Location = new Point(428, 349);
            buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            buttonExcluirUsuario.Size = new Size(267, 44);
            buttonExcluirUsuario.TabIndex = 8;
            buttonExcluirUsuario.Text = "Excluir";
            buttonExcluirUsuario.UseVisualStyleBackColor = false;
            buttonExcluirUsuario.Click += buttonExcluirUsuario_Click;
            // 
            // dgvContato
            // 
            dgvContato.BackgroundColor = Color.Plum;
            dgvContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContato.Location = new Point(408, 21);
            dgvContato.Name = "dgvContato";
            dgvContato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContato.Size = new Size(313, 318);
            dgvContato.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Twilight_sparkle;
            pictureBox1.Location = new Point(300, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.latest;
            pictureBox2.Location = new Point(679, 305);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 148);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(labelAvisos);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 337);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 64);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Avisos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(363, 15);
            label1.TabIndex = 1;
            label1.Text = "2- Se for alterar o contato, deixe o campo de telefone em BRANCO";
            // 
            // labelAvisos
            // 
            labelAvisos.AutoSize = true;
            labelAvisos.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAvisos.Location = new Point(6, 23);
            labelAvisos.Name = "labelAvisos";
            labelAvisos.Size = new Size(301, 15);
            labelAvisos.TabIndex = 0;
            labelAvisos.Text = "1- O  número de telefone deve conter apenas 8 digitos";
            // 
            // frmContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(buttonVoltar);
            Controls.Add(groupBox1);
            Controls.Add(buttonSair);
            Controls.Add(buttonExcluirUsuario);
            Controls.Add(dgvContato);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmContato";
            Load += frmContato_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContato).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVoltar;
        private GroupBox groupBox1;
        private Label labelCategoria;
        private Button btnAlterar;
        private Label labelTelefone;
        private TextBox txtTelefone;
        private Label labelContato;
        private TextBox txtContato;
        private Button buttonSair;
        private Button buttonExcluirUsuario;
        private DataGridView dgvContato;
        private Button btnCadastrar;
        private ComboBox cbCategoria;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private Label labelAvisos;
        private Label label1;
    }
}