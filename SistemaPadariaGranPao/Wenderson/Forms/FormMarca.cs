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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            Data_Cadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void Limpar()
        {
            tbNomeMarca.Clear();
            tbObservacao.Clear();
            tbNomeMarca.Focus();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ClassMarca objclassMarca = new ClassMarca();

            if(tbNomeMarca.Text != "")
            {

                objclassMarca.nome = tbNomeMarca.Text;
                objclassMarca.observacao = tbObservacao.Text;

                int resp = objclassMarca.CadastrarMarca();

                if(resp == 1)
                {
                    MessageBox.Show("Marca Cadastrado com sucesso", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    tbNomeMarca.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Marca", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else 
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeMarca.BackColor = Color.LemonChiffon;
                tbNomeMarca.Focus();

            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
