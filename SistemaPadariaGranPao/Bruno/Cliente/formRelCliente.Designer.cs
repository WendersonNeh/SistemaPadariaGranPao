
namespace SistemaPadariaGranPao
{
    partial class formRelCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelCliente));
            this.rptvFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.CbCidade = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbDataCadastro = new System.Windows.Forms.GroupBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbJuridico = new System.Windows.Forms.RadioButton();
            this.rbFisico = new System.Windows.Forms.RadioButton();
            this.GbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.CbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.gbEstado.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbDataCadastro.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.GbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptvFuncionario
            // 
            reportDataSource2.Name = "DSFuncionario";
            reportDataSource2.Value = null;
            this.rptvFuncionario.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvFuncionario.LocalReport.ReportEmbeddedResource = "SistemaPadariaGranPao.RptFuncionario.rdlc";
            this.rptvFuncionario.Location = new System.Drawing.Point(12, 293);
            this.rptvFuncionario.Name = "rptvFuncionario";
            this.rptvFuncionario.ServerReport.BearerToken = null;
            this.rptvFuncionario.Size = new System.Drawing.Size(787, 379);
            this.rptvFuncionario.TabIndex = 122;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.CbEstado);
            this.gbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.Location = new System.Drawing.Point(21, 221);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(251, 66);
            this.gbEstado.TabIndex = 116;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado:";
            // 
            // CbEstado
            // 
            this.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(9, 25);
            this.CbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(234, 27);
            this.CbEstado.TabIndex = 66;
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
            this.btSair.TabIndex = 121;
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
            this.btGerarRelatorio.TabIndex = 120;
            this.btGerarRelatorio.Text = "     Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(216, 103);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(114, 115);
            this.gbSexo.TabIndex = 111;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(9, 73);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(94, 23);
            this.rbMasculino.TabIndex = 2;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Checked = true;
            this.rbFeminino.Location = new System.Drawing.Point(9, 30);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(86, 23);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
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
            this.cbTipoRel.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 23);
            this.label9.TabIndex = 118;
            this.label9.Text = "Selecione o Tipo de Relatório:";
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.CbCidade);
            this.gbCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCidade.Location = new System.Drawing.Point(288, 221);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(250, 66);
            this.gbCidade.TabIndex = 115;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "Cidade:";
            // 
            // CbCidade
            // 
            this.CbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCidade.FormattingEnabled = true;
            this.CbCidade.Location = new System.Drawing.Point(9, 25);
            this.CbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.CbCidade.Name = "CbCidade";
            this.CbCidade.Size = new System.Drawing.Size(233, 27);
            this.CbCidade.TabIndex = 66;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(123, 103);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(87, 115);
            this.gbStatus.TabIndex = 110;
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
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(12, 12);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(784, 34);
            this.pnTituloFuncionario.TabIndex = 109;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(297, 3);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(192, 26);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatório de Clientes";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(47, 28);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(149, 27);
            this.dtpDataInicial.TabIndex = 0;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(46, 71);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(150, 27);
            this.dtpDataFinal.TabIndex = 1;
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
            // gbDataCadastro
            // 
            this.gbDataCadastro.Controls.Add(this.label6);
            this.gbDataCadastro.Controls.Add(this.label8);
            this.gbDataCadastro.Controls.Add(this.dtpDataFinal);
            this.gbDataCadastro.Controls.Add(this.dtpDataInicial);
            this.gbDataCadastro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataCadastro.Location = new System.Drawing.Point(338, 103);
            this.gbDataCadastro.Name = "gbDataCadastro";
            this.gbDataCadastro.Size = new System.Drawing.Size(202, 115);
            this.gbDataCadastro.TabIndex = 114;
            this.gbDataCadastro.TabStop = false;
            this.gbDataCadastro.Text = "Data Cadastro:";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbJuridico);
            this.gbTipo.Controls.Add(this.rbFisico);
            this.gbTipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.Location = new System.Drawing.Point(30, 103);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(87, 115);
            this.gbTipo.TabIndex = 123;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbJuridico
            // 
            this.rbJuridico.AutoSize = true;
            this.rbJuridico.Location = new System.Drawing.Point(6, 68);
            this.rbJuridico.Name = "rbJuridico";
            this.rbJuridico.Size = new System.Drawing.Size(76, 23);
            this.rbJuridico.TabIndex = 4;
            this.rbJuridico.Text = "Juridico";
            this.rbJuridico.UseVisualStyleBackColor = true;
            // 
            // rbFisico
            // 
            this.rbFisico.AutoSize = true;
            this.rbFisico.Checked = true;
            this.rbFisico.Location = new System.Drawing.Point(6, 36);
            this.rbFisico.Name = "rbFisico";
            this.rbFisico.Size = new System.Drawing.Size(64, 23);
            this.rbFisico.TabIndex = 3;
            this.rbFisico.TabStop = true;
            this.rbFisico.Text = "Fisico";
            this.rbFisico.UseVisualStyleBackColor = true;
            // 
            // GbEstadoCivil
            // 
            this.GbEstadoCivil.Controls.Add(this.CbEstadoCivil);
            this.GbEstadoCivil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEstadoCivil.Location = new System.Drawing.Point(546, 221);
            this.GbEstadoCivil.Name = "GbEstadoCivil";
            this.GbEstadoCivil.Size = new System.Drawing.Size(250, 66);
            this.GbEstadoCivil.TabIndex = 125;
            this.GbEstadoCivil.TabStop = false;
            this.GbEstadoCivil.Text = "Estado Civil:";
            // 
            // CbEstadoCivil
            // 
            this.CbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstadoCivil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstadoCivil.FormattingEnabled = true;
            this.CbEstadoCivil.Location = new System.Drawing.Point(9, 25);
            this.CbEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.CbEstadoCivil.Name = "CbEstadoCivil";
            this.CbEstadoCivil.Size = new System.Drawing.Size(233, 27);
            this.CbEstadoCivil.TabIndex = 66;
            // 
            // formRelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 681);
            this.Controls.Add(this.GbEstadoCivil);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.rptvFuncionario);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbDataCadastro);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbCidade);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.pnTituloFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "formRelCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRelCliente";
            this.Load += new System.EventHandler(this.formRelCliente_Load);
            this.gbEstado.ResumeLayout(false);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbCidade.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbDataCadastro.ResumeLayout(false);
            this.gbDataCadastro.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.GbEstadoCivil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvFuncionario;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.ComboBox CbCidade;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbDataCadastro;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbJuridico;
        private System.Windows.Forms.RadioButton rbFisico;
        private System.Windows.Forms.GroupBox GbEstadoCivil;
        private System.Windows.Forms.ComboBox CbEstadoCivil;
    }
}