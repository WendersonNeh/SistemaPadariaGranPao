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
            cbTipoRel.Items.Add("Departamento");
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

            ClassCargo ObjClassCargo = new ClassCargo();
            cbCargo.DataSource = ObjClassCargo.BuscarCargo();
            cbCargo.DisplayMember = "nome";
            cbCargo.ValueMember = "id_cargo";
            cbCargo.SelectedIndex = -1;

            ClassDepartamento ObjClassDepartamento = new ClassDepartamento();
            cbSetor.DataSource = ObjClassDepartamento.BuscarDepartamento();
            cbSetor.DisplayMember = "nome";
            cbSetor.ValueMember = "id_departamento";
            cbSetor.SelectedIndex = -1;

            ClassFuncionario ObjClassFuncionario = new ClassFuncionario();
            cbCidade.DataSource = ObjClassFuncionario.CarregaCidadeRel();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = -1;

            rptvFuncionario.RefreshReport();
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
            if (cbTipoRel.SelectedIndex == 1)
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
            if (cbTipoRel.SelectedIndex == 2)
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
            if (cbTipoRel.SelectedIndex == 3)
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

            if (cbTipoRel.SelectedIndex == 4)
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

            if (cbTipoRel.SelectedIndex == 5)
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
            if (cbTipoRel.SelectedIndex == 6)
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
            if (cbTipoRel.SelectedIndex == 7)
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
            ClassFuncionario ObjClassFuncionario = new ClassFuncionario();

            if (cbTipoRel.SelectedItem.ToString() == "Status")
            {
                if (rbAtivo.Checked == true)
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioStatus(1);
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioStatus(0);
                    rptvFuncionario.RefreshReport();
                }
            }
            if(cbTipoRel.SelectedItem.ToString() == "Aniversariantes do Mês")
            {
                if (cbMes.SelectedIndex != 0)
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioMes(Convert.ToInt32(cbMes.SelectedIndex));
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Favor escolher mês", "Sistema Padaria Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbTipoRel.SelectedItem.ToString() == "Aniversariantes por Dia e Mês")
            {
                if (cbDia.SelectedIndex != 0 && cbMes.SelectedIndex != 0)
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioDiaMes(Convert.ToInt32(cbDia.SelectedIndex), Convert.ToInt32(cbMes.SelectedIndex));
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Favor escolher um Dia e um Mês", "Sistema Padaria Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbTipoRel.SelectedItem.ToString() == "Aniversariantes Idade")
            {
                if(txtIdadeFinal.Text != "" && txtIdadeInicial.Text != "" && Convert.ToInt32(txtIdadeInicial.Text) <= Convert.ToInt32(txtIdadeFinal.Text)) 
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioIdade(Convert.ToInt32(txtIdadeInicial.Text), Convert.ToInt32(txtIdadeFinal.Text));
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Favor informar um intervalo de idades.", "Sistema Padaria Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbTipoRel.SelectedItem.ToString() == "Cargo") 
            { 
                if(cbCargo.SelectedIndex != -1)
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioCargo(Convert.ToInt32(cbCargo.SelectedValue));
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Favor informar um Cargo.", "Sistema Padaria Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbTipoRel.SelectedItem.ToString() == "Cidade")
            {
                if(cbCidade.SelectedIndex != -1)
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioCidade(cbCidade.SelectedValue.ToString());
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Favor informar uma Cidade.", "Sistema Padaria Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbTipoRel.SelectedItem.ToString() == "Data de Admissão")
            {
                if(Convert.ToDateTime(dtpDataInicial.Value) <= Convert.ToDateTime(dtpDataFinal.Value))
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioDataAdmissao(Convert.ToDateTime(dtpDataInicial.Value), Convert.ToDateTime(dtpDataFinal.Value));
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Favor informar um intervalo de datas valido.", "Sistema Padaria Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbTipoRel.SelectedItem.ToString() == "Departamento")
            {
                if (cbSetor.SelectedIndex != -1)
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioDepartamento(Convert.ToInt32(cbSetor.SelectedValue));
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Favor informar um Departamento.", "Sistema Padaria Gran Pão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbTipoRel.SelectedItem.ToString() == "Sexo") 
            {
                if (rbFeminino.Checked == true)
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioSexo("F");
                    rptvFuncionario.RefreshReport();
                }
                else
                {
                    ClassFuncionarioBindingSource.DataSource = ObjClassFuncionario.RelFuncionarioSexo("M");
                    rptvFuncionario.RefreshReport();
                }
            }
        }
    }
}
