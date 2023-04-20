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
    public partial class formRelFuncionario : Form
    {
        public formRelFuncionario()
        {
            InitializeComponent();
        }
        private void formRelFuncionario_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Data de Cadastro");
            cbTipoRel.Items.Add("Estado");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            ////CARREGAR COMBOBOX CARGO
            //classCargo cCargo = new classCargo();
            //cbCargo.DataSource = cCargo.BuscarCargo();
            ////EXIBIR NA COMBO
            //cbCargo.DisplayMember = "nome";
            ////GUARDAR NO BD
            //cbCargo.ValueMember = "codigo_cargo";
            //cbCargo.SelectedIndex = -1;

            ////CARREGAR COMBOBOX SETOR
            //classSetor cSetor = new classSetor();
            //cbSetor.DataSource = cSetor.BuscarSetor();
            ////EXIBIR NA COMBO
            //cbSetor.DisplayMember = "nome";
            ////GUARDAR NO BD
            //cbSetor.ValueMember = "codigo_setor";
            //cbSetor.SelectedIndex = -1;


            this.rptvFornecedor.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Aniversariantes por Dia e Mês
            {
                gbAniversariantes.Enabled = true;
                cbMes.Enabled = true;
                cbDia.Enabled = true;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 1)//Aniversariantes do Mês
            {
                gbAniversariantes.Enabled = true;
                cbMes.Enabled = true;
                cbDia.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 2)//Aniversariantes Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                gbCidade.Enabled = false;
                txtIdadeInicial.Focus();
            }
            if (cbTipoRel.SelectedIndex == 3)//Cargo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = true;
                gbSetor.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 4)//Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                gbCidade.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 5)//Data de Admissão
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 6)//Setor
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = true;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 7)//Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 8)//Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbSetor.Enabled = false;
                gbCidade.Enabled = false;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            ClassFornecedor objclassFornecedor = new ClassFornecedor();

            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch (relatorio)
            {
                // 

                case "Data de Cadastro":
                    DateTime datai = Convert.ToDateTime(dtpDataInicial.Text);
                    DateTime dataf = Convert.ToDateTime(dtpDataFinal.Text);
                    if (datai <= dataf)
                    {
                        ClassFornecedorBindingSource.DataSource = objclassFornecedor.RelFornecedorData(datai, dataf);
                        rptvFornecedor.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Data inicial não pode ser maior que data final", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }

        }
    }
}
