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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void HoraSistema_Tick(object sender, EventArgs e)
        {
            StatusData.Text = DateTime.Now.ToShortDateString();
            StatusHora.Text = DateTime.Now.ToShortTimeString();
        }


        //Cadastro
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Categoria já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormCategoria objFormCategoria = new FormCategoria();
                objFormCategoria.MdiParent = this;
                objFormCategoria.Show();
            }
        }
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FormMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Marca já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormMarca objFormMarca = new FormMarca();
                objFormMarca.MdiParent = this;
                objFormMarca.Show();
            }

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFornecedor>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Fornecedor já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormFornecedor objFormFornecedor = new FormFornecedor();
                objFormFornecedor.MdiParent = this;
                objFormFornecedor.Show();
            }


        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Fornecedor já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormProduto objFormProduto = new FormProduto();
                objFormProduto.MdiParent = this;
                objFormProduto.Show();
            }
        }

        //consulta 

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConFornecedor>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Fornecedor já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConFornecedor objConFornecedor = new FormConFornecedor();
                objConFornecedor.MdiParent = this;
                objConFornecedor.Show();
            }
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Produto já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConProduto objConProduto = new FormConProduto();
                objConProduto.MdiParent = this;
                objConProduto.Show();
            }
        }


        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConMarcaCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulário Marca / Consulta de Produto já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConMarcaCategoria objConMarcaCategoria = new FormConMarcaCategoria();
                objConMarcaCategoria.MdiParent = this;
                objConMarcaCategoria.Show();
            }
        }

        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void fornecedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Relatório Fornecedor já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                formRelFuncionario objRelFuncionario = new formRelFuncionario();
                objRelFuncionario.MdiParent = this;
                objRelFuncionario.Show();
            }
        }
    }
}
