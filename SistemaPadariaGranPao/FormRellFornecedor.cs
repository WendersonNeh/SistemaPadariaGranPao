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
            cbTipoRel.Items.Add("Aniversariantes por Dia e Mês");
            cbTipoRel.Items.Add("Aniversariantes do Mês");
            cbTipoRel.Items.Add("Aniversariantes Idade");
            cbTipoRel.Items.Add("Cargo");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Data de Admissão");
            cbTipoRel.Items.Add("Setor");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 2;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO DIA
            cbDia.Items.Add("Escolha um Dia");
            cbDia.Items.Add("01");
            cbDia.Items.Add("02");
            cbDia.Items.Add("03");
            cbDia.Items.Add("04");
            cbDia.Items.Add("05");
            cbDia.Items.Add("06");
            cbDia.Items.Add("07");
            cbDia.Items.Add("08");
            cbDia.Items.Add("09");
            cbDia.Items.Add("10");
            cbDia.Items.Add("11");
            cbDia.Items.Add("12");
            cbDia.Items.Add("13");
            cbDia.Items.Add("14");
            cbDia.Items.Add("15");
            cbDia.Items.Add("16");
            cbDia.Items.Add("17");
            cbDia.Items.Add("18");
            cbDia.Items.Add("19");
            cbDia.Items.Add("20");
            cbDia.Items.Add("21");
            cbDia.Items.Add("22");
            cbDia.Items.Add("23");
            cbDia.Items.Add("24");
            cbDia.Items.Add("25");
            cbDia.Items.Add("26");
            cbDia.Items.Add("27");
            cbDia.Items.Add("28");
            cbDia.Items.Add("29");
            cbDia.Items.Add("30");
            cbDia.Items.Add("31");
            cbDia.SelectedIndex = 0;

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

                case "Data de Admissão":
                    DateTime datai = Convert.ToDateTime(dtpDataInicial.Text);
                    DateTime dataf = Convert.ToDateTime(dtpDataFinal.Text);
                    if (datai <= dataf)
                    {
                        ClassFornecedorBindingSource.DataSource = objclassFornecedor.RelFuncionarioDataAdmissaoteste(datai, dataf);
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
