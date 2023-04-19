
namespace SistemaPadariaGranPao
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.LbTitulo = new System.Windows.Forms.Label();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_Categoria = new System.Windows.Forms.ComboBox();
            this.Cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.Cb_Marca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.Data_Cadastro = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Tb_Observacao = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Tb_Nome = new System.Windows.Forms.TextBox();
            this.Tb_Estoque = new System.Windows.Forms.TextBox();
            this.Tb_Lucro = new System.Windows.Forms.TextBox();
            this.Tb_Custo = new System.Windows.Forms.TextBox();
            this.Tb_Venda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(232, 9);
            this.LbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(252, 25);
            this.LbTitulo.TabIndex = 74;
            this.LbTitulo.Text = "Cadastro de Produto";
            // 
            // Tb_Id
            // 
            this.Tb_Id.Enabled = false;
            this.Tb_Id.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Id.Location = new System.Drawing.Point(33, 88);
            this.Tb_Id.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.Size = new System.Drawing.Size(131, 27);
            this.Tb_Id.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 18);
            this.label3.TabIndex = 75;
            this.label3.Text = "* Código do Produto:";
            // 
            // Cb_Categoria
            // 
            this.Cb_Categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Categoria.FormattingEnabled = true;
            this.Cb_Categoria.Location = new System.Drawing.Point(527, 233);
            this.Cb_Categoria.Name = "Cb_Categoria";
            this.Cb_Categoria.Size = new System.Drawing.Size(239, 21);
            this.Cb_Categoria.TabIndex = 4;
            // 
            // Cb_fornecedor
            // 
            this.Cb_fornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Cb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_fornecedor.FormattingEnabled = true;
            this.Cb_fornecedor.Location = new System.Drawing.Point(12, 233);
            this.Cb_fornecedor.Name = "Cb_fornecedor";
            this.Cb_fornecedor.Size = new System.Drawing.Size(239, 21);
            this.Cb_fornecedor.TabIndex = 2;
            // 
            // Cb_Marca
            // 
            this.Cb_Marca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Cb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Marca.FormattingEnabled = true;
            this.Cb_Marca.Location = new System.Drawing.Point(268, 233);
            this.Cb_Marca.Name = "Cb_Marca";
            this.Cb_Marca.Size = new System.Drawing.Size(239, 21);
            this.Cb_Marca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 80;
            this.label1.Text = " *Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = " *Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 83;
            this.label4.Text = "*Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "*Nome Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 86;
            this.label6.Text = "Estoque:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 98;
            this.label8.Text = "* Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 18);
            this.label9.TabIndex = 97;
            this.label9.Text = "* Data Cadastro:";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.Location = new System.Drawing.Point(549, 97);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(61, 23);
            this.cbStatus.TabIndex = 96;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // Data_Cadastro
            // 
            this.Data_Cadastro.AutoSize = true;
            this.Data_Cadastro.Enabled = false;
            this.Data_Cadastro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Cadastro.Location = new System.Drawing.Point(338, 96);
            this.Data_Cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Data_Cadastro.Name = "Data_Cadastro";
            this.Data_Cadastro.Size = new System.Drawing.Size(40, 19);
            this.Data_Cadastro.TabIndex = 95;
            this.Data_Cadastro.Text = "Data";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 266);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 19);
            this.label16.TabIndex = 99;
            this.label16.Text = "VALOR CUSTO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(338, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 19);
            this.label10.TabIndex = 101;
            this.label10.Text = "*VALOR VENDA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(193, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 19);
            this.label12.TabIndex = 103;
            this.label12.Text = "Margem de Lucro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 329);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 108;
            this.label14.Text = "Observação:";
            // 
            // Tb_Observacao
            // 
            this.Tb_Observacao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Observacao.Location = new System.Drawing.Point(12, 352);
            this.Tb_Observacao.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Observacao.MaxLength = 255;
            this.Tb_Observacao.Multiline = true;
            this.Tb_Observacao.Name = "Tb_Observacao";
            this.Tb_Observacao.Size = new System.Drawing.Size(561, 54);
            this.Tb_Observacao.TabIndex = 8;
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(656, 436);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(110, 40);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(18, 433);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(110, 40);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(404, 447);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 19);
            this.label15.TabIndex = 109;
            this.label15.Text = "PREENCHA todos os campos *";
            // 
            // Tb_Nome
            // 
            this.Tb_Nome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Nome.Location = new System.Drawing.Point(12, 158);
            this.Tb_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Nome.MaxLength = 60;
            this.Tb_Nome.Name = "Tb_Nome";
            this.Tb_Nome.Size = new System.Drawing.Size(142, 27);
            this.Tb_Nome.TabIndex = 0;
            // 
            // Tb_Estoque
            // 
            this.Tb_Estoque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Estoque.Location = new System.Drawing.Point(197, 158);
            this.Tb_Estoque.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Estoque.MaxLength = 5;
            this.Tb_Estoque.Name = "Tb_Estoque";
            this.Tb_Estoque.Size = new System.Drawing.Size(95, 27);
            this.Tb_Estoque.TabIndex = 1;
            this.Tb_Estoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Estoque_KeyPress);
            // 
            // Tb_Lucro
            // 
            this.Tb_Lucro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Lucro.Location = new System.Drawing.Point(197, 289);
            this.Tb_Lucro.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Lucro.MaxLength = 3;
            this.Tb_Lucro.Name = "Tb_Lucro";
            this.Tb_Lucro.Size = new System.Drawing.Size(36, 27);
            this.Tb_Lucro.TabIndex = 6;
            this.Tb_Lucro.TextChanged += new System.EventHandler(this.Tb_Lucro_TextChanged);
            this.Tb_Lucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Lucro_KeyPress_1);
            // 
            // Tb_Custo
            // 
            this.Tb_Custo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Custo.Location = new System.Drawing.Point(12, 289);
            this.Tb_Custo.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Custo.MaxLength = 7;
            this.Tb_Custo.Name = "Tb_Custo";
            this.Tb_Custo.Size = new System.Drawing.Size(142, 27);
            this.Tb_Custo.TabIndex = 5;
            this.Tb_Custo.TextChanged += new System.EventHandler(this.Tb_Custo_TextChanged);
            this.Tb_Custo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Custo_KeyPress);
            // 
            // Tb_Venda
            // 
            this.Tb_Venda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Venda.Location = new System.Drawing.Point(342, 289);
            this.Tb_Venda.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Venda.MaxLength = 7;
            this.Tb_Venda.Name = "Tb_Venda";
            this.Tb_Venda.Size = new System.Drawing.Size(142, 27);
            this.Tb_Venda.TabIndex = 7;
            this.Tb_Venda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Venda_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(234, 292);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 18);
            this.label11.TabIndex = 127;
            this.label11.Text = " %";
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(268, 433);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 40);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "      Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Enabled = false;
            this.btAtualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizar.Location = new System.Drawing.Point(141, 433);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(110, 40);
            this.btAtualizar.TabIndex = 10;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Tb_Venda);
            this.Controls.Add(this.Tb_Custo);
            this.Controls.Add(this.Tb_Lucro);
            this.Controls.Add(this.Tb_Estoque);
            this.Controls.Add(this.Tb_Nome);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Tb_Observacao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.Data_Cadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_Marca);
            this.Controls.Add(this.Cb_fornecedor);
            this.Controls.Add(this.Cb_Categoria);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox Cb_Categoria;
        public System.Windows.Forms.ComboBox Cb_fornecedor;
        public System.Windows.Forms.ComboBox Cb_Marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.CheckBox cbStatus;
        public System.Windows.Forms.Label Data_Cadastro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox Tb_Observacao;
        public System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox Tb_Nome;
        public System.Windows.Forms.TextBox Tb_Estoque;
        public System.Windows.Forms.TextBox Tb_Lucro;
        public System.Windows.Forms.TextBox Tb_Custo;
        public System.Windows.Forms.TextBox Tb_Venda;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label LbTitulo;
        public System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
    }
}