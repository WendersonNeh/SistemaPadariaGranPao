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
    public partial class FormDepartamento : Form
    {
        public FormDepartamento()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ClassDepartamento ObjClassDepartamento = new ClassDepartamento();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if (TbNomeDepartamento.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE CARGO TODOS OS CAMPOS QUE NÃO SÃO AUTOMÁTICOS
                ObjClassDepartamento.nome = TbNomeDepartamento.Text;
                ObjClassDepartamento.observacao = TbObservacao.Text;

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CARGO
                int RespDB = ObjClassDepartamento.CadastrarDepartamento();

                if (RespDB == 1) //SE O CADASTRO DEU CERTO
                {
                    MessageBox.Show("Departamento Cadastrado com Sucesso", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Departamento", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNomeDepartamento.BackColor = Color.LemonChiffon;
                TbNomeDepartamento.Focus();
            }
        }

        private void Limpar()
        {
            TbNomeDepartamento.Clear();
            TbObservacao.Clear();
            TbNomeDepartamento.Focus();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);

            if (Sair == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
