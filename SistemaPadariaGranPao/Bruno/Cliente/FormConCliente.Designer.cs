
namespace SistemaPadariaGranPao
{
    partial class FormConCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConCliente));
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.GbConsFuncionario = new System.Windows.Forms.GroupBox();
            this.GbCep = new System.Windows.Forms.GroupBox();
            this.MskCep = new System.Windows.Forms.MaskedTextBox();
            this.GbRazaoSocial = new System.Windows.Forms.GroupBox();
            this.TbRazaoSocial = new System.Windows.Forms.TextBox();
            this.GbNomeFantasia = new System.Windows.Forms.GroupBox();
            this.TbNomeFantasia = new System.Windows.Forms.TextBox();
            this.GbCNPJ = new System.Windows.Forms.GroupBox();
            this.MskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.GbTipo = new System.Windows.Forms.GroupBox();
            this.RbJuridico = new System.Windows.Forms.RadioButton();
            this.RbFisico = new System.Windows.Forms.RadioButton();
            this.GbStatus = new System.Windows.Forms.GroupBox();
            this.RbInativo = new System.Windows.Forms.RadioButton();
            this.RbAtivo = new System.Windows.Forms.RadioButton();
            this.GbOpcao = new System.Windows.Forms.GroupBox();
            this.CbOpcoes = new System.Windows.Forms.ComboBox();
            this.GbCPF = new System.Windows.Forms.GroupBox();
            this.MskCpf = new System.Windows.Forms.MaskedTextBox();
            this.GbNome = new System.Windows.Forms.GroupBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.GbEstado = new System.Windows.Forms.GroupBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.BtSair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.pnTituloFuncionario.SuspendLayout();
            this.GbConsFuncionario.SuspendLayout();
            this.GbCep.SuspendLayout();
            this.GbRazaoSocial.SuspendLayout();
            this.GbNomeFantasia.SuspendLayout();
            this.GbCNPJ.SuspendLayout();
            this.GbTipo.SuspendLayout();
            this.GbStatus.SuspendLayout();
            this.GbOpcao.SuspendLayout();
            this.GbCPF.SuspendLayout();
            this.GbNome.SuspendLayout();
            this.GbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(12, 12);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(938, 34);
            this.pnTituloFuncionario.TabIndex = 72;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(345, 2);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(187, 26);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Consulta de Clientes";
            // 
            // GbConsFuncionario
            // 
            this.GbConsFuncionario.Controls.Add(this.GbCep);
            this.GbConsFuncionario.Controls.Add(this.GbRazaoSocial);
            this.GbConsFuncionario.Controls.Add(this.GbNomeFantasia);
            this.GbConsFuncionario.Controls.Add(this.GbCNPJ);
            this.GbConsFuncionario.Controls.Add(this.GbTipo);
            this.GbConsFuncionario.Controls.Add(this.GbStatus);
            this.GbConsFuncionario.Controls.Add(this.GbOpcao);
            this.GbConsFuncionario.Controls.Add(this.GbCPF);
            this.GbConsFuncionario.Controls.Add(this.GbNome);
            this.GbConsFuncionario.Controls.Add(this.GbEstado);
            this.GbConsFuncionario.Controls.Add(this.BtPesquisar);
            this.GbConsFuncionario.Controls.Add(this.BtSair);
            this.GbConsFuncionario.Controls.Add(this.label10);
            this.GbConsFuncionario.Controls.Add(this.DgvCliente);
            this.GbConsFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbConsFuncionario.Location = new System.Drawing.Point(12, 43);
            this.GbConsFuncionario.Name = "GbConsFuncionario";
            this.GbConsFuncionario.Size = new System.Drawing.Size(938, 608);
            this.GbConsFuncionario.TabIndex = 71;
            this.GbConsFuncionario.TabStop = false;
            // 
            // GbCep
            // 
            this.GbCep.Controls.Add(this.MskCep);
            this.GbCep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCep.Location = new System.Drawing.Point(434, 156);
            this.GbCep.Name = "GbCep";
            this.GbCep.Size = new System.Drawing.Size(96, 60);
            this.GbCep.TabIndex = 106;
            this.GbCep.TabStop = false;
            this.GbCep.Text = "CEP";
            // 
            // MskCep
            // 
            this.MskCep.Location = new System.Drawing.Point(6, 26);
            this.MskCep.Mask = "00000-000";
            this.MskCep.Name = "MskCep";
            this.MskCep.Size = new System.Drawing.Size(81, 27);
            this.MskCep.TabIndex = 22;
            // 
            // GbRazaoSocial
            // 
            this.GbRazaoSocial.Controls.Add(this.TbRazaoSocial);
            this.GbRazaoSocial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRazaoSocial.Location = new System.Drawing.Point(12, 156);
            this.GbRazaoSocial.Name = "GbRazaoSocial";
            this.GbRazaoSocial.Size = new System.Drawing.Size(393, 60);
            this.GbRazaoSocial.TabIndex = 108;
            this.GbRazaoSocial.TabStop = false;
            this.GbRazaoSocial.Text = "Razão Social";
            // 
            // TbRazaoSocial
            // 
            this.TbRazaoSocial.Location = new System.Drawing.Point(6, 23);
            this.TbRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbRazaoSocial.MaxLength = 50;
            this.TbRazaoSocial.Name = "TbRazaoSocial";
            this.TbRazaoSocial.Size = new System.Drawing.Size(376, 27);
            this.TbRazaoSocial.TabIndex = 2;
            // 
            // GbNomeFantasia
            // 
            this.GbNomeFantasia.Controls.Add(this.TbNomeFantasia);
            this.GbNomeFantasia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNomeFantasia.Location = new System.Drawing.Point(412, 87);
            this.GbNomeFantasia.Name = "GbNomeFantasia";
            this.GbNomeFantasia.Size = new System.Drawing.Size(393, 60);
            this.GbNomeFantasia.TabIndex = 107;
            this.GbNomeFantasia.TabStop = false;
            this.GbNomeFantasia.Text = "Nome Fantasia:";
            // 
            // TbNomeFantasia
            // 
            this.TbNomeFantasia.Location = new System.Drawing.Point(6, 23);
            this.TbNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbNomeFantasia.MaxLength = 50;
            this.TbNomeFantasia.Name = "TbNomeFantasia";
            this.TbNomeFantasia.Size = new System.Drawing.Size(376, 27);
            this.TbNomeFantasia.TabIndex = 2;
            // 
            // GbCNPJ
            // 
            this.GbCNPJ.Controls.Add(this.MskCNPJ);
            this.GbCNPJ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCNPJ.Location = new System.Drawing.Point(718, 26);
            this.GbCNPJ.Name = "GbCNPJ";
            this.GbCNPJ.Size = new System.Drawing.Size(163, 60);
            this.GbCNPJ.TabIndex = 108;
            this.GbCNPJ.TabStop = false;
            this.GbCNPJ.Text = "CNPJ";
            // 
            // MskCNPJ
            // 
            this.MskCNPJ.Location = new System.Drawing.Point(6, 23);
            this.MskCNPJ.Mask = "000,000,000-00";
            this.MskCNPJ.Name = "MskCNPJ";
            this.MskCNPJ.Size = new System.Drawing.Size(151, 27);
            this.MskCNPJ.TabIndex = 103;
            // 
            // GbTipo
            // 
            this.GbTipo.Controls.Add(this.RbJuridico);
            this.GbTipo.Controls.Add(this.RbFisico);
            this.GbTipo.Location = new System.Drawing.Point(236, 21);
            this.GbTipo.Name = "GbTipo";
            this.GbTipo.Size = new System.Drawing.Size(158, 60);
            this.GbTipo.TabIndex = 103;
            this.GbTipo.TabStop = false;
            this.GbTipo.Text = "Tipo:";
            // 
            // RbJuridico
            // 
            this.RbJuridico.AutoSize = true;
            this.RbJuridico.Location = new System.Drawing.Point(77, 27);
            this.RbJuridico.Name = "RbJuridico";
            this.RbJuridico.Size = new System.Drawing.Size(76, 23);
            this.RbJuridico.TabIndex = 2;
            this.RbJuridico.Text = "Juridico";
            this.RbJuridico.UseVisualStyleBackColor = true;
            // 
            // RbFisico
            // 
            this.RbFisico.AutoSize = true;
            this.RbFisico.Checked = true;
            this.RbFisico.Location = new System.Drawing.Point(12, 27);
            this.RbFisico.Name = "RbFisico";
            this.RbFisico.Size = new System.Drawing.Size(64, 23);
            this.RbFisico.TabIndex = 1;
            this.RbFisico.TabStop = true;
            this.RbFisico.Text = "Fisico";
            this.RbFisico.UseVisualStyleBackColor = true;
            // 
            // GbStatus
            // 
            this.GbStatus.Controls.Add(this.RbInativo);
            this.GbStatus.Controls.Add(this.RbAtivo);
            this.GbStatus.Location = new System.Drawing.Point(400, 21);
            this.GbStatus.Name = "GbStatus";
            this.GbStatus.Size = new System.Drawing.Size(158, 60);
            this.GbStatus.TabIndex = 102;
            this.GbStatus.TabStop = false;
            this.GbStatus.Text = "Status:";
            // 
            // RbInativo
            // 
            this.RbInativo.AutoSize = true;
            this.RbInativo.Location = new System.Drawing.Point(77, 27);
            this.RbInativo.Name = "RbInativo";
            this.RbInativo.Size = new System.Drawing.Size(71, 23);
            this.RbInativo.TabIndex = 2;
            this.RbInativo.Text = "Inativo";
            this.RbInativo.UseVisualStyleBackColor = true;
            // 
            // RbAtivo
            // 
            this.RbAtivo.AutoSize = true;
            this.RbAtivo.Checked = true;
            this.RbAtivo.Location = new System.Drawing.Point(12, 27);
            this.RbAtivo.Name = "RbAtivo";
            this.RbAtivo.Size = new System.Drawing.Size(60, 23);
            this.RbAtivo.TabIndex = 1;
            this.RbAtivo.TabStop = true;
            this.RbAtivo.Text = "Ativo";
            this.RbAtivo.UseVisualStyleBackColor = true;
            // 
            // GbOpcao
            // 
            this.GbOpcao.Controls.Add(this.CbOpcoes);
            this.GbOpcao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbOpcao.Location = new System.Drawing.Point(12, 20);
            this.GbOpcao.Name = "GbOpcao";
            this.GbOpcao.Size = new System.Drawing.Size(206, 60);
            this.GbOpcao.TabIndex = 107;
            this.GbOpcao.TabStop = false;
            this.GbOpcao.Text = "Escolha uma Opção:";
            // 
            // CbOpcoes
            // 
            this.CbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOpcoes.FormattingEnabled = true;
            this.CbOpcoes.Location = new System.Drawing.Point(6, 25);
            this.CbOpcoes.Name = "CbOpcoes";
            this.CbOpcoes.Size = new System.Drawing.Size(194, 27);
            this.CbOpcoes.TabIndex = 8;
            this.CbOpcoes.SelectedValueChanged += new System.EventHandler(this.CbOpcoes_SelectedValueChanged);
            // 
            // GbCPF
            // 
            this.GbCPF.Controls.Add(this.MskCpf);
            this.GbCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCPF.Location = new System.Drawing.Point(564, 26);
            this.GbCPF.Name = "GbCPF";
            this.GbCPF.Size = new System.Drawing.Size(138, 60);
            this.GbCPF.TabIndex = 107;
            this.GbCPF.TabStop = false;
            this.GbCPF.Text = "CPF:";
            // 
            // MskCpf
            // 
            this.MskCpf.Location = new System.Drawing.Point(6, 23);
            this.MskCpf.Mask = "000,000,000-00";
            this.MskCpf.Name = "MskCpf";
            this.MskCpf.Size = new System.Drawing.Size(123, 27);
            this.MskCpf.TabIndex = 103;
            // 
            // GbNome
            // 
            this.GbNome.Controls.Add(this.TbNome);
            this.GbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNome.Location = new System.Drawing.Point(12, 87);
            this.GbNome.Name = "GbNome";
            this.GbNome.Size = new System.Drawing.Size(393, 60);
            this.GbNome.TabIndex = 106;
            this.GbNome.TabStop = false;
            this.GbNome.Text = "Nome:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(6, 23);
            this.TbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbNome.MaxLength = 50;
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(376, 27);
            this.TbNome.TabIndex = 2;
            // 
            // GbEstado
            // 
            this.GbEstado.Controls.Add(this.CbEstado);
            this.GbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEstado.Location = new System.Drawing.Point(550, 156);
            this.GbEstado.Name = "GbEstado";
            this.GbEstado.Size = new System.Drawing.Size(114, 60);
            this.GbEstado.TabIndex = 105;
            this.GbEstado.TabStop = false;
            this.GbEstado.Text = "Estado:";
            // 
            // CbEstado
            // 
            this.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(6, 23);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(102, 27);
            this.CbEstado.TabIndex = 50;
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtPesquisar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtPesquisar.Image")));
            this.BtPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtPesquisar.Location = new System.Drawing.Point(811, 97);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtPesquisar.Size = new System.Drawing.Size(121, 50);
            this.BtPesquisar.TabIndex = 111;
            this.BtPesquisar.Text = "Pesquisar";
            this.BtPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtPesquisar.UseVisualStyleBackColor = true;
            this.BtPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // BtSair
            // 
            this.BtSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSair.Image = ((System.Drawing.Image)(resources.GetObject("BtSair.Image")));
            this.BtSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSair.Location = new System.Drawing.Point(811, 153);
            this.BtSair.Name = "BtSair";
            this.BtSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtSair.Size = new System.Drawing.Size(121, 50);
            this.BtSair.TabIndex = 108;
            this.BtSair.Text = "Sair";
            this.BtSair.UseVisualStyleBackColor = true;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(272, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(392, 21);
            this.label10.TabIndex = 100;
            this.label10.Text = "Para alterar ou excluir  um cliente, selecione na grid!!!";
            // 
            // DgvCliente
            // 
            this.DgvCliente.AllowUserToAddRows = false;
            this.DgvCliente.AllowUserToDeleteRows = false;
            this.DgvCliente.AllowUserToResizeColumns = false;
            this.DgvCliente.AllowUserToResizeRows = false;
            this.DgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DgvCliente.Location = new System.Drawing.Point(6, 249);
            this.DgvCliente.MultiSelect = false;
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.ReadOnly = true;
            this.DgvCliente.RowHeadersVisible = false;
            this.DgvCliente.RowHeadersWidth = 51;
            this.DgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCliente.Size = new System.Drawing.Size(926, 348);
            this.DgvCliente.TabIndex = 48;
            this.DgvCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliente_CellContentDoubleClick);
            // 
            // FormConCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 661);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Controls.Add(this.GbConsFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConCliente";
            this.Text = "FormConCliente";
            this.Load += new System.EventHandler(this.FormConCliente_Load);
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.GbConsFuncionario.ResumeLayout(false);
            this.GbConsFuncionario.PerformLayout();
            this.GbCep.ResumeLayout(false);
            this.GbCep.PerformLayout();
            this.GbRazaoSocial.ResumeLayout(false);
            this.GbRazaoSocial.PerformLayout();
            this.GbNomeFantasia.ResumeLayout(false);
            this.GbNomeFantasia.PerformLayout();
            this.GbCNPJ.ResumeLayout(false);
            this.GbCNPJ.PerformLayout();
            this.GbTipo.ResumeLayout(false);
            this.GbTipo.PerformLayout();
            this.GbStatus.ResumeLayout(false);
            this.GbStatus.PerformLayout();
            this.GbOpcao.ResumeLayout(false);
            this.GbCPF.ResumeLayout(false);
            this.GbCPF.PerformLayout();
            this.GbNome.ResumeLayout(false);
            this.GbNome.PerformLayout();
            this.GbEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox GbConsFuncionario;
        private System.Windows.Forms.GroupBox GbStatus;
        private System.Windows.Forms.RadioButton RbInativo;
        private System.Windows.Forms.RadioButton RbAtivo;
        private System.Windows.Forms.GroupBox GbOpcao;
        private System.Windows.Forms.ComboBox CbOpcoes;
        private System.Windows.Forms.GroupBox GbCPF;
        public System.Windows.Forms.MaskedTextBox MskCpf;
        private System.Windows.Forms.GroupBox GbNome;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.GroupBox GbEstado;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.Button BtSair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgvCliente;
        private System.Windows.Forms.GroupBox GbNomeFantasia;
        private System.Windows.Forms.TextBox TbNomeFantasia;
        private System.Windows.Forms.GroupBox GbCNPJ;
        public System.Windows.Forms.MaskedTextBox MskCNPJ;
        private System.Windows.Forms.GroupBox GbTipo;
        private System.Windows.Forms.RadioButton RbJuridico;
        private System.Windows.Forms.RadioButton RbFisico;
        private System.Windows.Forms.GroupBox GbRazaoSocial;
        private System.Windows.Forms.TextBox TbRazaoSocial;
        private System.Windows.Forms.GroupBox GbCep;
        public System.Windows.Forms.MaskedTextBox MskCep;
    }
}