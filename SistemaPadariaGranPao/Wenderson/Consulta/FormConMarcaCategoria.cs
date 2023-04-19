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
    public partial class FormConMarcaCategoria : Form
    {
        public FormConMarcaCategoria()
        {
            InitializeComponent();
        }


        private void FormConMarcaCategoria_Load(object sender, EventArgs e)
        {
            //CARREGAR OPÇÕES DE BUSCA NA COMBO
            cbOpcoes.Items.Add("Marca");
            cbOpcoes.Items.Add("Categoria");
            cbOpcoes.Items.Add("Status");

            //DEIXAR SELECIONADA A OPÇÃO NOME
            cbOpcoes.SelectedItem = "Marca";
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcoes.SelectedIndex == 0) //Marca
            {

                gbStatus.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbNome.Enabled = true;
                txtNome.Focus();
            }

            if (cbOpcoes.SelectedIndex == 1) //Categoria
            {

                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbNome.Enabled = true;
                txtNome.Focus();
            }

            if (cbOpcoes.SelectedIndex == 2) //Status
            {

                gbStatus.Enabled = true;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
            }
        }

        private void btPesquisarMarca_Click(object sender, EventArgs e)
        {
            //criar obj da classe fornecedor para usar os metodos de consulta 
            ClassMarca objclassMarca = new ClassMarca();

            //Variavel que sera utilizada pelo switch/case com a escolha feita pelo usuario na combo de opções

            string consulta = cbOpcoes.SelectedItem.ToString();

            //declara o switch
            switch (consulta)
            {
                case "Marca":
                    // Verificar se o usuario preencheu o nome

                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked == true && rbAtivo.Checked == true)
                        {
                            dgvSimples.DataSource = objclassMarca.ConsultaMarcaNomeInicialStatus(txtNome.Text, 1);
                        }
                        else if (rbInicio.Checked == true && rbAtivo.Checked == false )
                        {
                            dgvSimples.DataSource = objclassMarca.ConsultaMarcaNomeInicialStatus(txtNome.Text, 0);
                        }
                        else if (rbContem.Checked == true && rbAtivo.Checked == true)
                        {
                            dgvSimples.DataSource = objclassMarca.ConsultaMarcaNomeContemStatus(txtNome.Text, 1);
                        }
                        else if(rbContem.Checked == true && rbAtivo.Checked == false)
                        {
                            dgvSimples.DataSource = objclassMarca.ConsultaMarcaNomeContemStatus(txtNome.Text, 0);
                        }

                    }
                    else
                    {
                        if (rbAtivo.Checked == true)
                        {
                            dgvSimples.DataSource = objclassMarca.ConsultaMarcaNomeTodos(1);
                        }
                        else
                        {
                            dgvSimples.DataSource = objclassMarca.ConsultaMarcaNomeTodos(0);

                        }
                    }
                    
                    break;
            }
        }
    }
} 