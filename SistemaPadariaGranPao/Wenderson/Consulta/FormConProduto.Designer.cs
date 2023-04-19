
namespace SistemaPadariaGranPao
{
    partial class FormConProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConProduto));
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbConsFuncionario = new System.Windows.Forms.GroupBox();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.tbVenda = new System.Windows.Forms.TextBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.gbNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.Cb_Marca = new System.Windows.Forms.ComboBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.gbFernecedor = new System.Windows.Forms.GroupBox();
            this.Cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.Cb_Categoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbConsFuncionario.SuspendLayout();
            this.gbVenda.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbNome.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.gbFernecedor.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(30, 6);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(741, 42);
            this.pnTituloFuncionario.TabIndex = 72;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(260, 4);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(187, 26);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Consulta de Produto";
            // 
            // gbConsFuncionario
            // 
            this.gbConsFuncionario.Controls.Add(this.gbVenda);
            this.gbConsFuncionario.Controls.Add(this.gbStatus);
            this.gbConsFuncionario.Controls.Add(this.gbOpcao);
            this.gbConsFuncionario.Controls.Add(this.gbNome);
            this.gbConsFuncionario.Controls.Add(this.gbMarca);
            this.gbConsFuncionario.Controls.Add(this.btPesquisar);
            this.gbConsFuncionario.Controls.Add(this.btSair);
            this.gbConsFuncionario.Controls.Add(this.gbFernecedor);
            this.gbConsFuncionario.Controls.Add(this.gbTipoPesquisa);
            this.gbConsFuncionario.Controls.Add(this.gbCategoria);
            this.gbConsFuncionario.Controls.Add(this.label10);
            this.gbConsFuncionario.Controls.Add(this.dgvFuncionario);
            this.gbConsFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsFuncionario.Location = new System.Drawing.Point(30, 37);
            this.gbConsFuncionario.Name = "gbConsFuncionario";
            this.gbConsFuncionario.Size = new System.Drawing.Size(741, 611);
            this.gbConsFuncionario.TabIndex = 71;
            this.gbConsFuncionario.TabStop = false;
            // 
            // gbVenda
            // 
            this.gbVenda.Controls.Add(this.tbVenda);
            this.gbVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVenda.Location = new System.Drawing.Point(403, 21);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(123, 60);
            this.gbVenda.TabIndex = 112;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Valor Venda:";
            // 
            // tbVenda
            // 
            this.tbVenda.Location = new System.Drawing.Point(6, 23);
            this.tbVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVenda.MaxLength = 50;
            this.tbVenda.Name = "tbVenda";
            this.tbVenda.Size = new System.Drawing.Size(111, 27);
            this.tbVenda.TabIndex = 2;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(547, 21);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(158, 60);
            this.gbStatus.TabIndex = 102;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(77, 27);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(71, 23);
            this.rbInativo.TabIndex = 2;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(12, 27);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(60, 23);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.cbOpcoes);
            this.gbOpcao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcao.Location = new System.Drawing.Point(12, 20);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(206, 60);
            this.gbOpcao.TabIndex = 107;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Escolha uma Opção:";
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(6, 25);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(194, 27);
            this.cbOpcoes.TabIndex = 8;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // gbNome
            // 
            this.gbNome.Controls.Add(this.txtNome);
            this.gbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNome.Location = new System.Drawing.Point(12, 87);
            this.gbNome.Name = "gbNome";
            this.gbNome.Size = new System.Drawing.Size(422, 60);
            this.gbNome.TabIndex = 106;
            this.gbNome.TabStop = false;
            this.gbNome.Text = "Nome Produto:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 23);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 27);
            this.txtNome.TabIndex = 2;
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.Cb_Marca);
            this.gbMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMarca.Location = new System.Drawing.Point(254, 153);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(217, 60);
            this.gbMarca.TabIndex = 105;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca:";
            // 
            // Cb_Marca
            // 
            this.Cb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Marca.FormattingEnabled = true;
            this.Cb_Marca.Location = new System.Drawing.Point(6, 23);
            this.Cb_Marca.Name = "Cb_Marca";
            this.Cb_Marca.Size = new System.Drawing.Size(205, 27);
            this.Cb_Marca.TabIndex = 50;
            // 
            // btPesquisar
            // 
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPesquisar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(457, 97);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btPesquisar.Size = new System.Drawing.Size(121, 50);
            this.btPesquisar.TabIndex = 111;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(584, 97);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(121, 50);
            this.btSair.TabIndex = 108;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // gbFernecedor
            // 
            this.gbFernecedor.Controls.Add(this.Cb_fornecedor);
            this.gbFernecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFernecedor.Location = new System.Drawing.Point(12, 153);
            this.gbFernecedor.Name = "gbFernecedor";
            this.gbFernecedor.Size = new System.Drawing.Size(217, 60);
            this.gbFernecedor.TabIndex = 104;
            this.gbFernecedor.TabStop = false;
            this.gbFernecedor.Text = "Fornecedor:";
            // 
            // Cb_fornecedor
            // 
            this.Cb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_fornecedor.FormattingEnabled = true;
            this.Cb_fornecedor.Location = new System.Drawing.Point(6, 23);
            this.Cb_fornecedor.Name = "Cb_fornecedor";
            this.Cb_fornecedor.Size = new System.Drawing.Size(200, 27);
            this.Cb_fornecedor.TabIndex = 50;
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbContem);
            this.gbTipoPesquisa.Controls.Add(this.rbInicio);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(234, 21);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(150, 60);
            this.gbTipoPesquisa.TabIndex = 102;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Location = new System.Drawing.Point(72, 27);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(77, 23);
            this.rbContem.TabIndex = 2;
            this.rbContem.Text = "Contém";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Checked = true;
            this.rbInicio.Location = new System.Drawing.Point(6, 27);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(62, 23);
            this.rbInicio.TabIndex = 1;
            this.rbInicio.TabStop = true;
            this.rbInicio.Text = "Início";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.Cb_Categoria);
            this.gbCategoria.Location = new System.Drawing.Point(486, 153);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(217, 60);
            this.gbCategoria.TabIndex = 101;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // Cb_Categoria
            // 
            this.Cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Categoria.FormattingEnabled = true;
            this.Cb_Categoria.Location = new System.Drawing.Point(6, 23);
            this.Cb_Categoria.Name = "Cb_Categoria";
            this.Cb_Categoria.Size = new System.Drawing.Size(200, 27);
            this.Cb_Categoria.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(152, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 21);
            this.label10.TabIndex = 100;
            this.label10.Text = "Para alterar ou excluir um produto, selecione na grid!!!";
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AllowUserToResizeColumns = false;
            this.dgvFuncionario.AllowUserToResizeRows = false;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFuncionario.Location = new System.Drawing.Point(5, 265);
            this.dgvFuncionario.MultiSelect = false;
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.RowHeadersWidth = 51;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(735, 332);
            this.dgvFuncionario.TabIndex = 48;
            this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            // 
            // FormConProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 690);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Controls.Add(this.gbConsFuncionario);
            this.Name = "FormConProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConProduto1";
            this.Load += new System.EventHandler(this.FormConProduto_Load);
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbConsFuncionario.ResumeLayout(false);
            this.gbConsFuncionario.PerformLayout();
            this.gbVenda.ResumeLayout(false);
            this.gbVenda.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbOpcao.ResumeLayout(false);
            this.gbNome.ResumeLayout(false);
            this.gbNome.PerformLayout();
            this.gbMarca.ResumeLayout(false);
            this.gbFernecedor.ResumeLayout(false);
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbConsFuncionario;
        private System.Windows.Forms.GroupBox gbVenda;
        private System.Windows.Forms.TextBox tbVenda;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.GroupBox gbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.ComboBox Cb_Marca;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox gbFernecedor;
        private System.Windows.Forms.ComboBox Cb_fornecedor;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox Cb_Categoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvFuncionario;
    }
}