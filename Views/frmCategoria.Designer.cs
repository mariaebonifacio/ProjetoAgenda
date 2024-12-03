namespace ProjetoAgenda.Views
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            groupBox1 = new GroupBox();
            buttonAlterar = new Button();
            buttonDeletar = new Button();
            ButtonAdicionar = new Button();
            textBoxCadastrar = new TextBox();
            dgvCategoria = new DataGridView();
            buttonVoltar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonAlterar);
            groupBox1.Controls.Add(buttonDeletar);
            groupBox1.Controls.Add(ButtonAdicionar);
            groupBox1.Controls.Add(textBoxCadastrar);
            groupBox1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(105, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categoria";
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = Color.Black;
            buttonAlterar.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAlterar.Location = new Point(198, 130);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(121, 42);
            buttonAlterar.TabIndex = 3;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonDeletar
            // 
            buttonDeletar.BackColor = Color.Black;
            buttonDeletar.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeletar.ForeColor = Color.White;
            buttonDeletar.Location = new Point(107, 196);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(121, 42);
            buttonDeletar.TabIndex = 3;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = false;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // ButtonAdicionar
            // 
            ButtonAdicionar.BackColor = Color.Black;
            ButtonAdicionar.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonAdicionar.Location = new Point(23, 130);
            ButtonAdicionar.Name = "ButtonAdicionar";
            ButtonAdicionar.Size = new Size(121, 42);
            ButtonAdicionar.TabIndex = 1;
            ButtonAdicionar.Text = "Adicionar";
            ButtonAdicionar.UseVisualStyleBackColor = false;
            ButtonAdicionar.Click += ButtonCadastrar_Click;
            // 
            // textBoxCadastrar
            // 
            textBoxCadastrar.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCadastrar.Location = new Point(23, 43);
            textBoxCadastrar.Multiline = true;
            textBoxCadastrar.Name = "textBoxCadastrar";
            textBoxCadastrar.Size = new Size(296, 65);
            textBoxCadastrar.TabIndex = 0;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(595, 51);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(317, 334);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = SystemColors.AppWorkspace;
            buttonVoltar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.Location = new Point(19, 492);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(97, 34);
            buttonVoltar.TabIndex = 2;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 546);
            Controls.Add(buttonVoltar);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button ButtonAdicionar;
        private TextBox textBoxCadastrar;
        private DataGridView dgvCategoria;
        private Button buttonVoltar;
        private Button buttonDeletar;
        private Button buttonAlterar;
    }
}