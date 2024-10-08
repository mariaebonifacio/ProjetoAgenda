namespace ProjetoAgenda
{
    partial class fmrCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCadastro));
            buttonCancelar = new Button();
            buttonCadastrar = new Button();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            label1 = new Label();
            textBoxNome = new TextBox();
            label3 = new Label();
            textBoxTelefone = new TextBox();
            label4 = new Label();
            textBoxSenha = new TextBox();
            label5 = new Label();
            textBoxRepetir = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.DeepPink;
            buttonCancelar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(264, 392);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(111, 40);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.MediumVioletRed;
            buttonCadastrar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.ForeColor = Color.White;
            buttonCadastrar.Location = new Point(76, 392);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(111, 40);
            buttonCadastrar.TabIndex = 11;
            buttonCadastrar.Text = "CADASTRAR";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 71);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "Usuário:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.Pink;
            textBoxUsuario.Location = new Point(21, 94);
            textBoxUsuario.Multiline = true;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(300, 34);
            textBoxUsuario.TabIndex = 9;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 8;
            label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.BackColor = Color.Pink;
            textBoxNome.Location = new Point(21, 34);
            textBoxNome.Multiline = true;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(300, 34);
            textBoxNome.TabIndex = 7;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 137);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 14;
            label3.Text = "Telefone:";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.BackColor = Color.Pink;
            textBoxTelefone.Location = new Point(21, 160);
            textBoxTelefone.Multiline = true;
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(300, 34);
            textBoxTelefone.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 205);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 16;
            label4.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.BackColor = Color.Pink;
            textBoxSenha.Location = new Point(21, 228);
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '•';
            textBoxSenha.Size = new Size(300, 34);
            textBoxSenha.TabIndex = 15;
            textBoxSenha.TextChanged += textBoxSenha_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 275);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 18;
            label5.Text = "Repita a senha:";
            // 
            // textBoxRepetir
            // 
            textBoxRepetir.BackColor = Color.Pink;
            textBoxRepetir.Location = new Point(21, 298);
            textBoxRepetir.Multiline = true;
            textBoxRepetir.Name = "textBoxRepetir";
            textBoxRepetir.PasswordChar = '•';
            textBoxRepetir.Size = new Size(300, 34);
            textBoxRepetir.TabIndex = 17;
            textBoxRepetir.TextChanged += textBoxRepetir_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxRepetir);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxSenha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Location = new Point(52, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 348);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar";
            // 
            // fmrCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(789, 444);
            Controls.Add(groupBox1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonCadastrar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmrCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmrCadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonCadastrar;
        private Label label2;
        private TextBox textBoxUsuario;
        private Label label1;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBoxTelefone;
        private Label label4;
        private TextBox textBoxSenha;
        private Label label5;
        private TextBox textBoxRepetir;
        private GroupBox groupBox1;
    }
}