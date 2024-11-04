namespace ProjetoAgenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBoxSenha = new TextBox();
            buttonEntrar = new Button();
            buttonCadastrar = new Button();
            groupBox1 = new GroupBox();
            textBoxUsuario = new TextBox();
            buttonSair = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 43);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 133);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(32, 156);
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '✶';
            textBoxSenha.Size = new Size(321, 48);
            textBoxSenha.TabIndex = 2;
            textBoxSenha.TextChanged += textBoxSenha_TextChanged;
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = Color.CadetBlue;
            buttonEntrar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.ForeColor = Color.White;
            buttonEntrar.Location = new Point(32, 227);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(150, 53);
            buttonEntrar.TabIndex = 5;
            buttonEntrar.Text = "ENTRAR";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.DarkCyan;
            buttonCadastrar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.ForeColor = Color.White;
            buttonCadastrar.Location = new Point(203, 227);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(150, 53);
            buttonCadastrar.TabIndex = 6;
            buttonCadastrar.Text = "CADASTRAR";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(textBoxUsuario);
            groupBox1.Controls.Add(buttonCadastrar);
            groupBox1.Controls.Add(buttonEntrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxSenha);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(87, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 319);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(32, 66);
            textBoxUsuario.Multiline = true;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(321, 48);
            textBoxUsuario.TabIndex = 7;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Teal;
            buttonSair.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.White;
            buttonSair.Location = new Point(509, 408);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(60, 29);
            buttonSair.TabIndex = 8;
            buttonSair.Text = "SAIR";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(581, 449);
            Controls.Add(buttonSair);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxSenha;
        private Button button1;
        private Button buttonEntrar;
        private Button buttonCadastrar;
        private GroupBox groupBox1;
        private TextBox textBoxUsuario;
        private Button buttonSair;
    }
}
