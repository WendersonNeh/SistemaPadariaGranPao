using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaPadariaGranPao
{
   class ClassFornecedor
    {
        public ClassFornecedor()
        {
            id_fornecedor = 0;
            razao_social = null;
            nome_fantasia = null;
            email = null;
            telefone_principal = null;
            telefone_recado = null;
            cep = null;
            endereco = null;
            numero = 0;
            cidade = null;
            cnpj = null;
            estado = null;
            status = 0;
            data_cadastro = DateTime.Now;
            observacao = null;
        }

        public int id_fornecedor { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string email { get; set; }
        public string telefone_principal { get; set; }
        public string telefone_recado { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string cnpj { get; set; }
        public string estado { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }
        public string observacao { get; set; }

        public int CadastrarFornecedor()
        {
            string query = " insert into fornecedor values(0, '" + razao_social + "', '" + nome_fantasia + "','" + email + "','" + telefone_principal + "','" + telefone_recado + "','" + cep + "','" + endereco + "'," + numero + ",'" + cidade + "','" + cnpj + "','" + estado + "', 1, now(),'" + observacao + "' )";
            ClassConexao objConexao = new ClassConexao();
            return objConexao.ExecutaQuery(query);
        }

        public DataTable BuscarFornecedor()
        {
            string query = "SELECT id_fornecedor, razao_social FROM fornecedor WHERE status = 1 ORDER BY razao_social";
            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }


        // MÉTODOS DE PESQUISA DE FORNECEDOR
        //POR NOME inicial e final, CIDADE, CNPJ, ESTADO E STATUS
        //CAMPOS EXIBIDOS NA CONSULTA: CÓDIGO, RAZAO, FANTASIA, CNPJ, ESTADO, TELEFONE, E-MAIL

        //CONSULTA DE FUNCIONÁRIO POR NOME(INICIAL)
        public DataTable ConsultaFornecedorNomeInicial(string nomei)
        {
            string query = "SELECT id_fornecedor 'Cod', razao_social 'Razão Social', nome_fantasia 'Nome Fantasia', cidade 'Cidade', cnpj 'CNPJ', estado 'Estado', telefone_principal 'Telefone', email 'E-mail', status 'Status' FROM fornecedor WHERE razao_social LIKE '" + nomei + "%' AND status = 1 ORDER BY razao_social";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //nome contem
        public DataTable ConsultaFornecedorNomeContem(string nomec)
        {
            string query = "SELECT id_fornecedor 'Cod', razao_social 'Razão Social', nome_fantasia 'Nome Fantasia', cidade 'Cidade', cnpj 'CNPJ', estado 'Estado', telefone_principal 'Telefone', email 'E-mail', status 'Status' FROM fornecedor WHERE razao_social LIKE '%" + nomec + "%' AND status = 1 ORDER BY razao_social";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //cidade
        public DataTable ConsultaFornecedorCidade(string cidade)
        {
            string query = "SELECT id_fornecedor 'Cod', razao_social 'Razão Social', nome_fantasia 'Nome Fantasia', cidade 'Cidade', cnpj 'CNPJ', estado 'Estado', telefone_principal 'Telefone', email 'E-mail', status 'Status' FROM fornecedor WHERE cidade = '" + cidade + "' AND status = 1 ORDER BY razao_social";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //cnpj
        public DataTable ConsultaFornecedorCNPJ(string cnpj)
        {
            string query = "SELECT id_fornecedor 'Cod', razao_social 'Razão Social', nome_fantasia 'Nome Fantasia', cidade 'Cidade', cnpj 'CNPJ', estado 'Estado', telefone_principal 'Telefone', email 'E-mail', status 'Status' FROM fornecedor WHERE cnpj = '" + cnpj + "' AND status = 1 ORDER BY razao_social";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //estado
        public DataTable ConsultaFornecedorEstado(string estado)
        {
            string query = "SELECT id_fornecedor 'Cod', razao_social 'Razão Social', nome_fantasia 'Nome Fantasia', cidade 'Cidade', cnpj 'CNPJ', estado 'Estado', telefone_principal 'Telefone', email 'E-mail', status 'Status' FROM fornecedor WHERE estado = '" + estado + "' AND status = 1 ORDER BY razao_social";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //status
        public DataTable ConsultaFornecedorStatus(int status)
        {
            string query = "SELECT id_fornecedor 'Cod', razao_social 'Razão Social', nome_fantasia 'Nome Fantasia', cidade 'Cidade', cnpj 'CNPJ', estado 'Estado', telefone_principal 'Telefone', email 'E-mail', status 'Status' FROM fornecedor WHERE status = " + status + " ORDER BY razao_social";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //buscar funcionario e editar na grid 

        public bool ConsultaFuncionario(int id)
        {
            //EXIBIR TODOS OS DADOS DO FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM fornecedor WHERE id_fornecedor = " + id + " ";

            ClassConexao objConexao = new ClassConexao();

            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = objConexao.RetornaDataTable(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_fornecedor = Convert.ToInt32(dt.Rows[0]["id_fornecedor"]);
                razao_social = Convert.ToString(dt.Rows[0]["razao_social"]);
                nome_fantasia = Convert.ToString(dt.Rows[0]["nome_fantasia"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                telefone_principal = Convert.ToString(dt.Rows[0]["telefone_principal"]);
                telefone_recado = Convert.ToString(dt.Rows[0]["telefone_recado"]);
                cep = Convert.ToString(dt.Rows[0]["cep"]);
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                cnpj = Convert.ToString(dt.Rows[0]["cnpj"]);
                estado = Convert.ToString(dt.Rows[0]["estado"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);

                return true;

            }
            else //SE A CONSULTA NÃO DER CERTO
            {
                return false;
            }
        }

        ////Atualizar cadastro
        public bool AtualizarFuncionario()
        {
            string query = "UPDATE fornecedor set razao_social = '"+ razao_social + "', nome_fantasia = '" + nome_fantasia + "' , email = '" + email + "', telefone_principal = '" + telefone_principal + "', telefone_recado = '" + telefone_recado + "', cep = '" + cep + "' , endereco = '" + endereco + "', numero = " + numero + ", cidade = '" + cidade + "', cnpj = '" + cnpj + "' , estado = '" + estado + "', status = " + status + ", observacao = '" + observacao + "' WHERE id_fornecedor =  " + id_fornecedor + " ; ";

            ClassConexao objConexao = new ClassConexao();

            int resp = objConexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Excluir
        public bool ExcluirFuncionario()
        {
            string query = "DELETE FROM fornecedor WHERE id_fornecedor = " + id_fornecedor + "; ";

            ClassConexao objConexao = new ClassConexao();
            int resp = objConexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Ralatórios
        //Ralatórios Fornecedor
        //Ralatórios: data cadastro / cidade / estado / status 
        //campos vou ver 

        //OPÇÕES DO RELATÓRIO: ANIVERSARIANTES POR DIA E MÊS, ANIVERSARIANTES POR MÊS, ANIVERSARIANTES POR IDADE, CIDADE, DATA DE ADMISSÃO, SEXO E STATUS*/
        /*CAMPOS EXIBIDOS NO RELATÓRIO: NOME, CPF, NASCIMENTO, CIDADE, ADMISSÃO, SETOR E CARGO*/
  
        //relatorios entre datas
        public DataTable RelFornecedorData(DateTime datai, DateTime dataf)
        {
            string query = "SELECT id_fornecedor,razao_social,nome_fantasia,email,telefone_principal,telefone_recado,cep,endereco,numero,cidade,cnpj,estado,status,data_cadastro,observacao FROM fornecedor WHERE data_cadastro BETWEEN '" + datai.ToString("yyyy-MM-dd") + "' AND '" + dataf.ToString("yyyy-MM-dd") + "' and status = 1 ORDER by data_cadastro";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        //Cidade 
        public DataTable RelFornecedorCidade(string cidade,int status)
        {
            string query = "SELECT id_fornecedor,razao_social,nome_fantasia,email,telefone_principal,telefone_recado,cep,endereco,numero,cidade,cnpj,estado,status,data_cadastro,observacao FROM fornecedor WHERE cidade = '" + cidade + "' and status = " + status + " ORDER by razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        //Estado
        public DataTable RelFornecedorEstado(string estado, int status)
        {
            string query = "SELECT id_fornecedor,razao_social,nome_fantasia,email,telefone_principal,telefone_recado,cep,endereco,numero,cidade,cnpj,estado,status,data_cadastro,observacao FROM fornecedor WHERE estado = '" + estado + "' and status = " + status + " ORDER by razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        //status

        public DataTable RelFornecedorStatus(int status)
        {
            string query = "SELECT id_fornecedor,razao_social,nome_fantasia,email,telefone_principal,telefone_recado,cep,endereco,numero,cidade,cnpj,estado,status,data_cadastro,observacao FROM fornecedor WHERE status = " + status + " ORDER by razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }











    }
}
