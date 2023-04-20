
namespace SistemaPadariaGranPao
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.GbLogin = new System.Windows.Forms.GroupBox();
            this.BtnLogon = new System.Windows.Forms.Button();
            this.TbSenha = new System.Windows.Forms.TextBox();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.LbSenha = new System.Windows.Forms.Label();
            this.LbLogin = new System.Windows.Forms.Label();
            this.PbLogotipo = new System.Windows.Forms.PictureBox();
            this.GbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // GbLogin
            // 
            this.GbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GbLogin.AutoSize = true;
            this.GbLogin.Controls.Add(this.BtnLogon);
            this.GbLogin.Controls.Add(this.TbSenha);
            this.GbLogin.Controls.Add(this.TbLogin);
            this.GbLogin.Controls.Add(this.LbSenha);
            this.GbLogin.Controls.Add(this.LbLogin);
            this.GbLogin.Controls.Add(this.PbLogotipo);
            this.GbLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbLogin.Location = new System.Drawing.Point(12, -1);
            this.GbLogin.Name = "GbLogin";
            this.GbLogin.Size = new System.Drawing.Size(376, 389);
            this.GbLogin.TabIndex = 0;
            this.GbLogin.TabStop = false;
            // 
            // BtnLogon
            // 
            this.BtnLogon.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLogon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogon.ForeColor = System.Drawing.Color.White;
            this.BtnLogon.Location = new System.Drawing.Point(16, 321);
            this.BtnLogon.Name = "BtnLogon";
            this.BtnLogon.Size = new System.Drawing.Size(347, 32);
            this.BtnLogon.TabIndex = 5;
            this.BtnLogon.Text = "Entrar";
            this.BtnLogon.UseVisualStyleBackColor = false;
            this.BtnLogon.Click += new System.EventHandler(this.BtnLogon_Click);
            // 
            // TbSenha
            // 
            this.TbSenha.BackColor = System.Drawing.SystemColors.Control;
            this.TbSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSenha.Location = new System.Drawing.Point(16, 281);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.Size = new System.Drawing.Size(347, 27);
            this.TbSenha.TabIndex = 4;
            this.TbSenha.UseSystemPasswordChar = true;
            // 
            // TbLogin
            // 
            this.TbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.TbLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLogin.Location = new System.Drawing.Point(16, 225);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(347, 27);
            this.TbLogin.TabIndex = 3;
            // 
            // LbSenha
            // 
            this.LbSenha.AutoSize = true;
            this.LbSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenha.Location = new System.Drawing.Point(12, 255);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(72, 23);
            this.LbSenha.TabIndex = 2;
            this.LbSenha.Text = "Senha:";
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.Location = new System.Drawing.Point(12, 199);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(64, 23);
            this.LbLogin.TabIndex = 1;
            this.LbLogin.Text = "Login:";
            // 
            // PbLogotipo
            // 
            this.PbLogotipo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogotipo.Image")));
            this.PbLogotipo.Location = new System.Drawing.Point(82, 19);
            this.PbLogotipo.Name = "PbLogotipo";
            this.PbLogotipo.Size = new System.Drawing.Size(216, 182);
            this.PbLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogotipo.TabIndex = 0;
            this.PbLogotipo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.GbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.GbLogin.ResumeLayout(false);
            this.GbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbLogin;
        private System.Windows.Forms.TextBox TbSenha;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.Label LbSenha;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.PictureBox PbLogotipo;
        private System.Windows.Forms.Button BtnLogon;
    }
}