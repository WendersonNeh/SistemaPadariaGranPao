
namespace SistemaPadariaGranPao
{
    partial class FormDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartamento));
            this.LbCadDepartamento = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbNomeDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbDataCadastro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbObservacao = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbCadDepartamento
            // 
            this.LbCadDepartamento.AutoSize = true;
            this.LbCadDepartamento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCadDepartamento.Location = new System.Drawing.Point(261, 9);
            this.LbCadDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCadDepartamento.Name = "LbCadDepartamento";
            this.LbCadDepartamento.Size = new System.Drawing.Size(301, 25);
            this.LbCadDepartamento.TabIndex = 67;
            this.LbCadDepartamento.Text = "Cadastro de Departamentos";
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(434, 370);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 40);
            this.btExcluir.TabIndex = 70;
            this.btExcluir.Text = "      Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Enabled = false;
            this.btAtualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizar.Location = new System.Drawing.Point(284, 370);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(110, 40);
            this.btAtualizar.TabIndex = 69;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(134, 370);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(110, 40);
            this.btCadastrar.TabIndex = 68;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(584, 369);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(110, 40);
            this.btSair.TabIndex = 71;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CbStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbNomeDepartamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LbDataCadastro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbCodigoDepartamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbObservacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 323);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(427, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Todos os Campos com * são Obrigatórios !!!";
            // 
            // CbStatus
            // 
            this.CbStatus.AutoSize = true;
            this.CbStatus.Checked = true;
            this.CbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbStatus.Enabled = false;
            this.CbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbStatus.Location = new System.Drawing.Point(724, 40);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(61, 23);
            this.CbStatus.TabIndex = 29;
            this.CbStatus.Text = "Ativo";
            this.CbStatus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "* Status:";
            // 
            // TbNomeDepartamento
            // 
            this.TbNomeDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.TbNomeDepartamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNomeDepartamento.Location = new System.Drawing.Point(32, 101);
            this.TbNomeDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.TbNomeDepartamento.Name = "TbNomeDepartamento";
            this.TbNomeDepartamento.Size = new System.Drawing.Size(759, 27);
            this.TbNomeDepartamento.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "* Nome do Departamento:";
            // 
            // LbDataCadastro
            // 
            this.LbDataCadastro.AutoSize = true;
            this.LbDataCadastro.Enabled = false;
            this.LbDataCadastro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDataCadastro.Location = new System.Drawing.Point(526, 41);
            this.LbDataCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDataCadastro.Name = "LbDataCadastro";
            this.LbDataCadastro.Size = new System.Drawing.Size(40, 19);
            this.LbDataCadastro.TabIndex = 27;
            this.LbDataCadastro.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "* Data Cadastro:";
            // 
            // TbCodigoDepartamento
            // 
            this.TbCodigoDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.TbCodigoDepartamento.Enabled = false;
            this.TbCodigoDepartamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCodigoDepartamento.Location = new System.Drawing.Point(224, 35);
            this.TbCodigoDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.TbCodigoDepartamento.Name = "TbCodigoDepartamento";
            this.TbCodigoDepartamento.Size = new System.Drawing.Size(133, 27);
            this.TbCodigoDepartamento.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Observação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "* Código do Departamento:";
            // 
            // TbObservacao
            // 
            this.TbObservacao.BackColor = System.Drawing.SystemColors.Control;
            this.TbObservacao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbObservacao.Location = new System.Drawing.Point(32, 155);
            this.TbObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.TbObservacao.MaxLength = 100;
            this.TbObservacao.Multiline = true;
            this.TbObservacao.Name = "TbObservacao";
            this.TbObservacao.Size = new System.Drawing.Size(759, 128);
            this.TbObservacao.TabIndex = 6;
            // 
            // FormDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 420);
            this.Controls.Add(this.LbCadDepartamento);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDepartamento";
            this.Text = "FormDepartamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbCadDepartamento;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        public System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox CbStatus;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TbNomeDepartamento;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LbDataCadastro;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TbCodigoDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TbObservacao;
    }
}