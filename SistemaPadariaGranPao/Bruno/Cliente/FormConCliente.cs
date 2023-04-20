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
    public partial class FormConCliente : Form
    {
        public FormConCliente()
        {
            InitializeComponent();
        }

        private void FormConCliente_Load(object sender, EventArgs e)
        {
            CbOpcoes.Items.Add("Nome");
            CbOpcoes.Items.Add("Nome Fantasia");
            CbOpcoes.Items.Add("Razão Social");
            CbOpcoes.Items.Add("CEP");
            CbOpcoes.Items.Add("Estado");
            CbOpcoes.Items.Add("CPF");
            CbOpcoes.Items.Add("CNPJ");
            CbOpcoes.Items.Add("Status");
            CbOpcoes.Items.Add("Tipo");
            CbOpcoes.SelectedItem = "Nome";

            CbEstado.Items.Add("SP");
            CbEstado.Items.Add("RJ");
            CbEstado.Items.Add("AC");
            CbEstado.Items.Add("MG");
            CbEstado.Sorted = true;
        }

        private void CbOpcoes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CbOpcoes.SelectedItem.ToString() == "Tipo")
            {
                GbTipo.Enabled = true;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbCNPJ.Enabled = false;
                GbNome.Enabled = false;
                GbNomeFantasia.Enabled = false;
                GbRazaoSocial.Enabled = false;
                GbCep.Enabled = false;
                GbEstado.Enabled = false;
            }

            if (CbOpcoes.SelectedItem.ToString() == "Status")
            {
                GbTipo.Enabled = false;
                GbStatus.Enabled = true;
                GbCPF.Enabled = false;
                GbCNPJ.Enabled = false;
                GbNome.Enabled = false;
                GbNomeFantasia.Enabled = false;
                GbRazaoSocial.Enabled = false;
                GbCep.Enabled = false;
                GbEstado.Enabled = false;
            }
            if (CbOpcoes.SelectedItem.ToString() == "CPF")
            {
                GbTipo.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = true;
                GbCNPJ.Enabled = false;
                GbNome.Enabled = false;
                GbNomeFantasia.Enabled = false;
                GbRazaoSocial.Enabled = false;
                GbCep.Enabled = false;
                GbEstado.Enabled = false;
            }

            if (CbOpcoes.SelectedItem.ToString() == "CNPJ")
            {
                GbTipo.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbCNPJ.Enabled = true;
                GbNome.Enabled = false;
                GbNomeFantasia.Enabled = false;
                GbRazaoSocial.Enabled = false;
                GbCep.Enabled = false;
                GbEstado.Enabled = false;
            }

            if (CbOpcoes.SelectedItem.ToString() == "Nome")
            {
                GbTipo.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbCNPJ.Enabled = false;
                GbNome.Enabled = true;
                GbNomeFantasia.Enabled = false;
                GbRazaoSocial.Enabled = false;
                GbCep.Enabled = false;
                GbEstado.Enabled = false;
            }

            if (CbOpcoes.SelectedItem.ToString() == "Nome Fantasia")
            {
                GbTipo.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbCNPJ.Enabled = false;
                GbNome.Enabled = false;
                GbNomeFantasia.Enabled = true;
                GbRazaoSocial.Enabled = false;
                GbCep.Enabled = false;
                GbEstado.Enabled = false;
            }

            if (CbOpcoes.SelectedItem.ToString() == "Razão Social")
            {
                GbTipo.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbCNPJ.Enabled = false;
                GbNome.Enabled = false;
                GbNomeFantasia.Enabled = false;
                GbRazaoSocial.Enabled = true;
                GbCep.Enabled = false;
                GbEstado.Enabled = false;
            }

            if (CbOpcoes.SelectedItem.ToString() == "CEP")
            {
                GbTipo.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbCNPJ.Enabled = false;
                GbNome.Enabled = false;
                GbNomeFantasia.Enabled = false;
                GbRazaoSocial.Enabled = false;
                GbCep.Enabled = true;
                GbEstado.Enabled = false;
            }

            if (CbOpcoes.SelectedItem.ToString() == "Estado")
            {
                GbTipo.Enabled = false;
                GbStatus.Enabled = false;
                GbCPF.Enabled = false;
                GbCNPJ.Enabled = false;
                GbNome.Enabled = false;
                GbNomeFantasia.Enabled = false;
                GbRazaoSocial.Enabled = false;
                GbCep.Enabled = false;
                GbEstado.Enabled = true;
            }
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            ClassCliente ObjClassCliente = new ClassCliente();
            if (CbOpcoes.SelectedItem.ToString() == "Tipo")
            {
                if (RbFisico.Checked == true)
                {
                    DgvCliente.DataSource =  ObjClassCliente.ConsultaClienteTipoFisico("F");
                }
                if(RbJuridico.Checked == true)
                {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteTipoJuridico("J");
                }
            }

            if (CbOpcoes.SelectedItem.ToString() == "Status")
            {
               if(RbAtivo.Checked == true)
               {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteStatus(1);
               }

               if (RbInativo.Checked == true)
               {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteStatus(0);
                }
            }
            if (CbOpcoes.SelectedItem.ToString() == "CPF")
            {
                if (MskCpf.Text != "   .   .   -")
                {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteCPF(MskCpf.Text);
                }
                else
                {
                    MessageBox.Show("Por favor Insira um CPF para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (CbOpcoes.SelectedItem.ToString() == "CNPJ")
            {
                if (MskCNPJ.Text != "  .   .   /    -")
                {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteCNJP(MskCNPJ.Text);
                }
                else
                {
                    MessageBox.Show("Por favor Insira um CNPJ para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (CbOpcoes.SelectedItem.ToString() == "Nome")
            {
                if (TbNome.Text != "")
                {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteNome(TbNome.Text);
                }
                else
                {
                    MessageBox.Show("Por favor Insira um Nome para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (CbOpcoes.SelectedItem.ToString() == "Nome Fantasia")
            {
                if (TbNomeFantasia.Text != "")
                {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteNomeFantasia(TbNomeFantasia.Text);
                }
                else
                {
                    MessageBox.Show("Por favor Insira um Nome Fantasia para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            if (CbOpcoes.SelectedItem.ToString() == "Razão Social")
            {
                if (TbRazaoSocial.Text != "")
                {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteRazaoSocial(TbRazaoSocial.Text);
                }
                else
                {
                    MessageBox.Show("Por favor Insira uma Razão Social para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (CbOpcoes.SelectedItem.ToString() == "CEP")
            {
                if (MskCep.Text != "     -")
                {
                    DgvCliente.DataSource = ObjClassCliente.ConsultaClienteCEP(MskCep.Text);
                }
                else
                {
                    MessageBox.Show("Por favor Insira um CEP para busca!", "Sistema Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (CbOpcoes.SelectedItem.ToString() == "Estado")
            {
                DgvCliente.DataSource = ObjClassCliente.ConsultaClienteEstado(CbEstado.SelectedItem.ToString());
            }

        }

        private void DgvCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Você Deseja editar o Cliente selecionado?", "Sistema Gran Pão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassCliente ObjClassCliente = new ClassCliente();
                FormCliente ObjFormCliente = new FormCliente();

                ObjClassCliente.RetornaCliente(Convert.ToInt32(DgvCliente.SelectedRows[0].Cells[0].Value));
                ObjFormCliente.TbCodCliente.Text = ObjClassCliente.id_cliente.ToString();
                ObjFormCliente.datacad = ObjClassCliente.data_cadastro;
                if (ObjClassCliente.status == 1)
                {
                    ObjFormCliente.CbStatus.Checked = true;
                }
                else
                {
                    ObjFormCliente.CbStatus.Checked = false;
                }

                ObjFormCliente.TbNome.Text = ObjClassCliente.nome;
                ObjFormCliente.MskDataNascimento.Text = ObjClassCliente.data_nascimento.ToString();
                ObjFormCliente.MskCpf.Text = ObjClassCliente.cpf;
                ObjFormCliente.MskRg.Text = ObjClassCliente.rg;

                if (ObjClassCliente.sexo == "F")
                {
                    ObjFormCliente.RbFeminino.Checked = true;
                }

                if(ObjClassCliente.sexo == "M")
                {
                    ObjFormCliente.RbMasculino.Checked = true;
                }

                ObjFormCliente.estado_civil = ObjClassCliente.estado_civil;
                ObjFormCliente.MskResidencial.Text = ObjClassCliente.telefone_residencial;
                ObjFormCliente.MskRecado.Text = ObjClassCliente.telefone_recado;
                ObjFormCliente.MskPrincipal.Text = ObjClassCliente.telefone_celular;
                ObjFormCliente.TbEmail.Text = ObjClassCliente.email;
                ObjFormCliente.MskCep.Text = ObjClassCliente.cep;
                ObjFormCliente.TbEndereco.Text = ObjClassCliente.endereco;
                ObjFormCliente.TbNumero.Text = ObjClassCliente.numero.ToString();
                ObjFormCliente.TbComplemento.Text = ObjClassCliente.complemento;
                ObjFormCliente.TbBairro.Text = ObjClassCliente.bairro;
                ObjFormCliente.TbCidade.Text = ObjClassCliente.cidade;
                ObjFormCliente.estado = ObjClassCliente.estado;
                ObjFormCliente.MskCnpj.Text = ObjClassCliente.cnpj;
                ObjFormCliente.TbNomeFantasia.Text = ObjClassCliente.nome_fantasia;
                ObjFormCliente.TbRazaoSocial.Text = ObjClassCliente.razao_social;

                if (ObjClassCliente.tipo == "F")
                {
                    ObjFormCliente.RbFisica.Checked = true;
                }
                else
                {
                    ObjFormCliente.RbJuridica.Checked = true;
                }

                ObjFormCliente.tipo = "Atualização";
                ObjFormCliente.ShowDialog();
                BtPesquisar_Click(this, new EventArgs());
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
    }
}
