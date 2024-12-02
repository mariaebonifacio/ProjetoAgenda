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
            buttonVoltar = new Button();
            groupBox1 = new GroupBox();
            btnExcluir = new Button();
            labelCategoria = new Label();
            btnCadastrar = new Button();
            buttonAlterar = new Button();
            labelTelefone = new Label();
            txtTelefone = new TextBox();
            labelContato = new Label();
            txtContato = new TextBox();
            buttonSair = new Button();
            buttonExcluirUsuario = new Button();
            dgvContato = new DataGridView();
            cbCategoria = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContato).BeginInit();
            SuspendLayout();
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.AliceBlue;
            buttonVoltar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = Color.MidnightBlue;
            buttonVoltar.Location = new Point(47, 402);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(66, 26);
            buttonVoltar.TabIndex = 11;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(labelCategoria);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(buttonAlterar);
            groupBox1.Controls.Add(labelTelefone);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(labelContato);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(64, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 368);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar contato";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.MidnightBlue;
            btnExcluir.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.AliceBlue;
            btnExcluir.Location = new Point(68, 324);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 34);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(6, 202);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(104, 23);
            labelCategoria.TabIndex = 9;
            labelCategoria.Text = "Categoria";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MidnightBlue;
            btnCadastrar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.AliceBlue;
            btnCadastrar.Location = new Point(6, 284);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(110, 34);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = Color.MidnightBlue;
            buttonAlterar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAlterar.ForeColor = Color.AliceBlue;
            buttonAlterar.Location = new Point(125, 284);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(110, 34);
            buttonAlterar.TabIndex = 4;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(6, 124);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(93, 23);
            labelTelefone.TabIndex = 7;
            labelTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(6, 150);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(229, 41);
            txtTelefone.TabIndex = 6;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(6, 42);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(84, 23);
            labelContato.TabIndex = 5;
            labelContato.Text = "Contato";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(6, 68);
            txtContato.Multiline = true;
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(229, 41);
            txtContato.TabIndex = 0;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.AliceBlue;
            buttonSair.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.MidnightBlue;
            buttonSair.Location = new Point(119, 402);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(66, 26);
            buttonSair.TabIndex = 9;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            // 
            // buttonExcluirUsuario
            // 
            buttonExcluirUsuario.BackColor = Color.AliceBlue;
            buttonExcluirUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExcluirUsuario.ForeColor = Color.MidnightBlue;
            buttonExcluirUsuario.Location = new Point(388, 336);
            buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            buttonExcluirUsuario.Size = new Size(267, 44);
            buttonExcluirUsuario.TabIndex = 8;
            buttonExcluirUsuario.Text = "Excluir";
            buttonExcluirUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvContato
            // 
            dgvContato.BackgroundColor = Color.MidnightBlue;
            dgvContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContato.Location = new Point(360, 12);
            dgvContato.Name = "dgvContato";
            dgvContato.Size = new Size(313, 318);
            dgvContato.TabIndex = 7;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(6, 239);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(229, 31);
            cbCategoria.TabIndex = 12;
            // 
            // frmContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVoltar);
            Controls.Add(groupBox1);
            Controls.Add(buttonSair);
            Controls.Add(buttonExcluirUsuario);
            Controls.Add(dgvContato);
            Name = "frmContato";
            Text = "frmContato";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVoltar;
        private GroupBox groupBox1;
        private Label labelCategoria;
        private Button buttonAlterar;
        private Label labelTelefone;
        private TextBox txtTelefone;
        private Label labelContato;
        private TextBox txtContato;
        private Button buttonSair;
        private Button buttonExcluirUsuario;
        private DataGridView dgvContato;
        private Button btnCadastrar;
        private Button btnExcluir;
        private ComboBox cbCategoria;
    }
}