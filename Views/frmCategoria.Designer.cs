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
            ButtonCadastrar = new Button();
            textBoxCadastrar = new TextBox();
            dgvCategoria = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(ButtonCadastrar);
            groupBox1.Controls.Add(textBoxCadastrar);
            groupBox1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(105, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da nova categoria";
            // 
            // ButtonCadastrar
            // 
            ButtonCadastrar.BackColor = Color.Black;
            ButtonCadastrar.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCadastrar.Location = new Point(23, 154);
            ButtonCadastrar.Name = "ButtonCadastrar";
            ButtonCadastrar.Size = new Size(296, 76);
            ButtonCadastrar.TabIndex = 1;
            ButtonCadastrar.Text = "Cadastrar";
            ButtonCadastrar.UseVisualStyleBackColor = false;
            ButtonCadastrar.Click += ButtonCadastrar_Click;
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
            dgvCategoria.Location = new Point(604, 69);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(317, 287);
            dgvCategoria.TabIndex = 1;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 546);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button ButtonCadastrar;
        private TextBox textBoxCadastrar;
        private DataGridView dgvCategoria;
    }
}