using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaPadariaGranPao
{
    class ClassMarca
    {
        public ClassMarca()
        {
            id_marca = 0;
            nome = null;
            status = 0;
            data_cadastro = DateTime.Now;
            observacao = null;
        }

        public int id_marca { get; set; }
        public string nome { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }
        public string observacao { get; set; }

        public int CadastrarMarca()
        {
            string query = " insert into marca values(0, '" + nome + "', 1, now(),'" + observacao + "' )";
            ClassConexao objConexao = new ClassConexao();
            return objConexao.ExecutaQuery(query);
        }

        public DataTable BuscarMarca()
        {
            string query = "SELECT id_marca, nome FROM marca WHERE status = 1 ORDER BY nome";
            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }


        //Consulta

        public DataTable ConsultaMarcaNomeInicialStatus(string nomei, int status)
        {
            string query = " SELECT id_marca 'Cod', nome 'Nome Marca', data_cadastro 'Cadastrada', observacao 'Observação', status 'Status' FROM marca WHERE nome LIKE '" + nomei + "%' AND status = " + status + " ORDER BY nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaMarcaNomeContemStatus(string nomec, int status)
        {
            string query = " SELECT id_marca 'Cod', nome 'Nome Marca', data_cadastro 'Cadastrada', observacao 'Observação', status 'Status' FROM marca WHERE nome LIKE '%" + nomec + "%' AND status = " + status + " ORDER BY nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaMarcaNomeTodos(int status)
        {
            string query = "SELECT id_marca 'Cod', nome 'Nome Marca', data_cadastro 'Cadastrada', observacao 'Observação', status 'Status' FROM marca WHERE status = " + status + " ORDER BY nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }




    }
}
