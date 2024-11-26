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
            dgvUsuario = new DataGridView();
            buttonExcluirUsuario = new Button();
            pictureBox1 = new PictureBox();
            buttonSair = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuario
            // 
            dgvUsuario.BackgroundColor = Color.MidnightBlue;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(223, 32);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(313, 318);
            dgvUsuario.TabIndex = 0;
            // 
            // buttonExcluirUsuario
            // 
            buttonExcluirUsuario.BackColor = Color.AliceBlue;
            buttonExcluirUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExcluirUsuario.ForeColor = Color.MidnightBlue;
            buttonExcluirUsuario.Location = new Point(251, 356);
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
            buttonSair.Location = new Point(12, 423);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(66, 26);
            buttonSair.TabIndex = 4;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSair);
            Controls.Add(pictureBox1);
            Controls.Add(buttonExcluirUsuario);
            Controls.Add(dgvUsuario);
            Name = "frmUsuario";
            Text = "frmUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuario;
        private Button buttonExcluirUsuario;
        private PictureBox pictureBox1;
        private Button buttonSair;
    }
}