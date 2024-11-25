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
            dataGridView1 = new DataGridView();
            buttonExcluirUsuario = new Button();
            groupBox1 = new GroupBox();
            labelSenha = new Label();
            textBoxSenha = new TextBox();
            labelUsuario = new Label();
            pictureBox2 = new PictureBox();
            textBoxUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            buttonAlterarSenha = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(313, 318);
            dataGridView1.TabIndex = 0;
            // 
            // buttonExcluirUsuario
            // 
            buttonExcluirUsuario.BackColor = Color.AliceBlue;
            buttonExcluirUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExcluirUsuario.ForeColor = Color.MidnightBlue;
            buttonExcluirUsuario.Location = new Point(68, 382);
            buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            buttonExcluirUsuario.Size = new Size(267, 44);
            buttonExcluirUsuario.TabIndex = 1;
            buttonExcluirUsuario.Text = "Excluir";
            buttonExcluirUsuario.UseVisualStyleBackColor = false;
            buttonExcluirUsuario.Click += buttonAlterarUsuario_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAlterarSenha);
            groupBox1.Controls.Add(labelSenha);
            groupBox1.Controls.Add(textBoxSenha);
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(textBoxUsuario);
            groupBox1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(390, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 332);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar senha";
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
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(6, 150);
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(229, 41);
            textBoxSenha.TabIndex = 6;
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
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(6, 68);
            textBoxUsuario.Multiline = true;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(229, 41);
            textBoxUsuario.TabIndex = 0;
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
            // buttonAlterarSenha
            // 
            buttonAlterarSenha.BackColor = Color.AliceBlue;
            buttonAlterarSenha.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAlterarSenha.ForeColor = Color.MidnightBlue;
            buttonAlterarSenha.Location = new Point(67, 284);
            buttonAlterarSenha.Name = "buttonAlterarSenha";
            buttonAlterarSenha.Size = new Size(110, 34);
            buttonAlterarSenha.TabIndex = 4;
            buttonAlterarSenha.Text = "Alterar";
            buttonAlterarSenha.UseVisualStyleBackColor = false;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(buttonExcluirUsuario);
            Controls.Add(dataGridView1);
            Name = "frmUsuario";
            Text = "frmUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonExcluirUsuario;
        private GroupBox groupBox1;
        private TextBox textBoxUsuario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelSenha;
        private TextBox textBoxSenha;
        private Label labelUsuario;
        private Button buttonAlterarSenha;
    }
}