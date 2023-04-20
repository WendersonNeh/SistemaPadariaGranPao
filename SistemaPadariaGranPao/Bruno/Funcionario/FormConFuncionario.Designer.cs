
namespace SistemaPadariaGranPao
{
    partial class FormConFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConFuncionario));
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.GbConsFuncionario = new System.Windows.Forms.GroupBox();
            this.GbStatus = new System.Windows.Forms.GroupBox();
            this.RbInativo = new System.Windows.Forms.RadioButton();
            this.RbAtivo = new System.Windows.Forms.RadioButton();
            this.GbOpcao = new System.Windows.Forms.GroupBox();
            this.CbOpcoes = new System.Windows.Forms.ComboBox();
            this.GbCPF = new System.Windows.Forms.GroupBox();
            this.MskCpf = new System.Windows.Forms.MaskedTextBox();
            this.GbNome = new System.Windows.Forms.GroupBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.GbDepartamento = new System.Windows.Forms.GroupBox();
            this.CbDepartamento = new System.Windows.Forms.ComboBox();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.BtSair = new System.Windows.Forms.Button();
            this.GbCargo = new System.Windows.Forms.GroupBox();
            this.CbCargo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DgvFuncionario = new System.Windows.Forms.DataGridView();
            this.pnTituloFuncionario.SuspendLayout();
            this.GbConsFuncionario.SuspendLayout();
            this.GbStatus.SuspendLayout();
            this.GbOpcao.SuspendLayout();
            this.GbCPF.SuspendLayout();
            this.GbNome.SuspendLayout();
            this.GbDepartamento.SuspendLayout();
            this.GbCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(12, 3);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(728, 34);
            this.pnTituloFuncionario.TabIndex = 70;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(260, 4);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(227, 26);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Consulta de Funcionários";
            // 
            // GbConsFuncionario
            // 
            this.GbConsFuncionario.Controls.Add(this.GbStatus);
            this.GbConsFuncionario.Controls.Add(this.GbOpcao);
            this.GbConsFuncionario.Controls.Add(this.GbCPF);
            this.GbConsFuncionario.Controls.Add(this.GbNome);
            this.GbConsFuncionario.Controls.Add(this.GbDepartamento);
            this.GbConsFuncionario.Controls.Add(this.BtPesquisar);
            this.GbConsFuncionario.Controls.Add(this.BtSair);
            this.GbConsFuncionario.Controls.Add(this.GbCargo);
            this.GbConsFuncionario.Controls.Add(this.label10);
            this.GbConsFuncionario.Controls.Add(this.DgvFuncionario);
            this.GbConsFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbConsFuncionario.Location = new System.Drawing.Point(12, 34);
            this.GbConsFuncionario.Name = "GbConsFuncionario";
            this.GbConsFuncionario.Size = new System.Drawing.Size(728, 608);
            this.GbConsFuncionario.TabIndex = 69;
            this.GbConsFuncionario.TabStop = false;
            // 
            // GbStatus
            // 
            this.GbStatus.Controls.Add(this.RbInativo);
            this.GbStatus.Controls.Add(this.RbAtivo);
            this.GbStatus.Location = new System.Drawing.Point(243, 20);
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
            this.CbOpcoes.SelectedIndexChanged += new System.EventHandler(this.CbOpcoes_SelectedIndexChanged);
            // 
            // GbCPF
            // 
            this.GbCPF.Controls.Add(this.MskCpf);
            this.GbCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCPF.Location = new System.Drawing.Point(420, 26);
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
            this.GbNome.Size = new System.Drawing.Size(546, 60);
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
            this.TbNome.Size = new System.Drawing.Size(531, 27);
            this.TbNome.TabIndex = 2;
            // 
            // GbDepartamento
            // 
            this.GbDepartamento.Controls.Add(this.CbDepartamento);
            this.GbDepartamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDepartamento.Location = new System.Drawing.Point(298, 153);
            this.GbDepartamento.Name = "GbDepartamento";
            this.GbDepartamento.Size = new System.Drawing.Size(260, 60);
            this.GbDepartamento.TabIndex = 105;
            this.GbDepartamento.TabStop = false;
            this.GbDepartamento.Text = "Departamento:";
            // 
            // CbDepartamento
            // 
            this.CbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDepartamento.FormattingEnabled = true;
            this.CbDepartamento.Location = new System.Drawing.Point(6, 23);
            this.CbDepartamento.Name = "CbDepartamento";
            this.CbDepartamento.Size = new System.Drawing.Size(245, 27);
            this.CbDepartamento.TabIndex = 50;
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtPesquisar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtPesquisar.Image")));
            this.BtPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtPesquisar.Location = new System.Drawing.Point(589, 36);
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
            this.BtSair.Location = new System.Drawing.Point(589, 97);
            this.BtSair.Name = "BtSair";
            this.BtSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtSair.Size = new System.Drawing.Size(121, 50);
            this.BtSair.TabIndex = 108;
            this.BtSair.Text = "Sair";
            this.BtSair.UseVisualStyleBackColor = true;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // GbCargo
            // 
            this.GbCargo.Controls.Add(this.CbCargo);
            this.GbCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCargo.Location = new System.Drawing.Point(12, 153);
            this.GbCargo.Name = "GbCargo";
            this.GbCargo.Size = new System.Drawing.Size(271, 60);
            this.GbCargo.TabIndex = 104;
            this.GbCargo.TabStop = false;
            this.GbCargo.Text = "Cargo:";
            // 
            // CbCargo
            // 
            this.CbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCargo.FormattingEnabled = true;
            this.CbCargo.Location = new System.Drawing.Point(6, 23);
            this.CbCargo.Name = "CbCargo";
            this.CbCargo.Size = new System.Drawing.Size(250, 27);
            this.CbCargo.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(159, 219);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(426, 21);
            this.label10.TabIndex = 100;
            this.label10.Text = "Para alterar ou excluir  um funcionário, selecione na grid!!!";
            // 
            // DgvFuncionario
            // 
            this.DgvFuncionario.AllowUserToAddRows = false;
            this.DgvFuncionario.AllowUserToDeleteRows = false;
            this.DgvFuncionario.AllowUserToResizeColumns = false;
            this.DgvFuncionario.AllowUserToResizeRows = false;
            this.DgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionario.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DgvFuncionario.Location = new System.Drawing.Point(12, 249);
            this.DgvFuncionario.MultiSelect = false;
            this.DgvFuncionario.Name = "DgvFuncionario";
            this.DgvFuncionario.ReadOnly = true;
            this.DgvFuncionario.RowHeadersVisible = false;
            this.DgvFuncionario.RowHeadersWidth = 51;
            this.DgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionario.Size = new System.Drawing.Size(705, 348);
            this.DgvFuncionario.TabIndex = 48;
            this.DgvFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFuncionario_CellDoubleClick);
            // 
            // FormConFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 654);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Controls.Add(this.GbConsFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConFuncionario";
            this.ShowInTaskbar = false;
            this.Text = "FormConFuncionario";
            this.Load += new System.EventHandler(this.FormConFuncionario_Load);
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.GbConsFuncionario.ResumeLayout(false);
            this.GbConsFuncionario.PerformLayout();
            this.GbStatus.ResumeLayout(false);
            this.GbStatus.PerformLayout();
            this.GbOpcao.ResumeLayout(false);
            this.GbCPF.ResumeLayout(false);
            this.GbCPF.PerformLayout();
            this.GbNome.ResumeLayout(false);
            this.GbNome.PerformLayout();
            this.GbDepartamento.ResumeLayout(false);
            this.GbCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).EndInit();
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
        private System.Windows.Forms.GroupBox GbDepartamento;
        private System.Windows.Forms.ComboBox CbDepartamento;
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.Button BtSair;
        private System.Windows.Forms.GroupBox GbCargo;
        private System.Windows.Forms.ComboBox CbCargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgvFuncionario;
    }
}