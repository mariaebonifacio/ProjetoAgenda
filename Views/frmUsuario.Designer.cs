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
            buttonDeletarUsuario = new Button();
            groupBox1 = new GroupBox();
            buttonCriarUsuario = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(313, 318);
            dataGridView1.TabIndex = 0;
            // 
            // buttonDeletarUsuario
            // 
            buttonDeletarUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeletarUsuario.Location = new Point(68, 382);
            buttonDeletarUsuario.Name = "buttonDeletarUsuario";
            buttonDeletarUsuario.Size = new Size(267, 44);
            buttonDeletarUsuario.TabIndex = 1;
            buttonDeletarUsuario.Text = "Deletar";
            buttonDeletarUsuario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCriarUsuario);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(501, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 303);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar senha";
            // 
            // buttonCriarUsuario
            // 
            buttonCriarUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarUsuario.Location = new Point(35, 225);
            buttonCriarUsuario.Name = "buttonCriarUsuario";
            buttonCriarUsuario.Size = new Size(194, 58);
            buttonCriarUsuario.TabIndex = 1;
            buttonCriarUsuario.Text = "Criar usuário";
            buttonCriarUsuario.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 62);
            textBox1.TabIndex = 0;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(buttonDeletarUsuario);
            Controls.Add(dataGridView1);
            Name = "frmUsuario";
            Text = "frmUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonDeletarUsuario;
        private GroupBox groupBox1;
        private Button buttonCriarUsuario;
        private TextBox textBox1;
    }
}