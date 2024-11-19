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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // buttonDeletarUsuario
            // 
            buttonDeletarUsuario.BackColor = Color.AliceBlue;
            buttonDeletarUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeletarUsuario.Location = new Point(68, 382);
            buttonDeletarUsuario.Name = "buttonDeletarUsuario";
            buttonDeletarUsuario.Size = new Size(267, 44);
            buttonDeletarUsuario.TabIndex = 1;
            buttonDeletarUsuario.Text = "Deletar";
            buttonDeletarUsuario.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(buttonCriarUsuario);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(390, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 303);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar senha";
            // 
            // buttonCriarUsuario
            // 
            buttonCriarUsuario.BackColor = Color.AliceBlue;
            buttonCriarUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarUsuario.Location = new Point(35, 225);
            buttonCriarUsuario.Name = "buttonCriarUsuario";
            buttonCriarUsuario.Size = new Size(194, 58);
            buttonCriarUsuario.TabIndex = 1;
            buttonCriarUsuario.Text = "Criar usuário";
            buttonCriarUsuario.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 62);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Donald;
            pictureBox1.Location = new Point(670, 306);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Donald_Duck_Free_PNG_Image;
            pictureBox2.Location = new Point(67, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(buttonDeletarUsuario);
            Controls.Add(dataGridView1);
            Name = "frmUsuario";
            Text = "frmUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonDeletarUsuario;
        private GroupBox groupBox1;
        private Button buttonCriarUsuario;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}