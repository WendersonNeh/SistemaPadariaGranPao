namespace SistemaPadariaGranPao
{
    partial class formRelFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelFuncionario));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbSetor = new System.Windows.Forms.GroupBox();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbDataAdmissao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rptvFornecedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClassFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnTituloFuncionario.SuspendLayout();
            this.gbSetor.SuspendLayout();
            this.gbDataAdmissao.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassFornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(12, 12);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(784, 34);
            this.pnTituloFuncionario.TabIndex = 69;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(297, 3);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(222, 26);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatório de Fornecedor";
            // 
            // gbSetor
            // 
            this.gbSetor.Controls.Add(this.cbSetor);
            this.gbSetor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSetor.Location = new System.Drawing.Point(466, 103);
            this.gbSetor.Name = "gbSetor";
            this.gbSetor.Size = new System.Drawing.Size(80, 66);
            this.gbSetor.TabIndex = 103;
            this.gbSetor.TabStop = false;
            this.gbSetor.Text = "Estado:";
            // 
            // cbSetor
            // 
            this.cbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(9, 25);
            this.cbSetor.Margin = new System.Windows.Forms.Padding(4);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(46, 27);
            this.cbSetor.TabIndex = 66;
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(709, 47);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(87, 50);
            this.btSair.TabIndex = 107;
            this.btSair.Text = "     Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(524, 47);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(176, 50);
            this.btGerarRelatorio.TabIndex = 106;
            this.btGerarRelatorio.Text = "     Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbDataAdmissao
            // 
            this.gbDataAdmissao.Controls.Add(this.label6);
            this.gbDataAdmissao.Controls.Add(this.label8);
            this.gbDataAdmissao.Controls.Add(this.dtpDataFinal);
            this.gbDataAdmissao.Controls.Add(this.dtpDataInicial);
            this.gbDataAdmissao.Location = new System.Drawing.Point(21, 103);
            this.gbDataAdmissao.Name = "gbDataAdmissao";
            this.gbDataAdmissao.Size = new System.Drawing.Size(174, 115);
            this.gbDataAdmissao.TabIndex = 100;
            this.gbDataAdmissao.TabStop = false;
            this.gbDataAdmissao.Text = "Data de Cadastro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Até:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "De:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(46, 71);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(116, 27);
            this.dtpDataFinal.TabIndex = 1;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(47, 28);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(116, 27);
            this.dtpDataInicial.TabIndex = 0;
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(264, 59);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(244, 27);
            this.cbTipoRel.TabIndex = 105;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 23);
            this.label9.TabIndex = 104;
            this.label9.Text = "Selecione o Tipo de Relatório:";
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.cbCidade);
            this.gbCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCidade.Location = new System.Drawing.Point(201, 103);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(250, 66);
            this.gbCidade.TabIndex = 101;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "Cidade:";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(9, 25);
            this.cbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(233, 27);
            this.cbCidade.TabIndex = 66;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(701, 103);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(87, 108);
            this.gbStatus.TabIndex = 96;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(9, 73);
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
            this.rbAtivo.Location = new System.Drawing.Point(9, 30);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(60, 23);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rptvFornecedor
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ClassFornecedorBindingSource;
            this.rptvFornecedor.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvFornecedor.LocalReport.ReportEmbeddedResource = "SistemaPadariaGranPao.RepFornecedor.rdlc";
            this.rptvFornecedor.Location = new System.Drawing.Point(131, 344);
            this.rptvFornecedor.Name = "rptvFornecedor";
            this.rptvFornecedor.ServerReport.BearerToken = null;
            this.rptvFornecedor.Size = new System.Drawing.Size(560, 195);
            this.rptvFornecedor.TabIndex = 108;
            // 
            // ClassFornecedorBindingSource
            // 
            this.ClassFornecedorBindingSource.DataSource = typeof(SistemaPadariaGranPao.ClassFornecedor);
            // 
            // formRelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 684);
            this.Controls.Add(this.rptvFornecedor);
            this.Controls.Add(this.gbSetor);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbDataAdmissao);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbCidade);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelFuncionario";
            this.Load += new System.EventHandler(this.formRelFuncionario_Load);
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbSetor.ResumeLayout(false);
            this.gbDataAdmissao.ResumeLayout(false);
            this.gbDataAdmissao.PerformLayout();
            this.gbCidade.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassFornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbSetor;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbDataAdmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private Microsoft.Reporting.WinForms.ReportViewer rptvFornecedor;
        private System.Windows.Forms.BindingSource ClassFornecedorBindingSource;
    }
}