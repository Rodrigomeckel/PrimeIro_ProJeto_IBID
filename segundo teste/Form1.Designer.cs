
namespace segundo_teste
{
    partial class Form1
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
            this.contador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.remove_produto = new System.Windows.Forms.Button();
            this.txb_produtos = new System.Windows.Forms.TextBox();
            this.list_produtos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_produto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contador
            // 
            this.contador.AutoSize = true;
            this.contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador.Location = new System.Drawing.Point(640, 441);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(25, 25);
            this.contador.TabIndex = 17;
            this.contador.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quantidade de produtos :";
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpar.Location = new System.Drawing.Point(535, 176);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(169, 55);
            this.btn_limpar.TabIndex = 15;
            this.btn_limpar.Text = "limpar lista";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_alterar.Location = new System.Drawing.Point(357, 271);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(169, 55);
            this.btn_alterar.TabIndex = 14;
            this.btn_alterar.Text = "alterar produto";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // remove_produto
            // 
            this.remove_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_produto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remove_produto.Location = new System.Drawing.Point(357, 176);
            this.remove_produto.Name = "remove_produto";
            this.remove_produto.Size = new System.Drawing.Size(169, 55);
            this.remove_produto.TabIndex = 13;
            this.remove_produto.Text = "Remover produto";
            this.remove_produto.UseVisualStyleBackColor = true;
            this.remove_produto.Click += new System.EventHandler(this.remove_produto_Click);
            // 
            // txb_produtos
            // 
            this.txb_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_produtos.Location = new System.Drawing.Point(58, 70);
            this.txb_produtos.Name = "txb_produtos";
            this.txb_produtos.Size = new System.Drawing.Size(259, 24);
            this.txb_produtos.TabIndex = 0;
            this.txb_produtos.Click += new System.EventHandler(this.txb_produtos_Click);
            // 
            // list_produtos
            // 
            this.list_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_produtos.FormattingEnabled = true;
            this.list_produtos.ItemHeight = 20;
            this.list_produtos.Location = new System.Drawing.Point(52, 137);
            this.list_produtos.Name = "list_produtos";
            this.list_produtos.Size = new System.Drawing.Size(265, 344);
            this.list_produtos.TabIndex = 11;
            this.list_produtos.SelectedIndexChanged += new System.EventHandler(this.list_produtos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adicionar produto";
            // 
            // add_produto
            // 
            this.add_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_produto.Location = new System.Drawing.Point(357, 82);
            this.add_produto.Name = "add_produto";
            this.add_produto.Size = new System.Drawing.Size(169, 55);
            this.add_produto.TabIndex = 10;
            this.add_produto.Text = "add Produto";
            this.add_produto.UseVisualStyleBackColor = true;
            this.add_produto.Click += new System.EventHandler(this.add_produto_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.add_produto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(756, 517);
            this.Controls.Add(this.contador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.remove_produto);
            this.Controls.Add(this.txb_produtos);
            this.Controls.Add(this.list_produtos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button remove_produto;
        private System.Windows.Forms.TextBox txb_produtos;
        private System.Windows.Forms.ListBox list_produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_produto;
    }
}

