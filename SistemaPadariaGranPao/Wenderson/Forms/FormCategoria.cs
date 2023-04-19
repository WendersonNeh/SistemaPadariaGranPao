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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            Data_Cadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void Limpar()
        {
            tbNomeCategoria.Clear();
            tbObservacao.Clear();
            tbNomeCategoria.Focus();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            // criar objeto da classe cargo para uasar propriedades e métodos
            ClassCategoria objClasseCategoria = new ClassCategoria();

            //verificar campos obrigatórios
            if (tbNomeCategoria.Text != "")
            {
                //Passa para as propriedades da classe cargo todos os campos que não são automaticos
                objClasseCategoria.nome = tbNomeCategoria.Text;
                objClasseCategoria.observacao = tbObservacao.Text;

                //chamar método cadastrar da classe cargo
                int resp = objClasseCategoria.CadastrarCategoria();

                if (resp == 1)// se o cadastro deu certo 
                {
                    MessageBox.Show("Categoria Cadastrado com sucesso", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    tbNomeCategoria.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Categoria", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else // não preencheu todos os campos obrigatórios
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeCategoria.BackColor = Color.LemonChiffon;
                tbNomeCategoria.Focus();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
