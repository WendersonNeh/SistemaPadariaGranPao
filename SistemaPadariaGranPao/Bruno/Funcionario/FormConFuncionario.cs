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
    public partial class FormConFuncionario : Form
    {
        public FormConFuncionario()
        {
            InitializeComponent();
        }

        private void FormConFuncionario_Load(object sender, EventArgs e)
        {
            CbOpcoes.Items.Add("Status");
            CbOpcoes.Items.Add("CPF");
            CbOpcoes.Items.Add("Nome");
            CbOpcoes.Items.Add("Cargo");
            CbOpcoes.Items.Add("Departamento");
            CbOpcoes.SelectedItem = "Nome";

            GbStatus.Enabled = false;
            GbCPF.Enabled = false;
            GbDepartamento.Enabled = false;
            GbCargo.Enabled = false;

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
        }

        private void CbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbOpcoes.SelectedItem.ToString() == "Nome")
            {
                GbNome.Enabled = true;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbDepartamento.Enabled = false;
                GbCargo.Enabled = false;
            }
            if(CbOpcoes.SelectedItem.ToString() == "Status")
            {
                GbNome.Enabled = false;
                GbStatus.Enabled = true;
                GbCPF.Enabled = false;
                GbDepartamento.Enabled = false;
                GbCargo.Enabled = false;
            }
            if(CbOpcoes.SelectedItem.ToString() == "CPF")
            {
                GbNome.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = true;
                GbDepartamento.Enabled = false;
                GbCargo.Enabled = false;
            }
            if(CbOpcoes.SelectedItem.ToString() == "Departamento")
            {
                GbNome.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbDepartamento.Enabled = true;
                GbCargo.Enabled = false;
            }
            if (CbOpcoes.SelectedItem.ToString() == "Cargo")
            {
                GbNome.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbDepartamento.Enabled = false;
                GbCargo.Enabled = true;
            }
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            ClassFuncionario ObjClassFuncionario = new ClassFuncionario();

            if (CbOpcoes.SelectedItem.ToString() == "Nome")
            {
                if (TbNome.Text != string.Empty)
                {
                    DgvFuncionario.DataSource = ObjClassFuncionario.ConsultaFuncionarioNome(TbNome.Text);
                }
                else
                {
                    MessageBox.Show("Por favor Insira um Nome para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (CbOpcoes.SelectedItem.ToString() == "Status")
            {
                if(RbAtivo.Checked == true)
                {
                    DgvFuncionario.DataSource = ObjClassFuncionario.ConsultaFuncionarioStatus(1);
                }
                else
                {
                    DgvFuncionario.DataSource = ObjClassFuncionario.ConsultaFuncionarioStatus(0);
                }
            }
            if (CbOpcoes.SelectedItem.ToString() == "CPF")
            {
                if (MskCpf.Text != "   .   .   -")
                {
                    DgvFuncionario.DataSource = ObjClassFuncionario.ConsultaFuncionarioCPF(MskCpf.Text);
                }
                else
                {
                    MessageBox.Show("Por favor Insira um CPF para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (CbOpcoes.SelectedItem.ToString() == "Departamento")
            {
                if (CbDepartamento.SelectedIndex != -1)
                {
                    DgvFuncionario.DataSource = ObjClassFuncionario.ConsultaFuncionarioDepartamento(Convert.ToInt32(CbDepartamento.SelectedValue));
                }
                else
                {
                    MessageBox.Show("Por favor Insira um Departamento para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (CbOpcoes.SelectedItem.ToString() == "Cargo")
            {
                if (CbCargo.SelectedIndex != -1)
                {
                    DgvFuncionario.DataSource = ObjClassFuncionario.ConsultaFuncionarioCargo(Convert.ToInt32(CbCargo.SelectedValue));
                }
                else
                {
                    MessageBox.Show("Por favor Insira um Departamento para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void DgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Você Deseja editar o funcionario selecionado?", "Sistema Gran Pão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassFuncionario ObjClassFuncionario = new ClassFuncionario();
                FormFuncionario ObjFormFuncionario = new FormFuncionario();

                ObjClassFuncionario.RetornaFuncionario(Convert.ToInt32(DgvFuncionario.SelectedRows[0].Cells[0].Value));
                ObjFormFuncionario.TbCodFuncionario.Text = ObjClassFuncionario.id_funcionario.ToString();
                ObjFormFuncionario.datacad = ObjClassFuncionario.data_cadastro;
                if (ObjClassFuncionario.status == 1)
                {
                    ObjFormFuncionario.CbStatus.Checked = true;
                }
                else
                {
                    ObjFormFuncionario.CbStatus.Checked = false;
                }
                ObjFormFuncionario.TbNome.Text = ObjClassFuncionario.nome;
                ObjFormFuncionario.MskDataNascimento.Text = ObjClassFuncionario.data_nascimento.ToString();
                ObjFormFuncionario.MskCpf.Text = ObjClassFuncionario.cpf;
                ObjFormFuncionario.MskRg.Text = ObjClassFuncionario.rg;
                if (ObjClassFuncionario.sexo == "F")
                {
                    ObjFormFuncionario.RbFeminino.Checked = true;
                }
                else
                {
                    ObjFormFuncionario.RbMasculino.Checked = true;
                }
                ObjFormFuncionario.estado_civil = ObjClassFuncionario.estado_civil;
                ObjFormFuncionario.cargo = ObjClassFuncionario.id_cargo;
                ObjFormFuncionario.departamento = ObjClassFuncionario.id_departamento;
                ObjFormFuncionario.TbSalario.Text = ObjClassFuncionario.salario.ToString();
                ObjFormFuncionario.MskResidencial.Text = ObjClassFuncionario.telefone_residencial;
                ObjFormFuncionario.MskRecado.Text = ObjClassFuncionario.telefone_recado;
                ObjFormFuncionario.MskPrincipal.Text = ObjClassFuncionario.telefone_celular;
                ObjFormFuncionario.TbEmail.Text = ObjClassFuncionario.email;
                ObjFormFuncionario.MskCep.Text = ObjClassFuncionario.cep;
                ObjFormFuncionario.TbEndereco.Text = ObjClassFuncionario.endereco;
                ObjFormFuncionario.TbNumero.Text = ObjClassFuncionario.numero.ToString();
                ObjFormFuncionario.TbComplemento.Text = ObjClassFuncionario.complemento;
                ObjFormFuncionario.TbBairro.Text = ObjClassFuncionario.bairro;
                ObjFormFuncionario.TbCidade.Text = ObjClassFuncionario.cidade;
                ObjFormFuncionario.estado = ObjClassFuncionario.estado;
                ObjFormFuncionario.TbLogin.Text = ObjClassFuncionario.login;
                ObjFormFuncionario.tipo_acesso = ObjClassFuncionario.tipo_acesso;
                ObjFormFuncionario.tipo = "Atualização";
                ObjFormFuncionario.ShowDialog();
                BtPesquisar_Click(this, new EventArgs());
            }
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
