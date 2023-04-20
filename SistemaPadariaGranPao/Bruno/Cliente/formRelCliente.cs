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
    public partial class formRelCliente : Form
    {
        public formRelCliente()
        {
            InitializeComponent();
        }

        private void formRelCliente_Load(object sender, EventArgs e)
        {
            cbTipoRel.Items.Add("Tipo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Data Cadastro");
            cbTipoRel.Items.Add("Estado");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Estado Civil");

            CbEstado.Items.Add("SP");
            CbEstado.Items.Add("RJ");
            CbEstado.Items.Add("AC");
            CbEstado.Items.Add("MG");
            CbEstado.Sorted = true;

            CbEstadoCivil.Items.Add("Solteiro(a)");
            CbEstadoCivil.Items.Add("Casado(a)");
            CbEstadoCivil.Items.Add("Divorciado(a)");
            CbEstadoCivil.Items.Add("Viúvo(a)");
            CbEstadoCivil.Items.Add("Separado Judcialmente");
            CbEstadoCivil.Sorted = true;
            CbEstadoCivil.SelectedItem = "Solteiro(a)";

            ClassCliente ObjClassCliente = new ClassCliente();
            CbCidade.DataSource = ObjClassCliente.CarregaCidadeRel();
            CbCidade.DisplayMember = "cidade";
            CbCidade.ValueMember = "cidade";
            CbCidade.SelectedIndex = -1;
        }
    }
}
