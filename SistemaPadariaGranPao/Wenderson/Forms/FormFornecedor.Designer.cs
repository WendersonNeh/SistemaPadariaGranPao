
namespace SistemaPadariaGranPao
{
    partial class FormFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedor));
            this.btSair = new System.Windows.Forms.Button();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.tbEstadoFornecedor = new System.Windows.Forms.ComboBox();
            this.tbCnpjFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.tbCepFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefoneRecadoFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCidadeFornecedor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNumeroFornecedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEmailFornecedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFantasiaFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRazaoFornecedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.Data_Cadastro1 = new System.Windows.Forms.Label();
            this.tbId_Fornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbObservacaoFornecedor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(644, 478);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(110, 40);
            this.btSair.TabIndex = 13;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(13, 9);
            this.LbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(291, 25);
            this.LbTitulo.TabIndex = 73;
            this.LbTitulo.Text = "Cadastro de Fornecedor";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(10, 478);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(110, 40);
            this.btCadastrar.TabIndex = 12;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.btAtualizar);
            this.groupBox1.Controls.Add(this.tbEstadoFornecedor);
            this.groupBox1.Controls.Add(this.tbCnpjFornecedor);
            this.groupBox1.Controls.Add(this.tbCepFornecedor);
            this.groupBox1.Controls.Add(this.tbTelefoneFornecedor);
            this.groupBox1.Controls.Add(this.tbTelefoneRecadoFornecedor);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbCidadeFornecedor);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbNumeroFornecedor);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbEnderecoFornecedor);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.btCadastrar);
            this.groupBox1.Controls.Add(this.tbEmailFornecedor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbFantasiaFornecedor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbRazaoFornecedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.Data_Cadastro1);
            this.groupBox1.Controls.Add(this.tbId_Fornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbObservacaoFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(18, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(253, 478);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 40);
            this.btExcluir.TabIndex = 93;
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
            this.btAtualizar.Location = new System.Drawing.Point(126, 478);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(110, 40);
            this.btAtualizar.TabIndex = 92;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // tbEstadoFornecedor
            // 
            this.tbEstadoFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbEstadoFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbEstadoFornecedor.FormattingEnabled = true;
            this.tbEstadoFornecedor.Location = new System.Drawing.Point(262, 311);
            this.tbEstadoFornecedor.Name = "tbEstadoFornecedor";
            this.tbEstadoFornecedor.Size = new System.Drawing.Size(108, 21);
            this.tbEstadoFornecedor.TabIndex = 10;
            // 
            // tbCnpjFornecedor
            // 
            this.tbCnpjFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCnpjFornecedor.Location = new System.Drawing.Point(7, 311);
            this.tbCnpjFornecedor.Mask = "00,000,000/0000-00";
            this.tbCnpjFornecedor.Name = "tbCnpjFornecedor";
            this.tbCnpjFornecedor.Size = new System.Drawing.Size(116, 27);
            this.tbCnpjFornecedor.TabIndex = 9;
            // 
            // tbCepFornecedor
            // 
            this.tbCepFornecedor.Location = new System.Drawing.Point(512, 178);
            this.tbCepFornecedor.Mask = "00000-000";
            this.tbCepFornecedor.Name = "tbCepFornecedor";
            this.tbCepFornecedor.Size = new System.Drawing.Size(81, 21);
            this.tbCepFornecedor.TabIndex = 5;
            // 
            // tbTelefoneFornecedor
            // 
            this.tbTelefoneFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefoneFornecedor.Location = new System.Drawing.Point(10, 178);
            this.tbTelefoneFornecedor.Mask = "(00)0000-0000";
            this.tbTelefoneFornecedor.Name = "tbTelefoneFornecedor";
            this.tbTelefoneFornecedor.Size = new System.Drawing.Size(116, 27);
            this.tbTelefoneFornecedor.TabIndex = 3;
            // 
            // tbTelefoneRecadoFornecedor
            // 
            this.tbTelefoneRecadoFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefoneRecadoFornecedor.Location = new System.Drawing.Point(292, 178);
            this.tbTelefoneRecadoFornecedor.Mask = "(00)0000-0000";
            this.tbTelefoneRecadoFornecedor.Name = "tbTelefoneRecadoFornecedor";
            this.tbTelefoneRecadoFornecedor.Size = new System.Drawing.Size(116, 27);
            this.tbTelefoneRecadoFornecedor.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 279);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 19);
            this.label17.TabIndex = 91;
            this.label17.Text = "*cnpj";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(258, 279);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 19);
            this.label18.TabIndex = 89;
            this.label18.Text = "*estado";
            // 
            // tbCidadeFornecedor
            // 
            this.tbCidadeFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCidadeFornecedor.Location = new System.Drawing.Point(481, 248);
            this.tbCidadeFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tbCidadeFornecedor.MaxLength = 40;
            this.tbCidadeFornecedor.Name = "tbCidadeFornecedor";
            this.tbCidadeFornecedor.Size = new System.Drawing.Size(211, 27);
            this.tbCidadeFornecedor.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(497, 221);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 19);
            this.label14.TabIndex = 87;
            this.label14.Text = "*cidade";
            // 
            // tbNumeroFornecedor
            // 
            this.tbNumeroFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroFornecedor.Location = new System.Drawing.Point(253, 248);
            this.tbNumeroFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumeroFornecedor.MaxLength = 4;
            this.tbNumeroFornecedor.Name = "tbNumeroFornecedor";
            this.tbNumeroFornecedor.Size = new System.Drawing.Size(211, 27);
            this.tbNumeroFornecedor.TabIndex = 7;
            this.tbNumeroFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroFornecedor_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 221);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 19);
            this.label15.TabIndex = 85;
            this.label15.Text = "*endereco";
            // 
            // tbEnderecoFornecedor
            // 
            this.tbEnderecoFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnderecoFornecedor.Location = new System.Drawing.Point(7, 248);
            this.tbEnderecoFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnderecoFornecedor.MaxLength = 70;
            this.tbEnderecoFornecedor.Name = "tbEnderecoFornecedor";
            this.tbEnderecoFornecedor.Size = new System.Drawing.Size(211, 27);
            this.tbEnderecoFornecedor.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(250, 221);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 19);
            this.label16.TabIndex = 83;
            this.label16.Text = "*numero";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(524, 156);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 19);
            this.label13.TabIndex = 81;
            this.label13.Text = "*cep";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 19);
            this.label12.TabIndex = 79;
            this.label12.Text = "*telefone_principal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(293, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 19);
            this.label11.TabIndex = 77;
            this.label11.Text = "telefone_recado";
            // 
            // tbEmailFornecedor
            // 
            this.tbEmailFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailFornecedor.Location = new System.Drawing.Point(543, 116);
            this.tbEmailFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmailFornecedor.MaxLength = 50;
            this.tbEmailFornecedor.Name = "tbEmailFornecedor";
            this.tbEmailFornecedor.Size = new System.Drawing.Size(211, 27);
            this.tbEmailFornecedor.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(577, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 75;
            this.label10.Text = "E-mail:";
            // 
            // tbFantasiaFornecedor
            // 
            this.tbFantasiaFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFantasiaFornecedor.Location = new System.Drawing.Point(287, 116);
            this.tbFantasiaFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tbFantasiaFornecedor.MaxLength = 60;
            this.tbFantasiaFornecedor.Name = "tbFantasiaFornecedor";
            this.tbFantasiaFornecedor.Size = new System.Drawing.Size(211, 27);
            this.tbFantasiaFornecedor.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 19);
            this.label8.TabIndex = 73;
            this.label8.Text = "* Nome da Fantasia:";
            // 
            // tbRazaoFornecedor
            // 
            this.tbRazaoFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRazaoFornecedor.Location = new System.Drawing.Point(7, 116);
            this.tbRazaoFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tbRazaoFornecedor.MaxLength = 60;
            this.tbRazaoFornecedor.Name = "tbRazaoFornecedor";
            this.tbRazaoFornecedor.Size = new System.Drawing.Size(211, 27);
            this.tbRazaoFornecedor.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "* Razao Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "* Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "* Data Cadastro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(387, 489);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "PREENCHA todos os campos *";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.Location = new System.Drawing.Point(443, 52);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(61, 23);
            this.cbStatus.TabIndex = 29;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // Data_Cadastro1
            // 
            this.Data_Cadastro1.AutoSize = true;
            this.Data_Cadastro1.Enabled = false;
            this.Data_Cadastro1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Cadastro1.Location = new System.Drawing.Point(258, 51);
            this.Data_Cadastro1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Data_Cadastro1.Name = "Data_Cadastro1";
            this.Data_Cadastro1.Size = new System.Drawing.Size(40, 19);
            this.Data_Cadastro1.TabIndex = 27;
            this.Data_Cadastro1.Text = "Data";
            // 
            // tbId_Fornecedor
            // 
            this.tbId_Fornecedor.Enabled = false;
            this.tbId_Fornecedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId_Fornecedor.Location = new System.Drawing.Point(19, 48);
            this.tbId_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tbId_Fornecedor.Name = "tbId_Fornecedor";
            this.tbId_Fornecedor.Size = new System.Drawing.Size(131, 27);
            this.tbId_Fornecedor.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Observação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "* Código do Fornecedor:";
            // 
            // tbObservacaoFornecedor
            // 
            this.tbObservacaoFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObservacaoFornecedor.Location = new System.Drawing.Point(10, 392);
            this.tbObservacaoFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tbObservacaoFornecedor.MaxLength = 255;
            this.tbObservacaoFornecedor.Multiline = true;
            this.tbObservacaoFornecedor.Name = "tbObservacaoFornecedor";
            this.tbObservacaoFornecedor.Size = new System.Drawing.Size(540, 67);
            this.tbObservacaoFornecedor.TabIndex = 11;
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 586);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.FormFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox cbStatus;
        public System.Windows.Forms.Label Data_Cadastro1;
        public System.Windows.Forms.TextBox tbId_Fornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbObservacaoFornecedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tbEmailFornecedor;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbFantasiaFornecedor;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbRazaoFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox tbCidadeFornecedor;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tbNumeroFornecedor;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tbEnderecoFornecedor;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.MaskedTextBox tbTelefoneFornecedor;
        public System.Windows.Forms.MaskedTextBox tbTelefoneRecadoFornecedor;
        public System.Windows.Forms.MaskedTextBox tbCepFornecedor;
        public System.Windows.Forms.MaskedTextBox tbCnpjFornecedor;
        public System.Windows.Forms.ComboBox tbEstadoFornecedor;
        public System.Windows.Forms.Button btSair;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
    }
}