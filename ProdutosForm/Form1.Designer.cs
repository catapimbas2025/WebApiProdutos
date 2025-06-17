namespace ProdutosForm
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
            dataGridView1 = new DataGridView();
            txtNome = new TextBox();
            label1 = new Label();
            txtEstoque = new TextBox();
            label2 = new Label();
            txtPreco = new TextBox();
            label3 = new Label();
            btnCarregar = new Button();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            btnRemover = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(581, 146);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += Form1_Load;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 58);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(480, 30);
            txtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "NOME :";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(82, 158);
            txtEstoque.Multiline = true;
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(243, 30);
            txtEstoque.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "ESTOQUE :";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(82, 105);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(243, 30);
            txtPreco.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 120);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "PREÇO :";
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(12, 246);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(111, 40);
            btnCarregar.TabIndex = 4;
            btnCarregar.Text = "CARREGAR";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(129, 246);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(111, 40);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(246, 246);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(111, 40);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(363, 246);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(111, 40);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "REMOVER";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(482, 246);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(111, 40);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemover);
            Controls.Add(btnAtualizar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnCarregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPreco);
            Controls.Add(txtEstoque);
            Controls.Add(txtNome);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "MainForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtEstoque;
        private Label label2;
        private TextBox txtPreco;
        private Label label3;
        private Button btnCarregar;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button btnRemover;
        private Button btnLimpar;
    }
}
