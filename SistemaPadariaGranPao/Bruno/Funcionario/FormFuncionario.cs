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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }
        public string tipo, estado, estado_civil, tipo_acesso;
        public int cargo, departamento;
        public DateTime datacad;

        public void Limpar()
        {
            TbCodFuncionario.Text = "";
            TbNome.Text = "";
            MskDataNascimento.Text = "";
            MskCpf.Text = "";
            MskRg.Text = "";
            RbFeminino.Checked = false;
            RbMasculino.Checked = false;
            CbEstadoCivil.SelectedItem = "Solteiro(a)";
            CbCargo.SelectedIndex = -1;
            CbDepartamento.SelectedIndex = -1;
            TbSalario.Text = "";
            MskPrincipal.Text = "";
            MskResidencial.Text = "";
            MskRecado.Text = "";
            TbEmail.Text = "";
            MskCep.Text = "";
            TbEndereco.Text = "";
            TbNumero.Text = "";
            TbComplemento.Text = "";
            TbBairro.Text = "";
            TbCidade.Text = "";
            CbEstado.SelectedItem = "SP";
            TbLogin.Text = "";
            TbSenha.Text = "";
            CbTipoAcesso.SelectedItem = "Comum";
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            LbDataCadastro.Text = DateTime.Now.ToShortDateString();

            CbEstado.Items.Add("SP");
            CbEstado.Items.Add("RJ");
            CbEstado.Items.Add("AC");
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

            CbTipoAcesso.Items.Add("Comum");
            CbTipoAcesso.Items.Add("Administrador");
            CbTipoAcesso.SelectedItem = "Comum";

            ClassCargo ObjClassCargo = new ClassCargo();
            CbCargo.DataSource = ObjClassCargo.BuscarCargo();

            CbCargo.DisplayMember = "nome";
            CbCargo.ValueMember = "id_cargo";
            CbCargo.SelectedIndex = -1;

            ClassDepartamento objclassSetor = new ClassDepartamento();
            CbDepartamento.DataSource = objclassSetor.BuscarDepartamento();

            CbDepartamento.DisplayMember = "nome";
            CbDepartamento.ValueMember = "id_departamento";
            CbDepartamento.SelectedIndex = -1;

            if(tipo == "Atualização")
            {
                lbTitulo.Text = "Atualição de Funcionario";
                BtCadastrar.Enabled = false;
                BtAtualizar.Enabled = true;
                BtExcluir.Enabled = true;
                CbStatus.Enabled = true;

                CbCargo.SelectedValue = cargo;
                CbDepartamento.SelectedValue = departamento;
                CbEstado.SelectedItem = estado;
                CbEstadoCivil.SelectedItem = estado_civil;
                CbTipoAcesso.SelectedItem = tipo_acesso;
                LbDataCadastro.Text = datacad.ToString("dd/MM/yyyy");
            }
            else
            {
                BtCadastrar.Enabled = true;
                BtAtualizar.Enabled = false;
                BtExcluir.Enabled = false;
                CbStatus.Enabled = false;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ClassFuncionario ObjClassFuncionario = new ClassFuncionario();

            if (TbNome.Text != string.Empty && MskDataNascimento.Text != "  /  /" && MskCpf.Text != "   .   .   -" && (RbFeminino.Checked == true || RbMasculino.Checked == true) && CbCargo.SelectedIndex != -1 && CbDepartamento.SelectedIndex != -1 && TbSalario.Text != "" && MskPrincipal.Text != "(  )     -" && MskCep.Text != "     -" && TbEndereco.Text != string.Empty && TbNumero.Text != string.Empty && TbBairro.Text != string.Empty && TbCidade.Text != string.Empty && CbEstado.SelectedIndex != -1 && TbLogin.Text != string.Empty && TbSenha.Text != string.Empty && CbTipoAcesso.SelectedIndex != -1) 
            {
                ObjClassFuncionario.data_nascimento = Convert.ToDateTime(MskDataNascimento.Text);
                ObjClassFuncionario.data_cadastro = Convert.ToDateTime(LbDataCadastro.Text);
                if (MskRg.Text != "  .   .   -") { ObjClassFuncionario.rg = MskRg.Text; }
                else { ObjClassFuncionario.rg = ""; }

                if (RbFeminino.Checked == true) { ObjClassFuncionario.sexo = "F"; }
                else { ObjClassFuncionario.sexo = "M"; }

                if (CbEstadoCivil.SelectedIndex != -1) { ObjClassFuncionario.estado_civil = CbEstadoCivil.SelectedItem.ToString(); }
                else { ObjClassFuncionario.estado_civil = string.Empty; }

                if (TbSalario.Text != string.Empty) { ObjClassFuncionario.salario = Convert.ToDecimal(TbSalario.Text); }
                else { ObjClassFuncionario.salario = 0; }

                if (MskResidencial.Text != "(  )    -") { ObjClassFuncionario.telefone_residencial = MskResidencial.Text; }
                else { ObjClassFuncionario.telefone_residencial = ""; }

                if (MskRecado.Text != "(  )     -") { ObjClassFuncionario.telefone_recado = MskRecado.Text; }
                else { ObjClassFuncionario.telefone_recado = ""; }

                ObjClassFuncionario.id_cargo = Convert.ToInt32(CbCargo.SelectedValue);
                ObjClassFuncionario.id_departamento = Convert.ToInt32(CbDepartamento.SelectedValue);
                ObjClassFuncionario.nome = TbNome.Text;
                ObjClassFuncionario.cpf = MskCpf.Text;
                ObjClassFuncionario.telefone_celular = MskPrincipal.Text;
                ObjClassFuncionario.email = TbEmail.Text;
                ObjClassFuncionario.cep = MskCep.Text;
                ObjClassFuncionario.endereco = TbEndereco.Text;
                ObjClassFuncionario.numero = Convert.ToInt32(TbNumero.Text);
                ObjClassFuncionario.complemento = TbComplemento.Text;
                ObjClassFuncionario.bairro = TbBairro.Text;
                ObjClassFuncionario.cidade = TbCidade.Text;
                ObjClassFuncionario.estado = CbEstado.SelectedItem.ToString();
                ObjClassFuncionario.login = TbLogin.Text;
                ObjClassFuncionario.senha = TbSenha.Text;
                ObjClassFuncionario.tipo_acesso = CbTipoAcesso.SelectedItem.ToString();

                int RespDb = ObjClassFuncionario.CadastrarFuncionarios();

                if (RespDb == 1)
                {
                    MessageBox.Show("Funcionario Cadastrado com Sucesso!", "Sistema Gran Pão", MessageBoxButtons.OK);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Funcionario!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbSenha.Text = "";
                }  
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatorios com *", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbNome.BackColor = Color.LemonChiffon;
                MskDataNascimento.BackColor = Color.LemonChiffon;
                MskCpf.BackColor = Color.LemonChiffon;
                TbSalario.BackColor = Color.LemonChiffon;
                MskPrincipal.BackColor = Color.LemonChiffon;
                MskCep.BackColor = Color.LemonChiffon;
                TbEndereco.BackColor = Color.LemonChiffon;
                TbNumero.BackColor = Color.LemonChiffon;
                TbBairro.BackColor = Color.LemonChiffon;
                TbCidade.BackColor = Color.LemonChiffon;
                TbLogin.BackColor = Color.LemonChiffon;
                TbSenha.BackColor = Color.LemonChiffon;
                GbCargo.BackColor = Color.LemonChiffon;
                GbDepartamento.BackColor = Color.LemonChiffon;
            }
        }

        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            ClassFuncionario ObjClassFuncionario = new ClassFuncionario();

            if (TbNome.Text != string.Empty && MskDataNascimento.Text != "  /  /    " && MskCpf.Text != "   .   .   -  " && (RbFeminino.Checked == true || RbMasculino.Checked == true) && CbCargo.SelectedIndex != -1 && CbDepartamento.SelectedIndex != -1 && TbSalario.Text != "" && MskPrincipal.Text != "(  )     -    " && MskCep.Text != "     -   " && TbEndereco.Text != string.Empty && TbNumero.Text != string.Empty && TbBairro.Text != string.Empty && TbCidade.Text != string.Empty && CbEstado.SelectedIndex != -1 && TbLogin.Text != string.Empty && TbSenha.Text != string.Empty && CbTipoAcesso.SelectedIndex != -1)
            {
                ObjClassFuncionario.id_funcionario = Convert.ToInt32(TbCodFuncionario.Text);
                ObjClassFuncionario.data_nascimento = Convert.ToDateTime(MskDataNascimento.Text);
                ObjClassFuncionario.data_cadastro = Convert.ToDateTime(LbDataCadastro.Text);
                if (CbStatus.Checked == true) { ObjClassFuncionario.status = 1; }
                else { ObjClassFuncionario.status = 0; }

                if (MskRg.Text != "  .   .   -") { ObjClassFuncionario.rg = MskRg.Text; }
                else { ObjClassFuncionario.rg = ""; }

                if (RbFeminino.Checked == true) { ObjClassFuncionario.sexo = "F"; }
                else { ObjClassFuncionario.sexo = "M"; }

                if (CbEstadoCivil.SelectedIndex != -1) { ObjClassFuncionario.estado_civil = CbEstadoCivil.SelectedItem.ToString(); }
                else { ObjClassFuncionario.estado_civil = string.Empty; }

                if (TbSalario.Text != string.Empty) { ObjClassFuncionario.salario = Convert.ToDecimal(TbSalario.Text); }
                else { ObjClassFuncionario.salario = 0; }

                if (MskResidencial.Text != "(  )    -") { ObjClassFuncionario.telefone_residencial = MskResidencial.Text; }
                else { ObjClassFuncionario.telefone_residencial = ""; }

                if (MskRecado.Text != "(  )     -") { ObjClassFuncionario.telefone_recado = MskRecado.Text; }
                else { ObjClassFuncionario.telefone_recado = ""; }

                ObjClassFuncionario.id_cargo = Convert.ToInt32(CbCargo.SelectedValue);
                ObjClassFuncionario.id_departamento = Convert.ToInt32(CbDepartamento.SelectedValue);
                ObjClassFuncionario.nome = TbNome.Text;
                ObjClassFuncionario.cpf = MskCpf.Text;
                ObjClassFuncionario.telefone_celular = MskPrincipal.Text;
                ObjClassFuncionario.email = TbEmail.Text;
                ObjClassFuncionario.cep = MskCep.Text;
                ObjClassFuncionario.endereco = TbEndereco.Text;
                ObjClassFuncionario.numero = Convert.ToInt32(TbNumero.Text);
                ObjClassFuncionario.complemento = TbComplemento.Text;
                ObjClassFuncionario.bairro = TbBairro.Text;
                ObjClassFuncionario.cidade = TbCidade.Text;
                ObjClassFuncionario.estado = CbEstado.SelectedItem.ToString();
                ObjClassFuncionario.login = TbLogin.Text;
                ObjClassFuncionario.senha = TbSenha.Text;
                ObjClassFuncionario.tipo_acesso = CbTipoAcesso.SelectedItem.ToString();

                int RespDb = ObjClassFuncionario.AtualizaFuncionario();

                if (RespDb == 1)
                {
                    MessageBox.Show("Funcionario Atulizado com Sucesso!", "Sistema Gran Pão", MessageBoxButtons.OK);
                    TbSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Funcionario!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbSenha.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatorios com *", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbNome.BackColor = Color.LemonChiffon;
                MskDataNascimento.BackColor = Color.LemonChiffon;
                MskCpf.BackColor = Color.LemonChiffon;
                TbSalario.BackColor = Color.LemonChiffon;
                MskPrincipal.BackColor = Color.LemonChiffon;
                MskCep.BackColor = Color.LemonChiffon;
                TbEndereco.BackColor = Color.LemonChiffon;
                TbNumero.BackColor = Color.LemonChiffon;
                TbBairro.BackColor = Color.LemonChiffon;
                TbCidade.BackColor = Color.LemonChiffon;
                TbLogin.BackColor = Color.LemonChiffon;
                TbSenha.BackColor = Color.LemonChiffon;
                GbCargo.BackColor = Color.LemonChiffon;
                GbDepartamento.BackColor = Color.LemonChiffon;
            }
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            ClassFuncionario ObjClassFuncionario = new ClassFuncionario();
            if (MessageBox.Show("Tem certeza que Deseja Excluir esse cadastro?", "Sistema Gran Pão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ObjClassFuncionario.id_funcionario = Convert.ToInt32(TbCodFuncionario.Text);
                int resp = ObjClassFuncionario.DeletaFuncionario();

                if (resp == 1)
                {
                    MessageBox.Show("Funcionario Deletado com Sucesso!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    if (MessageBox.Show("Impossivel Deletar, esse funcionario faz parte de outras Tabelas do Sistema, Gostaria de Inativalo?", "Sistema Gran Pão", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        CbStatus.Checked = false;
                        BtAtualizar_Click(this, new EventArgs());
                    }
                }
            }
        }


        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);

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

        private void TbSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
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