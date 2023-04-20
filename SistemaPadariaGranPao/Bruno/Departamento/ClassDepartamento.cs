using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaPadariaGranPao
{
    class ClassDepartamento
    {
        public ClassDepartamento()
        {
            id_departamento = 0;
            nome = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        public int id_departamento
        {
            get; set;
        }
        public string nome
        {
            get; set;
        }
        public int status
        {
            get; set;
        }
        public DateTime data_cadastro
        {
            get; set;
        }
        public string observacao
        {
            get; set;
        }

        public int CadastrarDepartamento()
        {
            string query = $"INSERT INTO departamento VALUES (0, '{nome}', 1, now(), '{observacao}')";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.ExecutaQuery(query);
        }

        public DataTable BuscarDepartamento()
        {
            string query = "SELECT id_departamento, nome FROM departamento WHERE status = 1 ORDER BY nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }
    }
}