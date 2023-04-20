using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPadariaGranPao
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogon_Click(object sender, EventArgs e)
        {
            ClassLogin ObjClassLogin = new ClassLogin();

            if (TbLogin.Text == "" || TbSenha.Text == "")
            {
                MessageBox.Show("Por Favor preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ObjClassLogin.login = TbLogin.Text;
                ObjClassLogin.senha = TbSenha.Text;
                DataTable RespDB = ObjClassLogin.ConsultaLogin();

                if(RespDB.Rows.Count == 1)
                {
                    this.Hide();
                    Application.OpenForms["FormPrincipal"].Enabled = true;
                    Application.OpenForms["FormPrincipal"].Focus();
                }
                else
                {
                    MessageBox.Show("Usuario/Senha Incorretos, por favor verifique suas Credenciais e tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            FormPrincipal ObjFormPrincipal = new FormPrincipal();
            ObjFormPrincipal.Show();
        }
    }
}
