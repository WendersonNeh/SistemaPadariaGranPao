
namespace SistemaPadariaGranPao
{
    partial class FormConMarcaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConMarcaCategoria));
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbConsFuncionario = new System.Windows.Forms.GroupBox();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.gbNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btPesquisarMarca = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSimples = new System.Windows.Forms.DataGridView();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbConsFuncionario.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimples)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(12, 2);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(724, 42);
            this.pnTituloFuncionario.TabIndex = 74;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(224, 7);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(273, 26);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Consulta de Marca / Categoria";
            // 
            // gbConsFuncionario
            // 
            this.gbConsFuncionario.Controls.Add(this.gbTipoPesquisa);
            this.gbConsFuncionario.Controls.Add(this.gbStatus);
            this.gbConsFuncionario.Controls.Add(this.gbOpcao);
            this.gbConsFuncionario.Controls.Add(this.gbNome);
            this.gbConsFuncionario.Controls.Add(this.btPesquisarMarca);
            this.gbConsFuncionario.Controls.Add(this.btSair);
            this.gbConsFuncionario.Controls.Add(this.label10);
            this.gbConsFuncionario.Controls.Add(this.dgvSimples);
            this.gbConsFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsFuncionario.Location = new System.Drawing.Point(12, 33);
            this.gbConsFuncionario.Name = "gbConsFuncionario";
            this.gbConsFuncionario.Size = new System.Drawing.Size(724, 532);
            this.gbConsFuncionario.TabIndex = 73;
            this.gbConsFuncionario.TabStop = false;
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbContem);
            this.gbTipoPesquisa.Controls.Add(this.rbInicio);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(293, 21);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(150, 60);
            this.gbTipoPesquisa.TabIndex = 112;
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
            this.gbNome.Size = new System.Drawing.Size(431, 60);
            this.gbNome.TabIndex = 106;
            this.gbNome.TabStop = false;
            this.gbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 23);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(419, 27);
            this.txtNome.TabIndex = 2;
            // 
            // btPesquisarMarca
            // 
            this.btPesquisarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPesquisarMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisarMarca.Image")));
            this.btPesquisarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisarMarca.Location = new System.Drawing.Point(457, 97);
            this.btPesquisarMarca.Name = "btPesquisarMarca";
            this.btPesquisarMarca.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btPesquisarMarca.Size = new System.Drawing.Size(121, 50);
            this.btPesquisarMarca.TabIndex = 111;
            this.btPesquisarMarca.Text = "Pesquisar";
            this.btPesquisarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisarMarca.UseVisualStyleBackColor = true;
            this.btPesquisarMarca.Click += new System.EventHandler(this.btPesquisarMarca_Click);
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
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(179, 161);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 21);
            this.label10.TabIndex = 100;
            this.label10.Text = "Para alterar ou excluir um produto, selecione na grid!!!";
            // 
            // dgvSimples
            // 
            this.dgvSimples.AllowUserToAddRows = false;
            this.dgvSimples.AllowUserToDeleteRows = false;
            this.dgvSimples.AllowUserToResizeColumns = false;
            this.dgvSimples.AllowUserToResizeRows = false;
            this.dgvSimples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSimples.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSimples.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSimples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimples.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSimples.Location = new System.Drawing.Point(12, 201);
            this.dgvSimples.MultiSelect = false;
            this.dgvSimples.Name = "dgvSimples";
            this.dgvSimples.ReadOnly = true;
            this.dgvSimples.RowHeadersVisible = false;
            this.dgvSimples.RowHeadersWidth = 51;
            this.dgvSimples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSimples.Size = new System.Drawing.Size(693, 317);
            this.dgvSimples.TabIndex = 48;
            // 
            // FormConMarcaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 572);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Controls.Add(this.gbConsFuncionario);
            this.Name = "FormConMarcaCategoria";
            this.Text = "FormConMarcaCategoria";
            this.Load += new System.EventHandler(this.FormConMarcaCategoria_Load);
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbConsFuncionario.ResumeLayout(false);
            this.gbConsFuncionario.PerformLayout();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbOpcao.ResumeLayout(false);
            this.gbNome.ResumeLayout(false);
            this.gbNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimples)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbConsFuncionario;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Button btPesquisarMarca;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSimples;
        private System.Windows.Forms.GroupBox gbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
    }
}