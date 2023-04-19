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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void Limpar()
        {

            Cb_Categoria.SelectedIndex = -1;
            Cb_fornecedor.SelectedIndex = -1;
            Cb_Marca.SelectedIndex = -1;
            Tb_Nome.Clear();
            Tb_Nome.Focus();
            Tb_Nome.BackColor = Color.White;
            Tb_Estoque.Clear();
            Tb_Custo.Clear();
            Tb_Lucro.Clear();
            Tb_Venda.Clear();
            Tb_Venda.BackColor = Color.White;
            Tb_Observacao.Clear();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            
        }

        //VARIÁVEL tipo: GUARDAR COMO O FORMULÁRIO DEVE SER ABERTO SE PARA CADASTRO OU ATUALIZAÇÃO/EXCLUSÃO
        //VARIÁVEL estado, estado_civil, cargo e setor: INFORMAÇÃO É MOSTRADA EM UMA COMBO
        public string estado, tipo;

        public int fornecedor, marca, categoria;

        //VARIÁVEL datacad: MOSTRAR INFORMAÇÃO GUARDADA NO BD E NÃO DATA ATUAL COMO PROGRAMADO NO LOAD DO FORM
        public DateTime datacad;

        private void FormProduto_Load(object sender, EventArgs e)
        {


            Data_Cadastro.Text = DateTime.Now.ToShortDateString();

            ClassFornecedor objfornecedor = new ClassFornecedor();
            Cb_fornecedor.DataSource = objfornecedor.BuscarFornecedor();
            Cb_fornecedor.DisplayMember = "razao_social";
            Cb_fornecedor.ValueMember = "id_fornecedor";
            Cb_fornecedor.SelectedIndex = -1;

            //CARREGAR COMBOBOX DO BD
            ClassMarca objcargo = new ClassMarca();
            Cb_Marca.DataSource = objcargo.BuscarMarca();
            //EXIBIR NA COMBO
            Cb_Marca.DisplayMember = "nome";
            //GUARDAR NO BD
            Cb_Marca.ValueMember = "id_marca";
            Cb_Marca.SelectedIndex = -1;

            ClassCategoria objcategoria = new ClassCategoria();
            Cb_Categoria.DataSource = objcategoria.BuscarCategoria();
            Cb_Categoria.DisplayMember = "nome";
            Cb_Categoria.ValueMember = "id_categoria";
            Cb_Categoria.SelectedIndex = -1;

            if (tipo == "Atualização")
            {
                LbTitulo.Text = "Atualização Produto";
                Data_Cadastro.Text = datacad.ToString("dd-MM-yyyy");
                Data_Cadastro.Enabled = true;
                cbStatus.Enabled = true;
                btCadastrar.Enabled = false;
                btAtualizar.Enabled = true;
                btExcluir.Enabled = true;
                Cb_fornecedor.SelectedValue = fornecedor;
                Cb_Marca.SelectedValue = marca;
                Cb_Categoria.SelectedValue = categoria;

            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }


        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ClassProduto objclassproduto = new ClassProduto();

            if (Tb_Nome.Text != "" && Cb_Categoria.SelectedIndex != -1 &&  Cb_fornecedor.SelectedIndex != -1 && Cb_Marca.SelectedIndex != -1 && Tb_Venda.Text != "")
            {
                

                objclassproduto.id_fornecedor = Convert.ToInt32(Cb_fornecedor.SelectedValue);
                objclassproduto.id_marca = Convert.ToInt32(Cb_Marca.SelectedValue);
                objclassproduto.id_categoria = Convert.ToInt32(Cb_Categoria.SelectedValue);

                objclassproduto.nome = Tb_Nome.Text;

                if (Tb_Estoque.Text == "")
                {
                    objclassproduto.estoque = 0;
                }
                else
                {
                    objclassproduto.estoque = Convert.ToInt32(Tb_Estoque.Text); ;
                }


                if (Tb_Custo.Text == "")
                {
                    objclassproduto.valor_custo = 0;
                }
                else
                {
                    objclassproduto.valor_custo = Convert.ToInt32(Tb_Custo.Text);
                }




                if (Tb_Lucro.Text == "")
               {
                    objclassproduto.margem_lucro = 0;
               }
               else
               {
                    objclassproduto.margem_lucro = Convert.ToInt32(Tb_Lucro.Text);
               }

                objclassproduto.valor_venda = Convert.ToDecimal(Tb_Venda.Text);




                objclassproduto.observacao = Tb_Observacao.Text;

                int resp = objclassproduto.CadastrarProduto();





                if (resp == 1)
                {
                    MessageBox.Show("Produto Cadastrado com sucesso", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    
                  
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else // não preencheu todos os campos obrigatórios
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (Cb_fornecedor.SelectedIndex == -1)
                {
                    label1.BackColor = Color.LemonChiffon;
                }
                else
                {
                    label1.BackColor = Color.Transparent;
                }

                //nome

                if (string.IsNullOrEmpty(Tb_Nome.Text.Trim()))
                {
                    Tb_Nome.BackColor = Color.LemonChiffon;
                }
                else
                {
                    Tb_Nome.BackColor = Color.White;
                }


                //custo
                if (string.IsNullOrEmpty(Tb_Venda.Text.Trim()))
                {
                    Tb_Venda.BackColor = Color.LemonChiffon;
                }
                else
                {
                    Tb_Venda.BackColor = Color.White;
                }


                if (Cb_Marca.SelectedIndex == -1)
                {
                    label2.BackColor = Color.LemonChiffon;
                }
                else
                {
                    label2.BackColor = Color.Transparent;
                }

                if (Cb_Categoria.SelectedIndex == -1)
                {
                    label4.BackColor = Color.LemonChiffon;
                }
                else
                {
                    label4.BackColor = Color.Transparent;
                }
  
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tb_Estoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Tb_Lucro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Tb_Custo_TextChanged(object sender, EventArgs e)
        {
            double custo = 0, lucro = 0, venda = 0;
            if (double.TryParse(Tb_Custo.Text, out custo) && double.TryParse(Tb_Lucro.Text, out lucro))
            {
                venda = custo + (custo * lucro / 100);
                Tb_Venda.Text = venda.ToString();
            }
        }

        private void Tb_Lucro_TextChanged(object sender, EventArgs e)
        {
            double custo = 0, lucro = 0, venda = 0;
            if (double.TryParse(Tb_Custo.Text, out custo) && double.TryParse(Tb_Lucro.Text, out lucro))
            {
                venda = custo + (custo * lucro / 100);
                Tb_Venda.Text = venda.ToString();
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            ClassProduto objclassproduto = new ClassProduto();

            if (Tb_Nome.Text != "" && Cb_Categoria.SelectedIndex != -1 && Cb_fornecedor.SelectedIndex != -1 && Cb_Marca.SelectedIndex != -1 && Tb_Venda.Text != "")
            {


                objclassproduto.id_fornecedor = Convert.ToInt32(Cb_fornecedor.SelectedValue);
                objclassproduto.id_marca = Convert.ToInt32(Cb_Marca.SelectedValue);
                objclassproduto.id_categoria = Convert.ToInt32(Cb_Categoria.SelectedValue);

                objclassproduto.nome = Tb_Nome.Text;

                if (Tb_Estoque.Text == "")
                {
                    objclassproduto.estoque = 0;
                }
                else
                {
                    objclassproduto.estoque = Convert.ToInt32(Tb_Estoque.Text); ;
                }


                if (Tb_Custo.Text == "")
                {
                    objclassproduto.valor_custo = 0;
                }
                else
                {
                    objclassproduto.valor_custo = Convert.ToDecimal(Tb_Custo.Text);
                }




                if (Tb_Lucro.Text == "")
                {
                    objclassproduto.margem_lucro = 0;
                }
                else
                {
                    objclassproduto.margem_lucro = Convert.ToInt32(Tb_Lucro.Text);
                }

                objclassproduto.valor_venda = Convert.ToDecimal(Tb_Venda.Text);




                objclassproduto.observacao = Tb_Observacao.Text;


                // checbox status
                if (cbStatus.Checked == true)
                {
                    objclassproduto.status = 1;
                }
                else
                {
                   objclassproduto.status = 0;
                }

                //código funcionário 
                objclassproduto.id_produto = Convert.ToInt32(Tb_Id.Text);

                //chamar o método atualizar da classe funcionario
                bool resp = objclassproduto.AtualizarProduto();

                
                
                //PEGAR A RESPOSTA DO MÉTODO CADASTRAR - SE DER 1 FOI CADASTRADO
                if (resp == true)
                {
                    MessageBox.Show("Produto Atualizado com Sucesso", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Produto", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else // não preencheu todos os campos obrigatórios
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (Cb_fornecedor.SelectedIndex == -1)
                {
                    label1.BackColor = Color.LemonChiffon;
                }
                else
                {
                    label1.BackColor = Color.Transparent;
                }

                //nome

                if (string.IsNullOrEmpty(Tb_Nome.Text.Trim()))
                {
                    Tb_Nome.BackColor = Color.LemonChiffon;
                }
                else
                {
                    Tb_Nome.BackColor = Color.White;
                }


                //custo
                if (string.IsNullOrEmpty(Tb_Venda.Text.Trim()))
                {
                    Tb_Venda.BackColor = Color.LemonChiffon;
                }
                else
                {
                    Tb_Venda.BackColor = Color.White;
                }


                if (Cb_Marca.SelectedIndex == -1)
                {
                    label2.BackColor = Color.LemonChiffon;
                }
                else
                {
                    label2.BackColor = Color.Transparent;
                }

                if (Cb_Categoria.SelectedIndex == -1)
                {
                    label4.BackColor = Color.LemonChiffon;
                }
                else
                {
                    label4.BackColor = Color.Transparent;
                }

            }


        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse Produto?", "Sistema GranPao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassProduto objclassProduto = new ClassProduto();
                objclassProduto.id_produto = Convert.ToInt32(Tb_Id.Text);

                bool resp = objclassProduto.ExcluirProduto();

                if (resp == true)
                {
                    MessageBox.Show("Produto" + objclassProduto.nome + "excluido com sucesso", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Produto não pode ser excluido, há registros em outras tabelas.", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Tb_Custo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Tb_Lucro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Tb_Venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }


}
