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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public string estado, estado_civil, sexo, tipo;
        public int RespDb;
        public DateTime datacad;
        private void FormCliente_Load(object sender, EventArgs e)
        {
            LbDataCadastro.Text = DateTime.Now.ToString();

            CbEstado.Items.Add("RJ");
            CbEstado.Items.Add("AC");
            CbEstado.Items.Add("SP");
            CbEstado.Items.Add("MG");
            CbEstado.Sorted = true;
            CbEstado.SelectedItem = "SP";

            CbEstadoCivil.Items.Add("Solteiro(a)");
            CbEstadoCivil.Items.Add("Casado(a)");
            CbEstadoCivil.Items.Add("Divorciado(a)");
            CbEstadoCivil.Items.Add("Viúvo(a)");
            CbEstadoCivil.Items.Add("Separado Judcialmente");
            CbEstadoCivil.Sorted = true;
            CbEstadoCivil.SelectedItem = "Solteiro(a)";

            GbCNPJ.Enabled = false;
            TbNomeFantasia.Enabled = false;
            TbRazaoSocial.Enabled = false;

            BtAtualizar.Enabled = false;
            BtExcluir.Enabled = false;

            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Cliente";
                CbStatus.Enabled = true;
                LbDataCadastro.Enabled = true;
                LbDataCadastro.Text = datacad.ToString("dd-MM-yyyy");
                CbEstado.SelectedItem = estado;
                CbEstadoCivil.SelectedItem = estado_civil;
                BtCadastrar.Enabled = false;
                BtAtualizar.Enabled = true;
                BtExcluir.Enabled = true;

                if (RbJuridica.Checked == true)
                {
                    GbCNPJ.Enabled = true;
                    TbNomeFantasia.Enabled = true;
                    TbRazaoSocial.Enabled = true;
                    MskDataNascimento.Text = "";
                }
            }
        }

        private void RbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (RbFisica.Checked == true)
            {
                GbCPF.Enabled = true;
                TbNome.Enabled = true;
                MskDataNascimento.Enabled = true;
                gbSexo.Enabled = true;
                gbEstadoCivil.Enabled = true;
                gbRg.Enabled = true;
            }
            else
            {
                GbCPF.Enabled = false;
                TbNome.Enabled = false;
                MskDataNascimento.Enabled = false;
                gbSexo.Enabled = false;
                gbEstadoCivil.Enabled = false;
                gbRg.Enabled = false;
            }
        }

        private void RbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (RbJuridica.Checked == true)
            {
                GbCNPJ.Enabled = true;
                TbRazaoSocial.Enabled = true;
                TbNomeFantasia.Enabled = true;
            }
            else
            {
                GbCNPJ.Enabled = false;
                TbRazaoSocial.Enabled = false;
                TbNomeFantasia.Enabled = false;
            }
        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            ClassCliente ObjClassCliente = new ClassCliente();

            if (((TbNome.Text != string.Empty && MskDataNascimento.Text != "  /  /    " && (RbFeminino.Checked == true || RbMasculino.Checked == true)) || (TbRazaoSocial.Text != "" && TbNomeFantasia.Text != "")) && (MskCpf.Text != "   .   .   -" || MskCnpj.Text != "  .   .   /    -")  && MskPrincipal.Text != "(  )     -    " && MskCep.Text != "     -   " && TbEndereco.Text != string.Empty && TbNumero.Text != string.Empty && TbBairro.Text != string.Empty && TbCidade.Text != string.Empty && CbEstado.SelectedIndex != -1)
            {
                ObjClassCliente.telefone_celular = MskPrincipal.Text;
                ObjClassCliente.email = TbEmail.Text;
                ObjClassCliente.cep = MskCep.Text;
                ObjClassCliente.endereco = TbEndereco.Text;
                ObjClassCliente.numero = Convert.ToInt32(TbNumero.Text);
                ObjClassCliente.complemento = TbComplemento.Text;
                ObjClassCliente.bairro = TbBairro.Text;
                ObjClassCliente.cidade = TbCidade.Text;
                ObjClassCliente.estado = CbEstado.SelectedItem.ToString();

                if (MskResidencial.Text != "(  )    -")
                {
                    ObjClassCliente.telefone_residencial = MskResidencial.Text;
                }
                else
                {
                    ObjClassCliente.telefone_residencial = "";
                }

                if (MskRecado.Text != "(  )     -")
                {
                    ObjClassCliente.telefone_recado = MskRecado.Text;
                }
                else
                {
                    ObjClassCliente.telefone_recado = "";
                }

                if (RbFisica.Checked == true)
                {
                    ObjClassCliente.cpf = MskCpf.Text;
                    ObjClassCliente.nome = TbNome.Text;
                    ObjClassCliente.tipo = "F";
                    ObjClassCliente.data_nascimento = Convert.ToDateTime(MskDataNascimento.Text);
                    ObjClassCliente.estado_civil = CbEstadoCivil.SelectedItem.ToString();

                    if (MskRg.Text != "  .   .   -")
                    {
                        ObjClassCliente.rg = MskRg.Text;
                    }
                    else
                    {
                        ObjClassCliente.rg = "";
                    }

                    if (RbFeminino.Checked == true)
                    {
                        ObjClassCliente.sexo = "F";
                    }

                    if (RbMasculino.Checked == true)
                    {
                        ObjClassCliente.sexo = "M";
                    }

                    RespDb = ObjClassCliente.CadastrarClienteFisico();
                }

                if (RbJuridica.Checked == true)
                {
                    ObjClassCliente.nome_fantasia = TbNomeFantasia.Text;
                    ObjClassCliente.razao_social = TbRazaoSocial.Text;
                    ObjClassCliente.cnpj = MskCnpj.Text;
                    ObjClassCliente.tipo = "J";
                    ObjClassCliente.data_nascimento = Convert.ToDateTime("01/01/1999");

                    RespDb = ObjClassCliente.CadastrarClienteJuridico();
                }

                if (RespDb == 1)
                {
                    MessageBox.Show("Cliente Cadastrado com Sucesso!", "Sistema Gran Pão", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Cliente", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatorios com *", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (RbFisica.Checked == true)
                {
                    TbNome.BackColor = Color.LemonChiffon;
                    MskDataNascimento.BackColor = Color.LemonChiffon;
                    MskCpf.BackColor = Color.LemonChiffon;
                    MskPrincipal.BackColor = Color.LemonChiffon;
                    MskCep.BackColor = Color.LemonChiffon;
                    TbEndereco.BackColor = Color.LemonChiffon;
                    TbNumero.BackColor = Color.LemonChiffon;
                    TbBairro.BackColor = Color.LemonChiffon;
                    TbCidade.BackColor = Color.LemonChiffon;
                }
                else
                {
                    TbNomeFantasia.BackColor = Color.LemonChiffon;
                    TbRazaoSocial.BackColor = Color.LemonChiffon;
                    MskCnpj.BackColor = Color.LemonChiffon;
                    MskPrincipal.BackColor = Color.LemonChiffon;
                    MskCep.BackColor = Color.LemonChiffon;
                    TbEndereco.BackColor = Color.LemonChiffon;
                    TbNumero.BackColor = Color.LemonChiffon;
                    TbBairro.BackColor = Color.LemonChiffon;
                    TbCidade.BackColor = Color.LemonChiffon;
                }
            }
        }

        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            ClassCliente ObjClassCliente = new ClassCliente();

            if (((TbNome.Text != string.Empty && MskDataNascimento.Text != "  /  /    " && (RbFeminino.Checked == true || RbMasculino.Checked == true)) || (TbRazaoSocial.Text != "" && TbNomeFantasia.Text != "")) && (MskCpf.Text != "   .   .   -" || MskCnpj.Text != "  .   .   /    -") && MskPrincipal.Text != "(  )     -    " && MskCep.Text != "     -   " && TbEndereco.Text != string.Empty && TbNumero.Text != string.Empty && TbBairro.Text != string.Empty && TbCidade.Text != string.Empty && CbEstado.SelectedIndex != -1)
            {

                ObjClassCliente.id_cliente = Convert.ToInt32(TbCodCliente.Text);
                ObjClassCliente.data_cadastro = Convert.ToDateTime(LbDataCadastro.Text);
                ObjClassCliente.telefone_celular = MskPrincipal.Text;
                ObjClassCliente.email = TbEmail.Text;
                ObjClassCliente.cep = MskCep.Text;
                ObjClassCliente.endereco = TbEndereco.Text;
                ObjClassCliente.numero = Convert.ToInt32(TbNumero.Text);
                ObjClassCliente.complemento = TbComplemento.Text;
                ObjClassCliente.bairro = TbBairro.Text;
                ObjClassCliente.cidade = TbCidade.Text;
                ObjClassCliente.estado = CbEstado.SelectedItem.ToString();

                if (MskResidencial.Text != "(  )    -")
                {
                    ObjClassCliente.telefone_residencial = MskResidencial.Text;
                }
                else
                {
                    ObjClassCliente.telefone_residencial = "";
                }

                if (MskRecado.Text != "(  )     -")
                {
                    ObjClassCliente.telefone_recado = MskRecado.Text;
                }
                else
                {
                    ObjClassCliente.telefone_recado = "";
                }

                if (RbFisica.Checked == true)
                {
                    ObjClassCliente.cpf = MskCpf.Text;
                    ObjClassCliente.nome = TbNome.Text;
                    ObjClassCliente.tipo = "F";
                    ObjClassCliente.data_nascimento = Convert.ToDateTime(MskDataNascimento.Text);
                    ObjClassCliente.estado_civil = CbEstadoCivil.SelectedItem.ToString();

                    if (MskRg.Text != "  .   .   -")
                    {
                        ObjClassCliente.rg = MskRg.Text;
                    }
                    else
                    {
                        ObjClassCliente.rg = "";
                    }

                    if (RbFeminino.Checked == true)
                    {
                        ObjClassCliente.sexo = "F";
                    }

                    if (RbMasculino.Checked == true)
                    {
                        ObjClassCliente.sexo = "M";
                    }

                    RespDb = ObjClassCliente.AtualizaClienteFisico();
                }

                if (RbJuridica.Checked == true)
                {
                    ObjClassCliente.nome_fantasia = TbNomeFantasia.Text;
                    ObjClassCliente.razao_social = TbRazaoSocial.Text;
                    ObjClassCliente.cnpj = MskCnpj.Text;
                    ObjClassCliente.tipo = "J";
                    ObjClassCliente.data_nascimento = Convert.ToDateTime("01/01/1999");

                    RespDb = ObjClassCliente.AtualizaClienteJuridico();
                }

                if (RespDb == 1)
                {
                    MessageBox.Show("Cliente Atualizado com Sucesso!", "Sistema Gran Pão", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar Cliente", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatorios com *", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (RbFisica.Checked == true)
                {
                    TbNome.BackColor = Color.LemonChiffon;
                    MskDataNascimento.BackColor = Color.LemonChiffon;
                    MskCpf.BackColor = Color.LemonChiffon;
                    MskPrincipal.BackColor = Color.LemonChiffon;
                    MskCep.BackColor = Color.LemonChiffon;
                    TbEndereco.BackColor = Color.LemonChiffon;
                    TbNumero.BackColor = Color.LemonChiffon;
                    TbBairro.BackColor = Color.LemonChiffon;
                    TbCidade.BackColor = Color.LemonChiffon;
                }
                if (RbJuridica.Checked == true)
                {
                    TbNomeFantasia.BackColor = Color.LemonChiffon;
                    TbRazaoSocial.BackColor = Color.LemonChiffon;
                    MskCnpj.BackColor = Color.LemonChiffon;
                    MskPrincipal.BackColor = Color.LemonChiffon;
                    MskCep.BackColor = Color.LemonChiffon;
                    TbEndereco.BackColor = Color.LemonChiffon;
                    TbNumero.BackColor = Color.LemonChiffon;
                    TbBairro.BackColor = Color.LemonChiffon;
                    TbCidade.BackColor = Color.LemonChiffon;
                }
            }
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Sistema Gran Pão", MessageBoxButtons.YesNo);

            if (Sair == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void MskDataNascimento_Leave(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(MskDataNascimento.Text, out DateTime result))
            {
                MessageBox.Show("Por favor Insira uma Data Valida", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MskDataNascimento.Focus();
            }
        }
    }
}
