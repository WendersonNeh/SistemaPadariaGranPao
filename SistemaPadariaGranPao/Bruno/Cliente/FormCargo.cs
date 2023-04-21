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
    public partial class FormCargo : Form
    {
        public FormCargo()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ClassCargo ObjClassCargo = new ClassCargo();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if (TbNomeCargo.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE CARGO TODOS OS CAMPOS QUE NÃO SÃO AUTOMÁTICOS
                ObjClassCargo.nome = TbNomeCargo.Text;
                ObjClassCargo.observacao = TbObservacao.Text;

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CARGO
                int RespDB = ObjClassCargo.CadastrarCargo();

                if (RespDB == 1) //SE O CADASTRO DEU CERTO
                {
                    MessageBox.Show("Cargo Cadastrado com Sucesso", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Cargo", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNomeCargo.BackColor = Color.LemonChiffon;
                TbNomeCargo.Focus();
            }
        }

        private void Limpar()
        {
            TbNomeCargo.Clear();
            TbObservacao.Clear();
            TbNomeCargo.Focus();
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
