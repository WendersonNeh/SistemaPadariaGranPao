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
    public partial class FormConFornecedor : Form
    {
        public FormConFornecedor()
        {
            InitializeComponent();
        }
        private void FormConFornecedor_Load(object sender, EventArgs e)
        {
            //CARREGAR OPÇÕES DE BUSCA NA COMBO
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("CNPJ");
            cbOpcoes.Items.Add("Estado");
            cbOpcoes.Items.Add("Status");

            //DEIXAR SELECIONADA A OPÇÃO NOME
            cbOpcoes.SelectedItem = "Nome";

            //Combo_Estado 

            //ESTADO
            tbEstadoFornecedor.Items.Add("Selecione:");
            tbEstadoFornecedor.Items.Add("AC");
            tbEstadoFornecedor.Items.Add("AL");
            tbEstadoFornecedor.Items.Add("AP");
            tbEstadoFornecedor.Items.Add("AM");
            tbEstadoFornecedor.Items.Add("BA");
            tbEstadoFornecedor.Items.Add("CE");
            tbEstadoFornecedor.Items.Add("DF");
            tbEstadoFornecedor.Items.Add("ES");
            tbEstadoFornecedor.Items.Add("GO");
            tbEstadoFornecedor.Items.Add("MA");
            tbEstadoFornecedor.Items.Add("MT");
            tbEstadoFornecedor.Items.Add("MS");
            tbEstadoFornecedor.Items.Add("MG");
            tbEstadoFornecedor.Items.Add("PA");
            tbEstadoFornecedor.Items.Add("PB");
            tbEstadoFornecedor.Items.Add("PR");
            tbEstadoFornecedor.Items.Add("PE");
            tbEstadoFornecedor.Items.Add("PI");
            tbEstadoFornecedor.Items.Add("RJ");
            tbEstadoFornecedor.Items.Add("RN");
            tbEstadoFornecedor.Items.Add("RS");
            tbEstadoFornecedor.Items.Add("RO");
            tbEstadoFornecedor.Items.Add("RR");
            tbEstadoFornecedor.Items.Add("SC");
            tbEstadoFornecedor.Items.Add("SP");
            tbEstadoFornecedor.Items.Add("SE");
            tbEstadoFornecedor.Items.Add("TO");

            //tbEstadoFornecedor.Sorted = true;
            tbEstadoFornecedor.SelectedItem = "Selecione:";


        }
        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HABILITAR/DESABILITAR ELEMENTOS DO FORM CONFORME OPÇÃO ESCOLHIDA PELO USUÁRIO
            if (cbOpcoes.SelectedIndex == 0) //NOME
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbNome.Enabled = true;
                gbCPF.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                txtNome.Focus();
            }

            if (cbOpcoes.SelectedIndex == 1) //Cidade
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbCargo.Enabled = true;
                gbSetor.Enabled = false;
                Tb_cidade.Focus();
            }

            if (cbOpcoes.SelectedIndex == 2) //CNPJ
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = true;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                tbCnpjFornecedor.Focus();
            }

            if (cbOpcoes.SelectedIndex == 3) //Estado
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = true;
                // Tb_estado.Focus();
            }


            if (cbOpcoes.SelectedIndex == 4) //STATUS
            {

                gbStatus.Enabled = true;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
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
            //criar obj da classe fornecedor para usar os metodos de consulta 
            ClassFornecedor objclassFornecedor = new ClassFornecedor();

            //Variavel que sera utilizada pelo switch/case com a escolha feita pelo usuario na combo de opções

            string consulta = cbOpcoes.SelectedItem.ToString();

            //declara o switch
            switch (consulta)
            {
                case "Nome":
                    // Verificar se o usuario preencheu o nome
                    if (txtNome.Text != "")
                    {
                        //se tipo pesquisa = inicio 
                        if (rbInicio.Checked == true)
                        {
                            //chamar o metodo de consulta que será exibido no datagrid 
                            dgvFuncionario.DataSource = objclassFornecedor.ConsultaFornecedorNomeInicial(txtNome.Text);
                        }
                        else // se tipo pesquisa = contém 
                        {
                            dgvFuncionario.DataSource = objclassFornecedor.ConsultaFornecedorNomeContem(txtNome.Text);
                        }

                    }
                    else // validação da caixinha
                    {
                        MessageBox.Show("Favor preecher um NOME ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }
                    break;

                case "Cidade":

                    if (Tb_cidade.Text != "")
                    {

                        dgvFuncionario.DataSource = objclassFornecedor.ConsultaFornecedorCidade(Tb_cidade.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor preecher um Cidade", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Tb_cidade.Focus();

                    }
                    break;

                case "CNPJ":

                    if (tbCnpjFornecedor.Text != "  .   .   /    -")
                    {
                        dgvFuncionario.DataSource = objclassFornecedor.ConsultaFornecedorCNPJ(tbCnpjFornecedor.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor informar um CNPJ valido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbCnpjFornecedor.Focus();
                    }
                    break;


                case "Estado":

                    if (tbEstadoFornecedor.Text != "Selecione:")
                    {
                        dgvFuncionario.DataSource = objclassFornecedor.ConsultaFornecedorEstado(tbEstadoFornecedor.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor preecher um Estado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbEstadoFornecedor.Focus();

                    }
                    break;

                case "Status":

                    if (rbAtivo.Checked == true)
                    {
                        dgvFuncionario.DataSource = objclassFornecedor.ConsultaFornecedorStatus(1);
                    }
                    else
                    {
                        dgvFuncionario.DataSource = objclassFornecedor.ConsultaFornecedorStatus(0);
                    }
                    break;


            }

        }


        //Clicar na grid de funcionarios e dtar ou exxcluir um funcionario
        //usar o evento cellclick (pode clicar em qualquer lugar da celula, nao somnete no texto)
        //usando evento cellcontenteclick(tem q cllicar no conteudo(texto)

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            // perguntar se deseja alterar o funcionario selecionado 
            if (MessageBox.Show("Deseja alterar o funcionario selecionado", "atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassFornecedor objclassFornecedor = new ClassFornecedor();

                FormFornecedor fFornecedor = new FormFornecedor();


                //
                objclassFornecedor.ConsultaFuncionario(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));

                //passar os dados do DBConcurrencyException para os controles do Form de fornecedor

               fFornecedor.tbId_Fornecedor.Text = objclassFornecedor.id_fornecedor.ToString();

                fFornecedor.datacad = objclassFornecedor.data_cadastro;

                if (objclassFornecedor.status == 1)
                {
                    fFornecedor.cbStatus.Checked = true;
                }
                else
                {
                    fFornecedor.cbStatus.Checked = false;
                }

                

                fFornecedor.tbRazaoFornecedor.Text = objclassFornecedor.razao_social;
                fFornecedor.tbFantasiaFornecedor.Text = objclassFornecedor.nome_fantasia;
                fFornecedor.tbEmailFornecedor.Text = objclassFornecedor.email;
                fFornecedor.tbTelefoneFornecedor.Text = objclassFornecedor.telefone_principal;
                fFornecedor.tbTelefoneRecadoFornecedor.Text = objclassFornecedor.telefone_recado;
                fFornecedor.tbCepFornecedor.Text = objclassFornecedor.cep;
                fFornecedor.tbEnderecoFornecedor.Text = objclassFornecedor.endereco;
                fFornecedor.tbNumeroFornecedor.Text = objclassFornecedor.numero.ToString();
                fFornecedor.tbCidadeFornecedor.Text = objclassFornecedor.cidade;
                fFornecedor.tbCnpjFornecedor.Text = objclassFornecedor.cnpj;
                fFornecedor.estado = objclassFornecedor.estado;
                fFornecedor.tbObservacaoFornecedor.Text = objclassFornecedor.observacao;

                //MANDAR A INFORMAÇÃO DE  UPDATE PARA A VARIÁVEL DO FORM DE CADASTRO
                fFornecedor.tipo = "Atualização";
                ////ABRIR FORMULÁRIO DE CADASTRO PARA ATUALIZAÇÃO EM MODO EXCLUSIVO
                fFornecedor.ShowDialog();
                // CHAMAR METODO DE PESQUISA
                btPesquisar_Click(this, new EventArgs());


            }
        }
    }
}
        
    

