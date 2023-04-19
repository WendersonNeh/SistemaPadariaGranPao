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
    public partial class FormConProduto : Form
    {
        public FormConProduto()
        {
            InitializeComponent();
        }

        private void FormConProduto_Load(object sender, EventArgs e)
        {
            //CARREGAR OPÇÕES DE BUSCA NA COMBO
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Venda");
            cbOpcoes.Items.Add("Fornecedor");
            cbOpcoes.Items.Add("Marca");
            cbOpcoes.Items.Add("Categoria");
            cbOpcoes.Items.Add("Status");

            //DEIXAR SELECIONADA A OPÇÃO NOME
            cbOpcoes.SelectedItem = "Nome";

            //CARREGAR COMBOBOX DO BD
            ClassMarca objcargo = new ClassMarca();
            Cb_Marca.DataSource = objcargo.BuscarMarca();
            //EXIBIR NA COMBO
            Cb_Marca.DisplayMember = "nome";
            //GUARDAR NO BD
            Cb_Marca.ValueMember = "id_marca";
            Cb_Marca.SelectedIndex = -1;

            ClassFornecedor objfornecedor = new ClassFornecedor();
            Cb_fornecedor.DataSource = objfornecedor.BuscarFornecedor();
            Cb_fornecedor.DisplayMember = "razao_social";
            Cb_fornecedor.ValueMember = "id_fornecedor";
            Cb_fornecedor.SelectedIndex = -1;

            ClassCategoria objcategoria = new ClassCategoria();
            Cb_Categoria.DataSource = objcategoria.BuscarCategoria();
            Cb_Categoria.DisplayMember = "nome";
            Cb_Categoria.ValueMember = "id_categoria";
            Cb_Categoria.SelectedIndex = -1;

        }



        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcoes.SelectedIndex == 0) //NOME
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbNome.Enabled = true;
                gbVenda.Enabled = false;
                gbMarca.Enabled = false;
                gbFernecedor.Enabled = false;
                gbCategoria.Enabled = false;
                txtNome.Focus();
            }

            if (cbOpcoes.SelectedIndex == 1) //Venda
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbVenda.Enabled = true;
                gbMarca.Enabled = false;
                gbFernecedor.Enabled = false;
                gbCategoria.Enabled = false;
                tbVenda.Focus();
            }

            if (cbOpcoes.SelectedIndex == 2) //Fornecedor
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbVenda.Enabled = false;
                gbMarca.Enabled = false;
                gbFernecedor.Enabled = true;
                gbCategoria.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 3) //Marca
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbVenda.Enabled = false;
                gbMarca.Enabled = true;
                gbFernecedor.Enabled = false;
                gbCategoria.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 4) //Categoria
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbVenda.Enabled = false;
                gbMarca.Enabled = false;
                gbFernecedor.Enabled = false;
                gbCategoria.Enabled = true;
            }

            if (cbOpcoes.SelectedIndex == 5) //Status
            {

                gbStatus.Enabled = true;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbVenda.Enabled = false;
                gbMarca.Enabled = false;
                gbFernecedor.Enabled = false;
                gbCategoria.Enabled = false;
            }


        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ClassProduto objclassProduto = new ClassProduto();

            string consulta = cbOpcoes.SelectedItem.ToString();

            switch (consulta)
            {
                case "Nome":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked == true)
                        {
                            dgvFuncionario.DataSource = objclassProduto.ConsultaProdutoNomeInicial(txtNome.Text);
                        }
                        else
                        {
                            dgvFuncionario.DataSource = objclassProduto.ConsultaProdutoNomeContem(txtNome.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor preecher um NOME ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }
                    break;

                case "Venda":
                    if (tbVenda.Text != "")
                    {

                        dgvFuncionario.DataSource = objclassProduto.ConsultaProdutoValorvenda(Convert.ToDecimal(tbVenda.Text));
                    }
                    else
                    {
                        MessageBox.Show("Favor preecher um Valor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbVenda.Focus();

                    }
                    break;

                case "Fornecedor":
                    if (Cb_fornecedor.SelectedIndex != -1)
                    {
                        dgvFuncionario.DataSource = objclassProduto.ConsultaProdutoFornecedor(Convert.ToInt32(Cb_fornecedor.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um Fornecedor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    break;

                case "Marca":
                    if (Cb_Marca.SelectedIndex != -1)
                    {
                        dgvFuncionario.DataSource = objclassProduto.ConsultaProdutoMarca(Convert.ToInt32(Cb_Marca.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um Marca", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    break;
                case "Categoria":
                    if (Cb_Categoria.SelectedIndex != -1)
                    {
                        dgvFuncionario.DataSource = objclassProduto.ConsultaProdutoCategoria(Convert.ToInt32(Cb_Categoria.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um Categoria", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    break;

                case "Status":

                    if (rbAtivo.Checked == true)
                    {
                        dgvFuncionario.DataSource = objclassProduto.ConsultaProdutoStatus(1);
                    }
                    else
                    {
                        dgvFuncionario.DataSource = objclassProduto.ConsultaProdutoStatus(0);
                    }
                    break;

            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // perguntar se deseja alterar o funcionario selecionado 
            if (MessageBox.Show("Deseja alterar o Produto selecionado", "atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassProduto objclassProduto = new ClassProduto();

                FormProduto fFormProduto = new FormProduto();

                objclassProduto.ConsultaProduto(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));

                //passar os dados do DBConcurrencyException para os controles do Form de fornecedor

                fFormProduto.Tb_Id.Text = objclassProduto.id_produto.ToString();
                fFormProduto.fornecedor = objclassProduto.id_fornecedor;
                fFormProduto.marca = objclassProduto.id_marca;
                fFormProduto.categoria = objclassProduto.id_categoria;


                fFormProduto.Tb_Nome.Text = objclassProduto.nome;
                fFormProduto.Tb_Estoque.Text = objclassProduto.estoque.ToString();

                fFormProduto.datacad = objclassProduto.data_cadastro;

                fFormProduto.Tb_Custo.Text = objclassProduto.valor_custo.ToString();
                fFormProduto.Tb_Venda.Text = objclassProduto.valor_venda.ToString();
                fFormProduto.Tb_Lucro.Text = objclassProduto.margem_lucro.ToString();


                if (objclassProduto.status == 1)
                {
                    fFormProduto.cbStatus.Checked = true;
                }
                else
                {
                    fFormProduto.cbStatus.Checked = false;
                }

                fFormProduto.Tb_Observacao.Text = objclassProduto.observacao;

                //MANDAR A INFORMAÇÃO DE  UPDATE PARA A VARIÁVEL DO FORM DE CADASTRO
                fFormProduto.tipo = "Atualização";
                //ABRIR FORMULÁRIO DE CADASTRO PARA ATUALIZAÇÃO EM MODO EXCLUSIVO
                fFormProduto.ShowDialog();
                // CHAMAR METODO DE PESQUISA
                btPesquisar_Click(this, new EventArgs());

            }
        }
    }
}
