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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tbRazaoFornecedor.Clear();
            tbRazaoFornecedor.Focus();
            tbRazaoFornecedor.BackColor = Color.White;
            tbFantasiaFornecedor.Clear();
            tbFantasiaFornecedor.BackColor = Color.White;
            tbEmailFornecedor.Clear();
            tbTelefoneFornecedor.BackColor = Color.White;
            tbTelefoneFornecedor.Clear();
            tbTelefoneRecadoFornecedor.Clear();
            tbCepFornecedor.Clear();
            tbCepFornecedor.BackColor = Color.White;
            tbEnderecoFornecedor.Clear();
            tbEnderecoFornecedor.BackColor = Color.White;
            tbNumeroFornecedor.Clear();
            tbNumeroFornecedor.BackColor = Color.White;
            tbCidadeFornecedor.Clear();
            tbCidadeFornecedor.BackColor = Color.White;
            tbCnpjFornecedor.Clear();
            tbCnpjFornecedor.BackColor = Color.White;
            tbObservacaoFornecedor.Clear();
            tbEstadoFornecedor.SelectedItem = "Selecione:";
            label18.BackColor = Color.Transparent;
            tbRazaoFornecedor.Focus();
        }
        
        //VARIÁVEL estado: INFORMAÇÃO É MPSTRADA EM UMA COMBO
        public string estado, tipo;

        //VARIÁVEL datacad: MOSTRAR INFORMAÇÃO GUARDADA NO BD E NÃO DATA ATUAL COMO PROGRAMADO NO LOAD DO FORM
        public DateTime datacad;

        private void FormFornecedor_Load(object sender, EventArgs e)
        {

            Data_Cadastro1.Text = DateTime.Now.ToShortDateString();

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

            if(tipo == "Atualização")
            {
                LbTitulo.Text = "Atualização Fornecedor";
                Data_Cadastro1.Text = datacad.ToString("dd-MM-yyyy");
                cbStatus.Enabled = true;
                Data_Cadastro1.Enabled = true;
                btCadastrar.Enabled = false;
                btAtualizar.Enabled = true;
                btExcluir.Enabled = true;
                tbEstadoFornecedor.SelectedItem = estado.ToString();
            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ClassFornecedor objFornecedor = new ClassFornecedor();


            if (tbRazaoFornecedor.Text != ""  && tbFantasiaFornecedor.Text != "" && tbTelefoneFornecedor.Text != "" && tbCepFornecedor.Text != "     -" && tbEnderecoFornecedor.Text != "" && tbNumeroFornecedor.Text != "(  )    -" && tbCidadeFornecedor.Text != "" && tbCnpjFornecedor.Text != "  .   .   /    -" && tbEstadoFornecedor.Text != "Selecione:")
            {

                objFornecedor.razao_social = tbRazaoFornecedor.Text;
                objFornecedor.nome_fantasia = tbFantasiaFornecedor.Text;
                objFornecedor.email = tbEmailFornecedor.Text;
                objFornecedor.telefone_principal = tbTelefoneFornecedor.Text;
                //objFornecedor.telefone_recado = tbTelefoneRecadoFornecedor.Text;
                objFornecedor.cep = tbCepFornecedor.Text;
                objFornecedor.endereco = tbEnderecoFornecedor.Text;
                objFornecedor.numero = Convert.ToInt32(tbNumeroFornecedor.Text);
                objFornecedor.cidade = tbCidadeFornecedor.Text;
                objFornecedor.cnpj = tbCnpjFornecedor.Text;
                objFornecedor.estado = tbEstadoFornecedor.SelectedItem.ToString(); 
                objFornecedor.observacao = tbObservacaoFornecedor.Text;


                if (tbTelefoneRecadoFornecedor.Text == "(  )    -")
                {
                    objFornecedor.telefone_recado = "";
                }
                else
                {
                    objFornecedor.telefone_recado = tbTelefoneRecadoFornecedor.Text;
                }

                int resp = objFornecedor.CadastrarFornecedor();

                if (resp == 1)
                {
                    MessageBox.Show("Fornecedor Cadastrado com sucesso", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Fornecedor", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else 
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Validação do campo 
                if (string.IsNullOrEmpty(tbRazaoFornecedor.Text.Trim()))
                {
                    tbRazaoFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbRazaoFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbFantasiaFornecedor
                if (string.IsNullOrEmpty(tbFantasiaFornecedor.Text.Trim()))
                {
                    tbFantasiaFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbFantasiaFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbTelefoneFornecedor
                if (string.IsNullOrEmpty(tbTelefoneFornecedor.Text.Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")))
                {
                    tbTelefoneFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbTelefoneFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbCepFornecedor
                if (string.IsNullOrEmpty(tbCepFornecedor.Text.Trim().Replace("-", "").Replace(" ", "")))
                {
                    tbCepFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbCepFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbEnderecoFornecedor
                if (string.IsNullOrEmpty(tbEnderecoFornecedor.Text.Trim()))
                {
                    tbEnderecoFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbEnderecoFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbNumeroFornecedor
                if (string.IsNullOrEmpty(tbNumeroFornecedor.Text.Trim()))
                {
                    tbNumeroFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbNumeroFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbCnpjFornecedor
                if (string.IsNullOrEmpty(tbCnpjFornecedor.Text.Trim().Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "")))
                {
                    tbCnpjFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbCnpjFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbEstadoFornecedor
                if (tbEstadoFornecedor.Text.Trim().Equals("Selecione:"))
                {
                    label18.BackColor = Color.LemonChiffon;
                }
                else
                {
                    label18.BackColor = Color.Transparent;
                }

                //cidade
                if (string.IsNullOrEmpty(tbCidadeFornecedor.Text.Trim()))
                {
                    tbCidadeFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbCidadeFornecedor.BackColor = Color.White;
                }
            }

        }

        private void tbNumeroFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 )
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

            ClassFornecedor objFornecedor = new ClassFornecedor();


            if (tbRazaoFornecedor.Text != "" && tbFantasiaFornecedor.Text != "" && tbTelefoneFornecedor.Text != "" && tbCepFornecedor.Text != "     -" && tbEnderecoFornecedor.Text != "" && tbNumeroFornecedor.Text != "(  )    -" && tbCidadeFornecedor.Text != "" && tbCnpjFornecedor.Text != "  .   .   /    -" && tbEstadoFornecedor.Text != "Selecione:")
            {

                objFornecedor.razao_social = tbRazaoFornecedor.Text;
                objFornecedor.nome_fantasia = tbFantasiaFornecedor.Text;
                objFornecedor.email = tbEmailFornecedor.Text;
                objFornecedor.telefone_principal = tbTelefoneFornecedor.Text;
                objFornecedor.cep = tbCepFornecedor.Text;
                objFornecedor.endereco = tbEnderecoFornecedor.Text;
                objFornecedor.numero = Convert.ToInt32(tbNumeroFornecedor.Text);
                objFornecedor.cidade = tbCidadeFornecedor.Text;
                objFornecedor.cnpj = tbCnpjFornecedor.Text;
                objFornecedor.estado = tbEstadoFornecedor.SelectedItem.ToString();
                objFornecedor.observacao = tbObservacaoFornecedor.Text;


                if (tbTelefoneRecadoFornecedor.Text == "(  )    -")
                {
                    objFornecedor.telefone_recado = "";
                }
                else
                {
                    objFornecedor.telefone_recado = tbTelefoneRecadoFornecedor.Text;
                }

                // checbox status
                if (cbStatus.Checked == true)
                {
                   objFornecedor.status = 1;
                }
                else
                {
                    objFornecedor.status = 0;
                }

                //código funcionário 
                objFornecedor.id_fornecedor = Convert.ToInt32(tbId_Fornecedor.Text);

                //chamar o método atualizar da classe funcionario
                bool resp = objFornecedor.AtualizarFuncionario();

                //PEGAR A RESPOSTA DO MÉTODO CADASTRAR - SE DER 1 FOI CADASTRADO
                if (resp == true)
                {
                    MessageBox.Show("Funcionário Atualizado com Sucesso", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Funcionário", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                

            }
            else
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Validação do campo 
                if (string.IsNullOrEmpty(tbRazaoFornecedor.Text.Trim()))
                {
                    tbRazaoFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbRazaoFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbFantasiaFornecedor
                if (string.IsNullOrEmpty(tbFantasiaFornecedor.Text.Trim()))
                {
                    tbFantasiaFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbFantasiaFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbTelefoneFornecedor
                if (string.IsNullOrEmpty(tbTelefoneFornecedor.Text.Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")))
                {
                    tbTelefoneFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbTelefoneFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbCepFornecedor
                if (string.IsNullOrEmpty(tbCepFornecedor.Text.Trim().Replace("-", "").Replace(" ", "")))
                {
                    tbCepFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbCepFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbEnderecoFornecedor
                if (string.IsNullOrEmpty(tbEnderecoFornecedor.Text.Trim()))
                {
                    tbEnderecoFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbEnderecoFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbNumeroFornecedor
                if (string.IsNullOrEmpty(tbNumeroFornecedor.Text.Trim()))
                {
                    tbNumeroFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbNumeroFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbCnpjFornecedor
                if (string.IsNullOrEmpty(tbCnpjFornecedor.Text.Trim().Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "")))
                {
                    tbCnpjFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbCnpjFornecedor.BackColor = Color.White;
                }

                // Validação do campo tbEstadoFornecedor
                if (tbEstadoFornecedor.Text.Trim().Equals("Selecione:"))
                {
                    label18.BackColor = Color.LemonChiffon;
                }
                else
                {
                    label18.BackColor = Color.Transparent;
                }

                //cidade
                if (string.IsNullOrEmpty(tbCidadeFornecedor.Text.Trim()))
                {
                    tbCidadeFornecedor.BackColor = Color.LemonChiffon;
                }
                else
                {
                    tbCidadeFornecedor.BackColor = Color.White;
                }
            }


        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Funcionário?", "Sistema GranPao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassFornecedor objFornecedor = new ClassFornecedor();
                objFornecedor.id_fornecedor = Convert.ToInt32(tbId_Fornecedor.Text);

                bool resp = objFornecedor.ExcluirFuncionario();

                if (resp == true)
                {
                    MessageBox.Show("Funcionário" + objFornecedor.razao_social + "excluido com sucesso", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Funcionário não pode ser excluido, há registros em outras tabelas.", "Sistema GranPao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
